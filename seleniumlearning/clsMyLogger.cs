﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Selenium_Demo
{
   
        public class clsMyLogger
        {
            string path = @"C:\Logs\Mylogs.txt";

            public static bool logsEnabled = true;
            //public bool logsEnabled = false;
            public void LogMessage(string logMsg)
            {
                StreamWriter sw;
                if (!File.Exists(path))
                {
                    sw = File.CreateText(path);
                }
                else
                {
                    sw = File.AppendText(path);
                }

                if (logsEnabled)
                {
                    LogWrite(logMsg, sw);

                }

                sw.Flush();
                sw.Close();
            }
            private static void LogWrite(string logMessage, StreamWriter w)
            {

                if (logsEnabled == true)
                {
                    w.WriteLine("{0}", DateTime.Now + ":" + logMessage);
                    w.WriteLine("----------------------------------------");
                }

            }

        }
    }
