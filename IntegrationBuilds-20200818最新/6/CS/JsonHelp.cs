using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;

namespace _6.CS
{
     public class JsonHelp
     {
         public static string singleNGClassInfoToJson(SingleNGClassInfo singleNGClassInfo)
         {
             string jsonString = "{";
             PropertyInfo[] propertyInfo = singleNGClassInfo.GetType().GetProperties();
             for (int i = 0; i < propertyInfo.Length; i++)
             {
                 object objectValue = propertyInfo[i].GetGetMethod().Invoke(singleNGClassInfo, null);

                 string value = string.Empty;
                 if (objectValue is string)
                 {
                     value = "\"" + objectValue.ToString() + "\"";
                     jsonString += "\"" + propertyInfo[i].Name + "\":" + value + ",";
                 }
                 else if (objectValue is List<string>)
                 {
                     value = ToArrayString((List<string>)objectValue);
                     jsonString += "\"" + propertyInfo[i].Name + "\":" + value + ",";
                 }
                 else if (objectValue is List<CellInfo>)
                 {
                     foreach (CellInfo item in (List<CellInfo>)objectValue)
                     {
                         string cellInfoStr = cellInfoToJson(item);
                         if (cellInfoStr == "")
                             continue;
                         else
                             jsonString += cellInfoStr + ",";                  
                     }
                 }                
             }
             jsonString = jsonString.Substring(0, jsonString.Length - 1);
            if (jsonString == "")
                return jsonString;
            else
             return jsonString + "}";
         }
         private static string cellInfoToJson(CellInfo cellInfo)
         {
             string jsonString = "";
             if (cellInfo.Cell_index == null)
                 return jsonString;
             else
             {
                 jsonString += "\"" + cellInfo.Cell_index + "\":";
                 if(cellInfo.Info == null)
                     jsonString += "[]"; 
                 else
                 {
                     int cellNGInfoCount = cellInfo.Info.Count;
                     if (cellNGInfoCount == 1)
                         jsonString += "\"" + cellInfo.Info[0].ToString() + "\"";
                     else if (cellNGInfoCount >= 2)
                         jsonString += ToArrayString(cellInfo.Info);
                     else
                         jsonString += "[]"; 
                 }                                  
                 return jsonString;
             }                
         }
  
        public static string ToArrayString(List<string> array)
        {
            if (array.Count == 0)
                return "[]";
            else
            {
                string jsonString = "[";
                foreach (string item in array)
                    jsonString += "\"" + item.ToString() + "\",";
                jsonString = jsonString.Substring(0, jsonString.Length - 1);
                return jsonString + "]";
            }        
        }
     }
}
