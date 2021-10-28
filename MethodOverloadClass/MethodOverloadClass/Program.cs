using System;

namespace MethodOverloadClass
{
    class Program
    {
        public int a;
        static string Pattern(int number)
        {
            string str = "";
            string str1 = "";

            for (int i = 0; i <= (number - 1) / 2; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    str += "*";
                }
                str += "\n";
                for (int j = i; j <= (number - 1) / 2; j++)
                {
                    str1 += "*";
                }
                str1 += "\n";
            }
            return str + str1;
        }
        static void Main(string[] args)
        {
            #region Tasks
            //Console.Write("Number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //string res = Pattern(number);
            //Console.WriteLine(res);

            //Console.WriteLine("ededi daxil edin: ");


            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("sirani daxil edin: ");

            //int n = Convert.ToInt32(Console.ReadLine());

            //say(a, n);


            //Console.WriteLine("String daxil edin : ");
            //string str = Console.ReadLine();
            //Console.WriteLine(SpaceCounter(str));
            #endregion

            //int result = add(15, 10);
            //Console.WriteLine(result);

            //float result2 = add(15.5F, 10);
            //Console.WriteLine(result2);

            //decimal result3 = add(15, 10,15.5M);
            //Console.WriteLine(result3);

            //var Rasim = new
            //{
            //    name = "Rasim",
            //    surname = "Abbasov",
            //    age = 20,
            //    totalScore = 550,
            //    idMarried = false
            //};

            //Console.WriteLine($"{Rasim.name} {Rasim.surname} - {Rasim.totalScore}");

            //int a = 15;
            //int b = 40;
            //int c = 38476;

            //Student stu1 = new Student("Rasim");
            //stu1.surname = "Abbasov";
            //stu1.age = 20;
            //stu1.score = 550;
            //stu1.isMarried = false;
            //stu1.Fullinfo();

            //Student stu2 = new Student("Qasim", "Quliyev")
            //{
            //    age = 19,
            //    score = 350,
            //    isMarried = true
            //};
            //stu2.Fullinfo();
            //Console.WriteLine($"The marriege status of {stu2.name} is {stu2.GetMarriegeStatus()}");

            //Console.WriteLine($"{stu1.name} - {stu1.score}");
            //Calculator calculator1 = new Calculator();

            //Student stu3 = new Student();
            //stu3.name = "Seymur";
            //stu3.surname = "Abbasov";
            //stu3.age = 21;
            //stu3.isMarried = false;
            //stu3.score = 314;

            //stu3.Fullinfo();
            //Console.WriteLine(stu3.GetMarriegeStatus());

            //Teacher teacher = new Teacher("skjdv","skhdb");
            //teacher.
        }
        static int SpaceCounter(string str)
        {
            int space = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    space++;
                }
            }
            return space;
        }
        static void say(int a, int n)
        {
            int sum = 0;
            int a2 = a;
            for (int i = 0; i < n; i++)
            {
                sum += a;

                a = a * 10 + a2;

            }
            Console.WriteLine($"netice: {sum}");

        }
        static int add(int a, int b)
        {
            return a + b;
        }
        static float add(float a, int b)
        {
            return a + b;
        }
        static decimal add(int a, int b, decimal c)
        {
            return a + b + c;
        }
    }

    class Student : Person
    {
        //public Student(string name)
        //{
        //    this.name = name;
        //}
        //public Student(string name, string surname)
        //{
        //    this.name = name;
        //    this.surname = surname;
        //}

        //public string name;
        //public string surname;
        //public byte age;
        //public bool isMarried;
        public short score;

        public Student(string name, string jdbvh) : base(name, jdbvh)
        {

        }

        public void Fullinfo()
        {
            Console.WriteLine($"{name} {surname} is {age} and get the total score of {score}");
        }
        //public bool GetMarriegeStatus()
        //{
        //    return isMarried;
        //}
    }

    class Teacher : Person
    {
        //public string name;
        //public string surname;
        //public byte age;
        //public bool isMarried;
        public Teacher(string name, string jdbvh) : base(name, jdbvh)
        {

        }

        public byte groupCount;

        public void Fullname()
        {
            Console.WriteLine($"{this.name} {surname}");
        }
        //public bool GetMarriegeStatus()
        //{
        //    return isMarried;
        //}
    }

    class Person : Test
    {
        public string name;
        public Person(string name, string b) : base(b)
        {
            this.name = name;
        }
        public string surname;
        public byte age;
        public bool isMarried;

        public bool GetMarriegeStatus()
        {
            return this.isMarried;
        }
    }

    class Test
    {
        public string b;
        public Test(string b)
        {
            this.b = b;
        }

        public int a;
    }
}
