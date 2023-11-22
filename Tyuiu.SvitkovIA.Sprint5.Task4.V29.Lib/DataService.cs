using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SvitkovIA.Sprint5.Task4.V29.Lib
{
    public class DataService : ISprint5Task4V29
    {
        public double LoadFromDataFile(string path)
        {
            string x = File.ReadAllText(path);
            return Math.Round(Convert.ToDouble(File.ReadAllText(path).Replace('.', ',')) / (2 * (Convert.ToDouble(File.ReadAllText(path).Replace('.', ',')))) + Math.Sin(Convert.ToDouble(File.ReadAllText(path).Replace('.', ','))) + Math.Pow(Convert.ToDouble(File.ReadAllText(path).Replace('.', ',')), 2), 3);
            
        }
    }
}
