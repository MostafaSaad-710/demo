using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal struct Employee
    {
        private int id;
        private string name;
        private double salary;

        // Apply Encapsulation User Setter Getter Method

        #region Encapsulation
        //// setter
        //public void SetId(int Id)
        //{
        //    this.Id = Id;
        //}
        //// Getter 
        //public int GetId()
        //{
        //    return Id;
        //}

        //// setter
        //public void SetName(string Name)
        //{
        //    this.Name = Name;
        //}
        //// Getter 
        //public string GetName()
        //{
        //    return Name;
        //}

        //// setter
        //public void SetSalary(double Salary)
        //{
        //    if (Salary > 0)
        //        this.Salary = Salary;
        //}
        //// Getter 
        //public double GetSalary()
        //{
        //    return Salary;
        //}

        //public Employee(int id, string name, double salary)
        //{
        //    SetId(id);
        //    SetName(name);
        //    SetSalary(salary);
        //}

        //public override string ToString()
        //{
        //    return $"Id: {Id} :: Name : {Name} :: Salary {Salary}";
        //    ;
        //}


        #endregion

        // Apply Encapsulation Properties
        // 1. full Properties
        // 2. Automatic Properties
        // 3. Special Properties

        // 1. full Properties
        //-------------------

        public int Id
        {
            //Set
            set
            {
                id = value;
            }

            //Get
            get
            {
                return id;
            }
        }

        public string Name
        {
            set
            {
                name = value;
            }

            get
            {
                return name;
            }
        }

        public double Salary
        {
            set
            {
                if (salary > 0)
                   salary = value;
            }
            get { return salary;  }
        }

        // 2. Automatic Properties

        public string address { set; get; }

        // 3. Indexer : Special Properties




    }
}
