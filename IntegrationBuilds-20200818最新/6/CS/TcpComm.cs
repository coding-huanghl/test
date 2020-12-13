using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;

// 2017.11.03：李文
// 修改SocketClient，修正部分错误

namespace TcpComm
{
    /********************************************************************************************************
       TcpServer
            属性
                Active                                              true = 启动服务器, false = 关闭服务器
                ServerPort                                          服务器TCP端口
                MaxClients                                          客户端最大连接数
                ClientCount                                         客户端连接数
                
            事件
                OnError(int errorCode)                              连接或通讯发生错误
                                                                      - errorCode: Windows错误代码
                OnListening                                         服务器进入监听状态
                OnConnected(Socket socket)                          客户端连接成功
                                                                      - socket: 客户端套接字
                OnDisconnected(Socket socket)                       客户端连接断开
                                                                      - socket: 客户端套接字
                OnData(Socket socket, string receivedData)          接收到客户端数据
                                                                      - socket: 客户端套接字
                                                                      - recievedText: 接收到的数据
            方法
                string GetReceivedData(Socket socket)               读取由客户端接收的数据
                void SetReceivedData(Socket socket, string value)   设置由客户端接收的数据 (如清空)
                string GetEndDelimiter(Socket socket)               读取客户端电文结束标志字符串
                void SetEndDelimiter(Socket socket, string value)   设置客户端电文结束标志字符串
                                                                        如果设置了结束标志字符串(非空字符串)，
                                                                        则接收到包含该结束标志字符串的数据时，
                                                                        才产生OnData事件
                bool SendData(Socket socket, string text)           向指定客户端发送数据
                void SendData(string text)                          向全部客户端发送数据
                Socket GetFirstSocket()                             获取第一个客户端套接字
                Socket GetLastSocket()                              获取最后一个客户端套接字
                Socket GetSocket(int index)                         获取指定索引的客户端套接字
                void CloseSocket(Socket socket)                     关闭客户端连接
      
            TcpServer使用方法
                1. 创建TcpServer对象。
                2. 设置ServerPort和MaxClients属性。
                3. 根据需要设置OnError、OnListening、OnConnected、OnDisconnected、OnData事件函数。
                4. 设置Active属性为true，等待客户端连接。
                5. 服务器进入监听状态时，会调用OnListening。
                6. 有客户端与服务器建立连接时，会调用OnConnected，参数为客户端套接字。
                   在该函数中，可以调用SetEndDelimiter设置电文结束标志字符串，由TcpServer自动判断电文结束标志。
                7. 接收到客户端数据时，会调用OnData，参数为客户端套接字及从客户端接收到的数据。
                   如果客户端未设置电文结束标志(EndDelimiter为空字符串)，则每次从客户端接收到数据时，都会触发OnData；
                   如果设置了电文结束标志(EndDelimiter非空)，则将每次从客户端接收到数据合并在一起，直到接收到电文结束标志字符串时，才会触发OnData。
                8. 客户端与服务器断开连接时，会调用OnDisconnected，参数为客户端套接字。
    ********************************************************************************************************/
    public class SocketServer
    {
        class SocketPacket
        {
            public SocketItem SocketItem;
            // 接收缓冲区字节数
            public const int bufSize = 1024;
            // 接收缓冲区
            public byte[] buf = new byte[bufSize];
        }

        class SocketItem
        {
            public Socket socket;
            public string receivedData;
            public string endDelimiter;
            public SocketPacket dataPacket;

            public SocketItem()
            {
                socket = null;
                receivedData = "";
                endDelimiter = "";

                dataPacket = new SocketPacket();
                dataPacket.SocketItem = this;
            }
        };

        /**************************************************************************************************************
         * 内部变量
         *************************************************************************************************************/
        private bool active;                                                // true = 启动服务器, false = 关闭服务器
        private int serverPort;                                             // 服务器口
        private int maxClients;                                             // 客户端最大连接数
        private Socket socket;                                              // 服务器套接字
        private List<SocketItem> clientList;                                // 客户端列表

        private System.Timers.Timer checkSocketTimer;                       // SOCKET连接状态检查定时器

        /**************************************************************************************************************
         * 事件
         *************************************************************************************************************/
        // 事件函数定义
        public delegate void T_OnError(int errorCode);                      // 通讯错误 (参数为错误代码)
        public delegate void T_OnListening();                               // 服务器进入监听状态
        public delegate void T_OnConnected(Socket socket);                  // 客户端连接成功
        public delegate void T_OnDisconnected(Socket socket);               // 客户端断开连接
        public delegate void T_OnData(Socket socket, string receivedData);  // 接收到客户端数据
        // 事件函数
        private T_OnError onError;
        private T_OnListening onListening;
        private T_OnConnected onConnected;
        private T_OnDisconnected onDisconnected;
        private T_OnData onData;

        /**************************************************************************************************************
         * 属性
         *************************************************************************************************************/
        // 属性：true = 启动服务器，false = 关闭服务器
        public bool Active
        {
            get { return active; }
            set { if (value) StartServer(); else StopServer(); }
        }

        // 属性：服务器口
        public int ServerPort
        {
            get { return serverPort; }
            set
            {
                if (value > 0 && value != serverPort)
                {
                    StopServer();
                    serverPort = value;
                }
            }
        }

        // 属性：客户端最大连接数
        public int MaxClients
        {
            get { return maxClients; }
            set { maxClients = value; }
        }

        // 属性：客户端已连接标志
        public int ClientCount
        {
            get
            {
                if (clientList == null) return -1;
                else return clientList.Count;
            }
        }

        // 属性：服务器套接字
        public Socket Socket
        {
            get { return socket; }
        }

        /**************************************************************************************************************
         * 事件
         * *************************************************************************************************************/
        // 事件函数：通讯错误
        public T_OnError OnError
        {
            get { return onError; }
            set { onError = value; }
        }

        // 事件函数: 服务器进入监听状态
        public T_OnListening OnListening
        {
            get { return onListening; }
            set { onListening = value; }
        }

        // 事件函数: 与客户端建立连接
        public T_OnConnected OnConnected
        {
            get { return onConnected; }
            set { onConnected = value; }
        }

        // 事件函数: 客户端断开连接
        public T_OnDisconnected OnDisconnected
        {
            get { return onDisconnected; }
            set { onDisconnected = value; }
        }

        // 事件函数: 接收到客户端数据
        public T_OnData OnData
        {
            get { return onData; }
            set { onData = value; }
        }

        /**************************************************************************************************************
         * 函数实现
         *************************************************************************************************************/

        // 构造函数
        public SocketServer()
        {
            // 初始化
            active = false;
            serverPort = -1;

            socket = null;
            clientList = new List<SocketItem>();

            OnError = null;
            OnListening = null;
            OnConnected = null;
            OnDisconnected = null;
            OnData = null;

            // 创建SOCKET连接状态检查定时器
            checkSocketTimer = new System.Timers.Timer(1000);
            checkSocketTimer.Elapsed += new System.Timers.ElapsedEventHandler(CheckSocketStatus);
            checkSocketTimer.AutoReset = true;
            checkSocketTimer.Enabled = true;
        }  // TcpServer()

        // 析构函数
        ~SocketServer()
        {
            StopServer();
            checkSocketTimer.Enabled = false;
        }

        // 检查SOCKET连接状态
        private void CheckSocketStatus(object source, System.Timers.ElapsedEventArgs e)
        {
            // 2017.11.03：李文
            // 断线自动重连会严重影响运行速度。由调用程序重连
            /*
            for (int index = clientList.Count - 1; index >= 0; index--)
            {
                SocketItem item = clientList[index];
                // 检查SOCKET连接状态。如果连接已断开，则删除该连接。
                if ((item.socket.Poll(1000, SelectMode.SelectRead) && (item.socket.Available == 0)) || !item.socket.Connected)
                {
                    item.socket.Shutdown(System.Net.Sockets.SocketShutdown.Both);
                    clientList.Remove(item);

                    // 外部事件函数调用
                    if (OnDisconnected != null) OnDisconnected(item.socket);
                }
            }  // for
            */
        }

        // 启动服务器
        private void StartServer()
        {
            // 先关闭服务器
            StopServer();
            // 服务器口号不正确，返回
            if (serverPort <= 0) return;

            try
            {
                // 创建服务器套接字
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                // IP地址（本地地址）和端口号绑定
                socket.Bind(new IPEndPoint(IPAddress.Any, serverPort));
                // 启动监听
                socket.Listen(MaxClients);
                // 等待客户连接
                socket.BeginAccept(new AsyncCallback(OnSocketConnect), null);

                // 外部事件函数调用
                if (OnListening != null) OnListening();

                active = true;
            }
            catch (SocketException se)
            {
                if (OnError != null)
                    OnError(se.ErrorCode);
                else
                    MessageBox.Show(se.Message);
            }
        }  // StartServer()

        // 关闭服务器
        private void StopServer()
        {
            try
            {
                foreach (SocketItem item in clientList)
                    item.socket.Shutdown(System.Net.Sockets.SocketShutdown.Both);
                clientList.Clear();

                socket.Close();
                socket = null;

                active = false;
            }
            catch (Exception)
            {
            }
        }  // StopServer()

        // 回调函数：客户端请求连接
        private void OnSocketConnect(IAsyncResult ar)
        {
            if (socket == null) return;
            try
            {
                // 确认客户端连接，保存客户端套接字             
                SocketItem item = new SocketItem();
                item.socket = socket.EndAccept(ar);
                clientList.Add(item);

                // 外部事件函数调用
                if (OnConnected != null) OnConnected(item.socket);

                // 启动异步接收
                item.socket.BeginReceive(
                    item.dataPacket.buf, 0, item.dataPacket.buf.Length, SocketFlags.None,
                    new AsyncCallback(OnSocketData), item.dataPacket);

                // 继续等待客户连接
                socket.BeginAccept(new AsyncCallback(OnSocketConnect), null);
            }
            catch (ObjectDisposedException)
            {
                if (OnError != null)
                    OnError(10057);                     // Windows error code: Socket is not connected.
                else
                    MessageBox.Show("Client request connection: socket has been closed");
            }
            catch (SocketException se)
            {
                if (OnError != null)
                    OnError(se.ErrorCode);
                else
                    MessageBox.Show(se.Message);
            }
        }  // OnSocketConnect()

        // 回调函数：接收客户端数据
        private void OnSocketData(IAsyncResult ar)
        {
            try
            {
                // 获取接收缓冲区对象
                SocketPacket packet = (SocketPacket)ar.AsyncState;
                SocketItem item = packet.SocketItem;

                // 读取接收字符串长度
                int bytesRead = item.socket.EndReceive(ar);
                if (bytesRead > 0)
                {
                    // 与以前接收的数据合并在一起
                    item.receivedData += Encoding.Default.GetString(packet.buf, 0, bytesRead);

                    // 检查是否包含电文结束标志。如果电文结束标志为空字符串，则不检查结束标志。
                    if (item.endDelimiter == "" || item.receivedData.IndexOf(item.endDelimiter) > -1)
                    {
                        if (OnData != null)
                        {
                            // 外部事件函数调用
                            OnData(item.socket, item.receivedData);
                        }
                    }
                    // 继续接收
                    item.socket.BeginReceive(
                        item.dataPacket.buf, 0, item.dataPacket.buf.Length, SocketFlags.None,
                        new AsyncCallback(OnSocketData), item.dataPacket);
                }
            }
            catch (ObjectDisposedException)
            {
                if (OnError != null)
                    OnError(10057);                     // Windows error code: Socket is not connected.
                else
                    MessageBox.Show("Client data arrived: socket has been closed");
            }
            catch (SocketException se)
            {
                if (OnError != null)
                    OnError(se.ErrorCode);
                else
                    MessageBox.Show(se.Message);
            }
        }  // OnSocketData()

        // 读取客户端接收到的数据
        public string GetReceivedData(Socket socket)
        {
            foreach (SocketItem item in clientList)
            {
                if (item.socket == socket) return item.receivedData;
            }
            return "";
        }

        // 设置客户端接收到的数据(如清空)
        public void SetReceivedData(Socket socket, string value)
        {
            foreach (SocketItem item in clientList)
            {
                if (item.socket == socket) item.receivedData = value;
            }
        }

        // 读取客户端电文结束标志字符串
        public string GetEndDelimiter(Socket socket)
        {
            foreach (SocketItem item in clientList)
            {
                if (item.socket == socket) return item.endDelimiter;
            }
            return "";
        }

        // 设置客户端电文结束标志字符串
        // 电文结束标志字符串为空表示不判断电文结束标志
        public void SetEndDelimiter(Socket socket, string value)
        {
            foreach (SocketItem item in clientList)
            {
                if (item.socket == socket) item.endDelimiter = value;
            }
        }

        // 向指定客户端发送数据
        public bool SendData(Socket socket, string text)
        {
            if (socket == null || !socket.Connected) return false;

            try
            {
                socket.Send(Encoding.Default.GetBytes(text));
                return true;
            }
            catch (ObjectDisposedException)
            {
                if (OnError != null)
                    OnError(10057);                     // Windows error code: Socket is not connected.
                else
                    MessageBox.Show("Send data to client: socket has been closed");
            }
            catch (SocketException se)
            {
                if (OnError != null)
                    OnError(se.ErrorCode);
                else
                    MessageBox.Show(se.Message);
            }

            return false;
        }  // SendData()

        // 向所有客户端发送数据
        public void SendData(string text)
        {
            foreach (SocketItem item in clientList) SendData(item.socket, text);
        }  // SendData()


        // 获取第一个客户端套接字
        public Socket GetFirstSocket()
        {
            if (clientList == null || clientList.Count <= 0) return null;
            return clientList[0].socket;
        }

        // 获取最后一个客户端套接字
        public Socket GetLastSocket()
        {
            if (clientList == null || clientList.Count <= 0) return null;
            return clientList[clientList.Count - 1].socket;
        }

        // 获取指定索引的客户端套接字
        public Socket GetSocket(int index)
        {
            if (clientList == null || clientList.Count <= 0) return null;
            if (index < 0 || index >= clientList.Count) return null;
            return clientList[index].socket;
        }

        public Socket GetSocket(IPAddress ip, int Port)
        {
            int index;
            IPAddress SocketIP = null;
            int SocketPort = 0;
            if (clientList == null || clientList.Count <= 0) return null;
            for (index = 0; index < clientList.Count; index++)
            {
                SocketIP = ((IPEndPoint)clientList[index].socket.RemoteEndPoint).Address;
                SocketPort = ((IPEndPoint)clientList[index].socket.RemoteEndPoint).Port;
                if ((SocketIP.ToString() == ip.ToString()) && (SocketPort == Port))
                {
                    return clientList[index].socket;
                }

            }
            return null;
        }

        // 关闭客户端连接
        public void CloseSocket(Socket socket)
        {
            for (int index = clientList.Count - 1; index >= 0; index--)
            {
                SocketItem item = clientList[index];
                if (item.socket == socket)
                {
                    item.socket.Shutdown(System.Net.Sockets.SocketShutdown.Both);
                    clientList.Remove(item);
                    return;
                }
            }  // for
        }

    }  // class TcpServer

    /********************************************************************************************************
       TcpClient
            属性
                Active                                              true = 与服务器建立连接, false = 与服务器断开连接
                ServerIP                                            服务器IP地址
                ServerPort                                          服务器TCP端口
                Connected                                           true = 与服务器已建立连接
                EndDelimiter                                        电文结束标志字符串
                ReceivedData                                        从服务器接收的数据
                Socket                                              客户端套接字
                ClietName                                           客户端名称
            事件
                OnError(int errorCode)                              连接或通讯发生错误
                                                                      - errorCode: Windows错误代码
                OnConnecting()                                      正在与服务器建立连接
                OnConnected()                                       与服务器连接成功
                OnDisconnected()                                    与服务器连接断开
                OnData(string receivedData)                         接收到服务器数据
                                                                      - recievedText: 接收到的数据
            方法
                bool SendData(string text)                          向服务器发送数据
      
            TcpClient使用方法
                1. 创建TcpClient对象。
                2. 设置ServerAddress和ServerPort属性。
                3. 根据需要设置EndDelimiter属性。
                4. 根据需要设置OnError、OnConnected、OnDisconnected、OnData事件函数。
                5. 设置Connected属性为true，与服务器建立连接。连接成功后Connected属性为true。
                6. 与服务器建立连接时，会调用OnConnecting。
                7. 与服务器建立连接成功时，会调用OnConnected。
                8. 接收到服务器数据时，会调用OnData，参数为接收到的数据。
                   如果客户端未设置电文结束标志(EndDelimiter为空字符串)，则每次从客户端接收到数据时，都会触发OnData；
                   如果设置了电文结束标志(EndDelimiter非空)，则将每次从客户端接收到数据合并在一起，直到接收到电文结束标志字符串时，才会触发OnData。
                9. 与服务器断开连接时，会调用OnDisconnected。
    ********************************************************************************************************/
    public class SocketClient
    {
        class SocketPacket
        {
            // 接收缓冲区字节数
            public const int bufSize = 1024;
            // 接收缓冲区
            public byte[] buf = new byte[bufSize];
        }

        /**************************************************************************************************************
         * 内部变量
         *************************************************************************************************************/
        private string serverIP;                                            // 服务器IP地址
        private int serverPort;                                             // 服务器TCP端口
        private bool connected;                                             // true = 与服务器已建立连接
        private string endDelimiter;                                        // 电文结束标志字符串
        private string receivedData;                                        // 从服务器接收到的数据
        private byte[] receivedBytes;                                       // 从服务器接收到的数据
        private int receivedBytesIndex;
        private string clientName;                                          // 客户端ID

        private Socket socket;                                              // 客户端套接字
        private SocketPacket dataPacket;                                    // SOCKET接收数据包

        private System.Timers.Timer checkSocketTimer;                       // SOCKET连接状态检查定时器

        /**************************************************************************************************************
         * 事件
         *************************************************************************************************************/
        // 事件函数定义
        public delegate void T_OnError(int errorCode);                      // 通讯错误 (参数为错误代码)
        public delegate void T_OnConnecting();                              // 正在与服务器建立连接
        public delegate void T_OnConnected();                               // 与服务器连接成功
        public delegate void T_OnDisconnected();                            // 与服务器断开连接
        public delegate void T_OnData(string receivedData);                 // 接收到服务器数据
        public delegate void T_OnDataBytes(byte[] receivedBytes, int count);                 // 接收到服务器数据
        // 事件函数
        private T_OnError onError;
        private T_OnConnecting onConnecting;
        private T_OnConnected onConnected;
        private T_OnDisconnected onDisconnected;
        private T_OnData onData;
        private T_OnDataBytes onDataBytes;

        Object objSocketClient = new Object();

        /**************************************************************************************************************
         * 属性
         *************************************************************************************************************/
        // 属性：服务器IP地址
        public string ServerIP
        {
            get { return serverIP; }
            set
            {
                if (value != serverIP)
                {
                    if (connected) Disconnect(false);
                    serverIP = value;
                }
            }
        }

        // 属性：服务器TCP端口
        public int ServerPort
        {
            get { return serverPort; }
            set
            {
                if (value > 0 && value != serverPort)
                {
                    if (connected) Disconnect(false);
                    serverPort = value;
                }
            }
        }

        // 属性：与服务器连接标志
        public bool Connected
        {
            get { return connected; }
            set { if (value) Connect(); else Disconnect(false); }
        }

        // 属性：电文结束标志字符串
        public string EndDelimiter
        {
            get { return endDelimiter; }
            set { endDelimiter = value; }
        }

        // 属性：从服务器接收到的数据
        public string ReceivedData
        {
            get { return receivedData; }
            set { receivedData = value; }
        }

        // 属性：从服务器接收到的数据
        public byte[] ReceivedBytes
        {
            get { return receivedBytes; }
            set { receivedBytes = value; }
        }

        // 属性：服务器套接字
        public Socket Socket
        {
            get { return socket; }
        }
        // 属性： 客户端ID
        public string ClientName
        {
            set { clientName = value; }
            get { return clientName; }
        }

        /**************************************************************************************************************
         * 事件
         * *************************************************************************************************************/
        // 事件函数：通讯错误
        public T_OnError OnError
        {
            get { return onError; }
            set { onError = value; }
        }

        // 事件函数: 正在与服务器建立连接
        public T_OnConnecting OnConnecting
        {
            get { return onConnecting; }
            set { onConnecting = value; }
        }

        // 事件函数: 与服务器建立连接成功
        public T_OnConnected OnConnected
        {
            get { return onConnected; }
            set { onConnected = value; }
        }

        // 事件函数: 与服务器断开连接
        public T_OnDisconnected OnDisconnected
        {
            get { return onDisconnected; }
            set { onDisconnected = value; }
        }

        // 事件函数: 接收到服务器数据
        public T_OnData OnData
        {
            get { return onData; }
            set { onData = value; }
        }

        // 事件函数: 接收到服务器数据
        public T_OnDataBytes OnDataBytes
        {
            get { return onDataBytes; }
            set { onDataBytes = value; }
        }

        /**************************************************************************************************************
         * 函数实现
         *************************************************************************************************************/

        // 构造函数
        public SocketClient()
        {
            // 初始化
            serverIP = "";
            serverPort = -1;
            connected = false;
            endDelimiter = "";
            receivedData = "";
            receivedBytes = new byte[1024];
            receivedBytesIndex = 0;

            socket = null;
            dataPacket = new SocketPacket();

            OnError = null;
            OnConnected = null;
            OnDisconnected = null;
            OnData = null;
            OnDataBytes = null;

            // 创建SOCKET连接状态检查定时器
            checkSocketTimer = new System.Timers.Timer(1000);
            checkSocketTimer.Elapsed += new System.Timers.ElapsedEventHandler(CheckSocketStatus);
            checkSocketTimer.AutoReset = true;
            checkSocketTimer.Enabled = true;
        }  // TcpClient()


        // 析构函数
        ~SocketClient()
        {
            Disconnect(false);
            checkSocketTimer.Enabled = false;
        }

        // 检查SOCKET连接状态
        private void CheckSocketStatus(object source, System.Timers.ElapsedEventArgs e)
        {
            // 2017.11.03：李文
            // 断线自动重连会严重影响运行速度。由调用程序重连
            /*
            if (!connected)
            {
                if (OnDisconnected != null) OnDisconnected();
                return;
            }

            //新建客户端套接字  

            // 检查SOCKET连接状态。如果连接已断开，则删除该连接。
            if ((socket.Poll(1000, SelectMode.SelectRead) && (socket.Available == 0)) || !socket.Connected)
            {
                Disconnect(true);

                // 外部事件函数调用
                if (OnDisconnected != null) OnDisconnected();
            }
            */
        }

        // 与服务器建立连接
        private void Connect()
        {
            // 先与服务器断开连接
            if (connected) Disconnect(true);

            // 服务器口号不正确，返回
            if (serverIP == "" || serverPort <= 0) return;

            try
            {
                // 创建客户端套接字
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // 与服务器建立连接
                socket.BeginConnect(serverIP, serverPort, new AsyncCallback(OnSocketConnect), socket);


                // 外部事件函数调用
                if (OnConnecting != null) OnConnecting();
            }
            catch (SocketException se)
            {
                if (OnError != null) OnError(se.ErrorCode);
            }
            catch (Exception)
            {
                if (OnError != null) OnError(11003);            // 11003: 不可恢复的SOCKET错误
            }
        }  // StartServer()

        // 与服务器断开连接
        private void Disconnect(bool internalDisconnect)
        {
            if (!connected)
            {
                return;
            }
            try
            {
                if (socket != null)
                {
                    socket.Shutdown(System.Net.Sockets.SocketShutdown.Both);
                    socket = null;
                }

                connected = false;
                if (!internalDisconnect && OnDisconnected != null) OnDisconnected();
            }
            catch (SocketException se)
            {
                if (OnError != null) OnError(se.ErrorCode);
            }
            catch (Exception)
            {
                if (OnError != null) OnError(11003);            // 11003: 不可恢复的SOCKET错误
            }
        }  // StopServer()

        // 回调函数：客户端请求连接
        private void OnSocketConnect(IAsyncResult ar)
        {
//            lock(objSocketClient)
            {
                try
                {
                    if (ar == null) return;

                    Socket s = (Socket)ar.AsyncState;
                    if (s == null) return;

                    //if (!s.Connected)
                    //{
                    //    if (OnDisconnected != null) OnDisconnected();
                    //    return;
                    //}

                    s.EndConnect(ar);
                    connected = true;

                    // 外部事件函数调用
                    if (OnConnected != null)
                    {
                        OnConnected();
                    }

                    /*
                    调用BeginReceive等异步函数时，应该将socket作为ar参数传递，否则可能产生如下异常：
                    Exception: System.ArgumentException: The IAsyncResult object was not returned from the
                    corresponding synchronous method on this class.
                    原因为：
                    If somehow the socket gets disconnected while the ReadCallback is executing and
                    you reconnect it (thereby changing the socket object) -now they don't
                    match, you are trying to complete the Async request using the new object
                    when the old one is the one actually completing.This is why all the
                    examples in MSDN tell you to pass your socket as the "state" parameter - not
                    because it must be passed that way only (although they say it as if it were
                    so) but because doing it their way ensures you are always attempting to call
                    EndReceive on the correct socket corresponding to the IAsyncResult object!
                    You also must get real unlucky and have a thread context switch at just the
                    right moment occasionally which allows the newly connected socket to
                    overwrite your old one -between the start of the callback and when your
                    callback code calls EndReceive.
                    */

                    // 启动异步接收
                    s.BeginReceive(
                        dataPacket.buf, 0, dataPacket.buf.Length, SocketFlags.None,
                        new AsyncCallback(OnSocketData), s);
                }
                catch (SocketException se)
                {
                    if (OnError != null) OnError(se.ErrorCode);
                }
                catch (Exception)
                {
                    if (OnError != null) OnError(11003);            // 11003: 不可恢复的SOCKET错误
                }
            }
        }  // OnSocketConnect()

        // 回调函数：接收客户端数据
        private void OnSocketData(IAsyncResult ar)
        {
//            lock (objSocketClient)
            {
                SocketError err = SocketError.Success;
                if (ar == null) return;

                Socket s = (Socket)ar.AsyncState;
                if (s == null) return;

                try
                {
                    //20181226 黄浩 修改逻辑，防止Disconnected误调
                    if (s.Connected)
                    {
                        // 读取接收字符串长度
                        int bytesRead = s.EndReceive(ar, out err);
                        if (err == SocketError.Success && (bytesRead > 0))
                        {
                            // 与以前接收的数据合并在一起
                            receivedData += Encoding.Default.GetString(dataPacket.buf, 0, bytesRead);
                            for (int i = 0; i < bytesRead; i++)
                                receivedBytes[receivedBytesIndex++] = dataPacket.buf[i];
                        }
                    }

                    //if (!s.Connected)
                    //{
                        
                    //    if (OnDisconnected != null) OnDisconnected();
                    //    return;
                    //}

                    //// 读取接收字符串长度
                    //int bytesRead = s.EndReceive(ar, out err);
                    //if (err == SocketError.Success && (bytesRead > 0))
                    //{
                    //    // 与以前接收的数据合并在一起
                    //    receivedData += Encoding.Default.GetString(dataPacket.buf, 0, bytesRead);
                    //    for (int i = 0; i < bytesRead; i++)
                    //        receivedBytes[receivedBytesIndex++] = dataPacket.buf[i];
                    //}
                }
                catch (SocketException se)
                {
                    err = SocketError.SocketError;
                    if (OnError != null) OnError(se.ErrorCode);
                }
                catch (Exception)
                {
                    err = SocketError.SocketError;
                    if (OnError != null) OnError(11003);            // 11003: 不可恢复的SOCKET错误
                }
                // 读取完缓冲区内容后，马上启动下一次接收，防止漏掉需要接受的数据
                finally
                {
                    if (err == SocketError.Success)
                    {
                        try
                        {
                            // 检查是否包含电文结束标志。如果电文结束标志为空字符串，则不检查结束标志。
                            if (endDelimiter == "" || receivedData.IndexOf(endDelimiter) > -1)
                            {
                                try
                                {
                                    // 外部事件函数调用
                                    if (receivedData != "" && OnData != null)
                                        OnData(receivedData);
                                    if (receivedBytesIndex > 0 && OnDataBytes != null)
                                        OnDataBytes(receivedBytes, receivedBytesIndex);
                                } // try
                                catch (SocketException se)
                                {
                                    if (OnError != null) OnError(se.ErrorCode);
                                }
                                catch (Exception)
                                {
                                    if (OnError != null) OnError(11003);            // 11003: 不可恢复的SOCKET错误
                                }
                                receivedData = "";
                                receivedBytesIndex = 0;
                            }

                            // 继续接收
                            s.BeginReceive(
                                dataPacket.buf, 0, dataPacket.buf.Length, SocketFlags.None,
                                new AsyncCallback(OnSocketData), s);
                        }
                        catch
                        {

                        }
                    }
                }
            }
        }  // OnSocketData()

        // 向指定客户端发送数据
        public bool SendData(string text)
        {
            if (socket == null || !socket.Connected || !connected) return false;

            try
            {
                socket.Send(Encoding.Default.GetBytes(text));
                //发送加0D 0A
                //byte[] tempSendByte = Encoding.Default.GetBytes(text);
                //byte[] sendByte = new byte[tempSendByte.Length + 2];
                //for (int i = 0; i < tempSendByte.Length; i++)
                //{
                //    sendByte[i] = tempSendByte[i];
                //}
                //sendByte[tempSendByte.Length] = 13;
                //sendByte[tempSendByte.Length + 1] = 10;
                //socket.Send(sendByte);
                
                return true;
            }
            catch (Exception)
            {
            }

            return false;
        }  // SendData()
        public bool SendData(byte[] arr)
        {
            if (socket == null || !socket.Connected || !connected) return false;

            try
            {
                socket.Send(arr);
                return true;
            }
            catch (Exception)
            {
            }

            return false;
        }  // SendData()
    }  // class TcpClient


}
