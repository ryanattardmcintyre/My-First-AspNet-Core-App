using MyLibrary.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace MyLibrary.Domain.Models
{
    public class MyTextFileLogger : ILog
    {
        public void Info(string str)
        {


            if (File.Exists(@"Mylibrary.Log") == false)
            {
                File.CreateText(@"Mylibrary.Log");
               
            }
            File.AppendAllText(@"Mylibrary.Log", str);
        }
    }
}
