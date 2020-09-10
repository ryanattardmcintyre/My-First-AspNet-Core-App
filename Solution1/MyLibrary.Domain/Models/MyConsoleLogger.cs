using MyLibrary.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Domain.Models
{
    public class MyConsoleLogger : ILog
    {
        public void Info(string str)
        {
            Console.WriteLine(str);
        }
    }
}
