using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace _6
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {


            bool isRuned;
            System.Threading.Mutex mutex = new System.Threading.Mutex(true, Application.ProductName, out isRuned);
            if (isRuned)
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Application.ThreadException += new ThreadExceptionEventHandler(MainForm_UIThreadException);

                // Set the unhandled exception mode to force all Windows Forms errors to go through
                // our handler.
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);


                Application.Run(new MainForm());
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("程序已启动!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            // Add the event handler for handling UI thread exceptions to the event.
            //Application.ThreadException += new ThreadExceptionEventHandler(MainForm_UIThreadException);

            ////Set the unhandled exception mode to force all Windows Forms errors to go through
            //// our handler.
            //Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            //AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            //Application.EnableVisualStyles(); 
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {


            try
            {
                Exception ex = (Exception)e.ExceptionObject;
                string errormsg = "An application error occurred. Please contact the adminstrator " +
                    "with the following information:\n\n";
                Global.SaveLog("D:\\Program Files\\Config\\033\\程序异常.txt",
                          DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss:ff") + ex.Message.ToString());

                // Since we can't prevent the app from terminating, log this to the event log.
                if (!EventLog.SourceExists("ThreadException"))
                {
                    EventLog.CreateEventSource("ThreadException", "Application");
                }

                // Create an EventLog instance and assign its source.
                EventLog myLog = new EventLog();
                myLog.Source = "ThreadException";
                myLog.WriteEntry(errormsg + ex.Message + "\n\nStack Trace:\n" + ex.StackTrace);
            }
            catch (Exception exc)
            {
                //try
                //{
                //    MessageBox.Show("Fatal Non-UI Error. Could not write the error to the event log. Reason: "
                //        + exc.Message, "Fatal Non-UI Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Global.SaveLog("D:\\Program Files\\Config\\033\\程序异常.txt",
                         DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss:ff") + exc.Message.ToString());

                //}
                //finally
                //{
                //    Application.Exit();
                //}
            }


            
        }


        // Creates the error message and displays it.
        private static DialogResult ShowThreadExceptionDialog(string title, Exception e)
        {
            string errormsgDetect = "An application error occurred. Please contact the Program Developer " +
                "with the following information:\n\n";
            errormsgDetect = errormsgDetect + e.Message + "\n\nStack Trace:\n" + e.StackTrace;
            Global.SaveLog("D:\\Program Files\\Config\\033\\程序异常.txt",
                         DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss:ff") + errormsgDetect);

            return MessageBox.Show(errormsgDetect, title, MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Stop);
        }

        internal static void MainForm_UIThreadException(object sender, ThreadExceptionEventArgs e)
        {
            DialogResult result = DialogResult.Cancel;
            try
            {
                result = ShowThreadExceptionDialog("Windows Forms Error", e.Exception);
            }
            catch
            {
                try
                {
                    MessageBox.Show("Fatal Windows Forms Error",
                        "Fatal Windows Forms Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
                }
                finally
                {
                    Application.Exit();
                }
            }

            // Exits the program when the user clicks Abort.
            if (result == DialogResult.Abort)
                Application.Exit();
        }
    }
}
