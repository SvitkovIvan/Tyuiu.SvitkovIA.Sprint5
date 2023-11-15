using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SvitkovIA.Sprint5.Task0.V28.Lib
{
    public class DataService : ISprint5Task0V28
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";

            double res = x * Math.Sqrt(x + 3);

            res = Math.Round(res, 3);

            File.WriteAllText(path, Convert.ToString(res));

            return path;
        }
    }
}
