using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SvitkovIA.Sprint5.Task3.V11.Lib;

namespace Tyuiu.SvitkovIA.Sprint5.Task3.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;

            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Свитков И. А. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл.                    *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант 11                                                              *");
            Console.WriteLine("* Выполнил: Свитков Иван Андреевич | АСОиУб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение приx = 3,результать сохранить в   *");
            Console.WriteLine("* бинарный файлOutPutFileTask3.bin и вывести на консоль.Округлитьдо3знаков*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("x = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
