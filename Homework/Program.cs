using System;
using System.IO;
using System.Linq;

namespace Homework
{
    internal class Program
    {
        static void Main()
        {
            string path = @"C:\Users\home\Desktop\homework.txt";
            using (StreamWriter stream = new StreamWriter(path, true))
            {
                stream.WriteLine("Максимальная оценка: 5");
                stream.WriteLine("Минимальная оценка: 1");
                stream.WriteLine("Средняя оценка: 3,4");
                

            }
            using (StreamReader streamReader = File.OpenText(path))
            {
               string allFile =  streamReader.ReadToEnd();
                string[] file = allFile.Split(';');
         
                string[] numbers = { file[3], file[7], file[15], file[19], file[23], file[27], file[31], file[35], file[39]};
                int[] answer = new int[numbers.Length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    answer[i] = int.Parse(numbers[i]);
                }
                int maxScore = answer.Max();
                int minScore = answer.Min();
                double avgScore = (double)answer.Sum() / answer.Length;
                avgScore = Math.Round(avgScore, 1);
                Console.WriteLine(maxScore);
                Console.WriteLine(minScore);
                Console.WriteLine(avgScore);
            }
            
        }
    }
}