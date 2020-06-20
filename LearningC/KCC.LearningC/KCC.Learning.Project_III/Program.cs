using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KCC.Learning.Project_III
{
    class Program
    {
        static void Main(string[] args)
        {
            //การประกาศ array ว่างๆ จำนวน 5 ช่อง
            int[] intarry = new int[5];
            string[] stringarry = new string[5];

            //การประกาศ array พร้อมระบุสมาชิก
            int[] populatearray = new int[] {0,1,2,3,4,5 };


            //การกำหนดค่าให้ array
            intarry[0] = 5;
            intarry[1] = 15;

            //อ่านค่า array เก็บในตัวแปร
            int firstvalue = intarry[0];

            //การประกาศ array 2 มิติ ว่างๆ
            int[,] arry2d = new int[2, 3];   //array 2 แถว 3 คอลัมน์

            //การประกาศ array 2  มิติ พร้อมระบุสมาชิก
            int[,] poparray2d = { { 1, 2, 3 }, { 4, 5, 6 } };

            //การอ่านค่า array
            int firstarray2d = poparray2d[0,0];
            int secoundarray2d = poparray2d[1, 2];
        }
    }
}
