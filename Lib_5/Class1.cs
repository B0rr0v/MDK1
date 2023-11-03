using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_5
{
    public class Class1
    {
        public static void разработка(int k, out String outputtb1, out int count1, out int sum1)
        {
            int count = 0;//счетчик числ
            String outputtb = "";// числа в tb
            int number = 0;
            Random rnd = new Random();
            int sum = 0;
            while (sum < k)
            {
                number = rnd.Next(-4, 7);
                sum += number;
               
                outputtb = String.Concat(outputtb, Convert.ToString(number));//объединяем строки в одну
                outputtb = String.Concat(outputtb, ",");// запятая между числами
                count++;
            }
            outputtb = outputtb.Substring(0, outputtb.Length - 1);//удаляем посл элемент(запятую)
            outputtb1 = outputtb;
            count1 = count;
            sum1 = sum - number;
        }
    }
}
