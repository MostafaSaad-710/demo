namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region struct
            // Struct : Value Type : Stack

            // point 

            //Point P01;

            // Declare for objecr from type 'point' **Note : dec object not ref assighn to object.
            // P01 : object
            // Allocate UnInitialized 8 Bytes at Stack

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y); // Error : no value
            // if class replacement struct< Error : is not null here  

            //P01.X = 12;
            //P01.Y = 12;
            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);


            //P01 = new Point();
            // new : Used For Select the Constructot onlyyyyyy

            //Console.WriteLine(P01.X); // 0 default
            //Console.WriteLine(P01.Y); // 0 default



            //P01 = new Point(1 , 2);
            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            //Console.WriteLine(P01); //demo.Point (namespace) 
            //                        //if class (Address)

            //P01.printPoint();

            //Console.WriteLine(P01.ToString()); 
            #endregion

            #region OOP OverView

            // OOP : Object Oriented Programming  
            // Programming Paradigm  
            // OOP : The Paradigm Use For Build Any Business  

            // Class : Blueprint Of The Object  
            // Object : Specific Instance From Class  

            // 4 Pillars  
            // =================  
            // 1. Encapsulation  
            // 2. Inheritance  
            // 3. Ploymorphism  
            // 4. Abstraction

            #endregion

            #region Encapsulation
            // 1. Encapsulation :
            // Class Or Struct
            // Seperate The Data (Attributes) defination from its Use
            // [Setter Getter Method - Properties]


            #region Setter Getter Method

            //Employee
            //Id //Name //Salary

            // 1. End User Access data itself
            // 2. No data validation
            // 3. no Read only Filed : no give attribute Setter , only Getter

            // // Apply Encapsulation User Setter Getter Method
            // 1. Make All Data(Attributes) Private  
            // 2. Access Data Through :  
            // 2.1. Setter Getter Method  
            // 2.2. Properties


            //Employee E01 = new Employee();
            //E01.Id = 1;
            //E01.Name = "Ahmed";
            //E01.Salary = 3000;

            //Console.WriteLine(E01.Id);
            //Console.WriteLine(E01.Name);
            //Console.WriteLine(E01.Salary);


            // After Encapsulation

            //Employee E01 = new Employee();
            //E01.SetId(1);
            //E01.SetName("Ahmed");
            //E01.SetSalary(-40000);

            //Console.WriteLine(E01.GetId());
            //Console.WriteLine(E01.GetName());
            //Console.WriteLine(E01.GetSalary());


            // After Costractor

            //Employee E01 = new Employee(1 , "Ahmed" , 1200 );

            //Console.WriteLine(E01.GetId());
            //Console.WriteLine(E01.GetName());
            //Console.WriteLine(E01.GetSalary());


            // After Costractor and override

            //Employee E01 = new Employee(1 , "Ahmed" , 1300 );
            //Console.WriteLine(E01); 
            #endregion

            #region Properties

            // Apply Encapsulation User Properties 


            //Employee E01 = new Employee();

            //// full Properties

            //E01.Id = 1;
            //E01.Name = "Ahmed";
            //E01.Salary = -1300;

            //Console.WriteLine(E01.Id);
            //Console.WriteLine(E01.Name);
            //Console.WriteLine(E01.Salary);

            ////Automatic Properties

            //E01.address = "cairo";
            //Console.WriteLine(E01.address);

            // 3. Indexer : Special Properties

            //PhoneBoook PhoneBoook = new PhoneBoook(3);

            //PhoneBoook.addPerson("Ahmed", 111, 0);
            //PhoneBoook.addPerson("Ali", 222, 1);
            //PhoneBoook.addPerson("Ahmed", 333, 2);


            //Console.WriteLine(PhoneBoook.GetNumber("Ahmed"));

            //PhoneBoook.UpdateNumber(999 , "Ahmed"  );

            //Console.WriteLine(PhoneBoook.GetNumber("Ahmed"));



            // Used Indexer: Special Properties

            //Console.WriteLine(PhoneBoook["Ahmed"]);

            //PhoneBoook["Ahmed"] = 666;

            //Console.WriteLine(PhoneBoook["Ahmed"]);


            #endregion

            #endregion

            #region Class

            // Class : Reference Types : HEAP  
            // Car : Id Model Speed
            // //
            //Car C01;

            // Decalre For Reference (Pointer) From Type 'Car'  
            // C01 : Can Refer To Object From Type 'Car' Or Any Class Inherited From It  
            // C01 : Refer To Null
            // 8 Bytes Will Be Allocated At STACK For The Reference 'C01'
            // 0 Bytes Will Be Allocated At HEAP

            // C01 = new Car(); // Error After constractor
            // new
            // 1. Allocate The Number Of Required Bytes At HEAP For The Object
            // 2. Initialized The Allocated Bytes With The Default Value Of Datatype
            // 3. Call User-Defined Constructor if Exists
            // 4. Assign The Object To The Reference

            //C01 = new Car(1 , 2 , "mm");

            //Console.WriteLine(C01.Id);
            //Console.WriteLine(C01.Model);
            //Console.WriteLine(C01.Speed);

            //Console.WriteLine(C01);

            #endregion


        }
    }
}
