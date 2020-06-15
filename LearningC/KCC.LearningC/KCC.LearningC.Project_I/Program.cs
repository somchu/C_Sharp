using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KCC.LearningC.Project_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int answer = 0;

            Console.WriteLine("Hello World!!!");
            Console.ReadLine();

            Console.Write("Enter a number: ");
            string sNum1 = Console.ReadLine();

            Console.Write("Enter another number: ");
            string sNum2 = Console.ReadLine();

            //TryParse สำหรับ check ค่า ตัวแปร ถ้าภูกต้องจะไปลงในตัวแปร
            Int32.TryParse(sNum1, out num1);
            Int32.TryParse(sNum2, out num2);

            answer = num1 + num2;
            Console.WriteLine(answer);
            
            Console.ReadLine();
          
        }
    }
}
