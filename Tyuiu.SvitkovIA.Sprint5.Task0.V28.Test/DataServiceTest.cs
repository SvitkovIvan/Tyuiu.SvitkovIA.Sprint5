using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SvitkovIA.Sprint5.Task0.V28.Lib;

namespace Tyuiu.SvitkovIA.Sprint5.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Ванюшка\Desktop\repos\Tyuiu.SvitkovIA.Sprint5.Task0.V28\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
