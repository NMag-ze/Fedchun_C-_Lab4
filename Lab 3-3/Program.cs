using System;

namespace Lab_3_3
{

    class Student
    {
        private Random rnd = new Random();
        private string name { get; set; }
        private int sumb { get; set; }
              
        public void SetValue(string n)
        {
            name = n;
            sumb = rnd.Next(0,300);
        }
        public override string ToString()
        {
            return $"Фамилия студента:\n{name}\nОбщее кол-во баллов:{sumb}\n";
        }
        public static Student[] InitAr(Student[] Stud)
        {
            for (int i=0;i<Stud.Length;i++)
            {
                Stud[i] = new Student();
            }
            return Stud;
        }
        ~Student()
        { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] stud = new Student[3];
            Student.InitAr(stud);
            stud[0].SetValue("Мещеряков");
            stud[1].SetValue("Сменкина");
            stud[2].SetValue("Черных");
            for (int i = 0; i < stud.Length; i++)
            {
                Console.WriteLine(stud[i].ToString());
            }
        }
    }
}
