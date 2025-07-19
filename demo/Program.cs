namespace demo
{
    namespace Assignment01
    {
        //Q01
        internal struct Point
        {
            public double X;
            public double Y;
        }

        //Q02
        internal struct Person
        {
            public string Name;
            public int Age;
        }

        // PART02


        #region Q01
        enum Security
        {
            Guest,
            Developer,
            Secretary,
            DBA
        }

        internal class HireDate
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }

            public HireDate(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }

            public override string ToString()
            {
                return $"{Day:D2}/{Month:D2}/{Year}";
            }
        }

        class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }

            private char gender;
            public char Gender
            {
                get { return gender; }
                set
                {
                    if (value == 'M' || value == 'F')
                        gender = value;
                    else
                        throw new ArgumentException("Gender must be 'M' or 'F'");
                }
            }

            public double Salary { get; set; }
            public HireDate HireDate { get; set; }
            public Security SecurityLevel { get; set; }

            public Employee(int id, string name, char gender, double salary, HireDate hireDate, Security securityLevel)
            {
                ID = id;
                Name = name;
                Gender = gender;
                Salary = salary;
                HireDate = hireDate;
                SecurityLevel = securityLevel;
            }

            public override string ToString()
            {
                return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Salary: {Salary:C}, Hire Date: {HireDate}, Security Level: {SecurityLevel}";
            }


        }

        #endregion

        #region Q02
        internal class HireDate02
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }

            public HireDate02(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }

            public override string ToString()
            {
                return $"{Day:D2}/{Month:D2}/{Year}";
            }
        }

        #endregion


        internal class Program
        {
            static void Main(string[] args)
            {

                #region PART 01
                #region Q01
                //Console.WriteLine("Enter X for point 1:");
                //double x1 = double.Parse(Console.ReadLine());

                //Console.WriteLine("Enter Y for point 1:");
                //double y1 = double.Parse(Console.ReadLine());

                //Console.WriteLine("Enter X for point 2:");
                //double x2 = double.Parse(Console.ReadLine());

                //Console.WriteLine("Enter Y for point 2:");
                //double y2 = double.Parse(Console.ReadLine());

                //Point P01 = new Point();
                //Point P02 = new Point();

                //P01.X = x1; P01.Y = y1;
                //P02.X = x2; P02.Y = y2;

                //double distance = Math.Sqrt(Math.Pow(P02.X - P01.X, 2) + Math.Pow(P02.Y - P01.Y, 2));
                //Console.WriteLine(distance); 
                #endregion

                #region Q02

                //Person P1 = new Person();
                //Person P2 = new Person();
                //Person P3 = new Person();


                //Console.WriteLine("Enter the name of person 1:");
                //P1.Name = Console.ReadLine();

                //Console.WriteLine("Enter the age of person 1:");
                //P1.Age = int.Parse(Console.ReadLine());

                //Console.WriteLine("Enter the name of person 2:");
                //P2.Name = Console.ReadLine();

                //Console.WriteLine("Enter the age of person 2:");
                //P2.Age = int.Parse(Console.ReadLine());

                //Console.WriteLine("Enter the name of person 3:");
                //P3.Name = Console.ReadLine();

                //Console.WriteLine("Enter the age of person 3:");
                //P3.Age = int.Parse(Console.ReadLine());

                //Person Oldest = P1;

                //if (P2.Age > Oldest.Age)
                //    Oldest = P2;
                //if (P3.Age > Oldest.Age)
                //    Oldest = P3;

                //Console.WriteLine("The oldest person is: " + Oldest.Name + ", Age: " + Oldest.Age);



                #endregion
                #endregion

                #region PART 02
                #region Q01

                //Employee[] EmpArr = new Employee[3];

                //EmpArr[0] = new Employee(1, "Ali", 'M', 10000, new HireDate(1, 1, 2022), Security.DBA);
                //EmpArr[1] = new Employee(2, "Sara", 'F', 5000, new HireDate(15, 6, 2023), Security.Guest);
                //EmpArr[2] = new Employee(3, "Mostafa", 'M', 15000, new HireDate(10, 3, 2021), Security.Developer);  

                //foreach (var emp in EmpArr)
                //{
                //    Console.WriteLine(emp);
                //}
                #endregion

                #region Q02
                //
                //HireDate02 d = new HireDate02(19, 7, 2025);
                //Console.WriteLine(d);
                #endregion

                #endregion
            }
        }
    }