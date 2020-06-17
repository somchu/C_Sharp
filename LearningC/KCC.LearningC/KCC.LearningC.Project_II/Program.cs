using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KCC.LearningC.Project_II
{
    //User Define Type ใช้ Class หรือ Struct ในการสร้าง
    class Program
    {
        static void MultiplyLegs(PetStruct petStruct, PetClass petClass) {
            petStruct.Legs = petStruct.Legs * 2;
            petClass.Legs = petClass.Legs * 2;
            Console.WriteLine("Internal Method - A petStruct " + petStruct + " has " + petStruct.Legs+ " Legs");
            Console.WriteLine("Internal Method - A petClass " + petClass + " has " + petClass.Legs + " Legs");
        }
        static void Main(string[] args)
        {
            //ประกาศแล้วใช้งานได้เลย
           // PetStruct dog;
            //ยกเว้นต้องมีการส่งค่าไปให้ method อื่นใช้งานต้อง New เหมือนกัน
            PetStruct dog = new PetStruct();
            dog.Type = PetType.Dog;
            dog.HasFur = true;
            dog.Legs = 4;

            //ต้อง New ก่อนใช้งาน
            PetClass duck;
            duck = new PetClass();
            duck.Type = PetType.Duck;
            duck.HasFur = false;
            duck.Legs = 2;

            Console.WriteLine("before use method a " + dog.Type + " has " + dog.Legs + " Legs");
            Console.WriteLine("before use method a " + duck.Type + " has " + duck.Legs + " Legs");

            //ส่งค่าให้ Method อื่นทำงาน
            MultiplyLegs(dog, duck);

            Console.WriteLine("after use method a " + dog.Type + " has " + dog.Legs + " Legs");
            Console.WriteLine("after use method a " + duck.Type + " has " + duck.Legs + " Legs");
            Console.ReadLine();
            //--------------------------------------------------------------------------------------------------------------
            //สรุปเรื่อง datatype และ referenct type
            //การทำงานของ struct จะเป็นเบบ value type คือ ค่าที่อยู่ภายใน method จะเปลี่ยนตามการกระทำภายใน method เมื่อออกนอก method ค่าจะเปลี่ยนกลับเป็นเหมือนเดิม เนิ่องจากการทำงานจะเป็นการ copy ค่ามาไว้อีกตัวหนี่งต่างหากแยกจากค่าที่ส่งเข้ามา
            //เมื่อมีการแก้ไขค่า จึงเป็นการแก้ไขที่ตัวที่ copy แต่ตัวที่ต้นฉบับยังเหมือนเดิม
            //การทำงานของ class จะเป็นแบบ reference type คือ ถ้ามีการเปลี่ยนแปลงค่าใน method ค่าที่เก็บใน class จะเปลี่ยนด้วยเนื่องจากเป็นการอ้างอิงตำแหน่งที่อยู่ของตัวแปร เนื่องจาก class จะเป็นการเก็บค่าข้อมูลในลักษณะการอ้างอิงถึงที่อยู่ข้อมูล
            //เมื่อมีการแก้ไขค่าใน method เท่ากับเป็นการแก้ไขค่าที่ตัวแปร class อ้างอิงถึง ดังนั้นเมื่อหลักจาก method ทำงานแล้วค่าของตัวแปรจึงมีการเปลียนไป 
            //------------------------------------------------------------------------------------------------------------
    }

        
    }
    //ประกาศนอก class main
    class PetClass {
        public int Legs;
        public PetType Type;
        public string Name;
        public bool HasFur;
    }

    struct PetStruct {
        public int Legs;
        public PetType Type;
        public string Name;
        public bool HasFur;
    }

    //ประกาศชนิดของตัวแปร ให้เป็น enum เพื่อให้ user สามารถระบุได้แค่เท่าที่เรากำหนด
    //ในทีนี้กำหนดไว้ 2 แบบ คือ Dog กับ Duck
    enum PetType { 
        Dog,Duck
    }
}
