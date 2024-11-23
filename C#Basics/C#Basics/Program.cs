using System;
namespace C_Sharp_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# coding\n");
            //DataTypes();
            //Variables();
            //Operators();
            //Arrays();
            //Strings();
            //TypeCasting();
            //ControlStatements();
            //ClassAndObjects();
            //methodes();
            //Constructors();
            //AccessModifiers();
            //Inheritance();
            //Polymorphism();
        }
        public static void DataTypes()
        {
            //integer data type
            int a = 10;
            Console.Write("a : " + a);
            Console.WriteLine("\t a is " + a.GetType().Name);
            //float data type
            float b = 10.56f;
            Console.Write("b : " + b);
            Console.WriteLine("\t b is " + b.GetType());
            //boolean data type
            bool c = true;
            Console.Write("c : " + c);
            Console.WriteLine("\t c is " + c.GetType().Name);
            //character data type
            char d = 'A';
            Console.Write("d : " + d);
            Console.WriteLine("\t d is " + d.GetType().Name);
            //string data type
            string e = "vicky";
            Console.Write("e : " + e);
            Console.WriteLine("\t e is " + e.GetType());
        }
        static void Variables()
        {
            /* Declaration of variable
             * Initialization of variable
             * Run time and compile time initialization
             */
            int age1 = 18;
            Console.Write("Age1 is {0}\t", age1);
            Console.WriteLine("This is Compile Time Initialization");
            Console.Write("Enter value for age2 : ");
            int age2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Age2 is {0}\t", age2);
            Console.WriteLine("This is Run Time Initialization");
        }
        static void Operators()
        {
            //unary Increment Operator
            int a = 10;
            Console.WriteLine("Value of a is a : {0}", a);
            Console.WriteLine("Post Increment of a is a++ : {0}", a++);
            Console.WriteLine("After this a value will be a : {0}", a);
            int b = 10;
            Console.WriteLine("Value of b is b : {0}", b);
            Console.WriteLine("Pre Increment of b is ++b : {0}", ++b);
            Console.WriteLine("After this b value will be b : {0}", b);
            //unary Decrement Operator
            int c = 10;
            Console.WriteLine("Value of c is c : {0}", c);
            Console.WriteLine("Post Decrement of c is c-- : {0}", c--);
            Console.WriteLine("After this c value will be c : {0}", c);
            int d = 10;
            Console.WriteLine("Value of d is d : {0}", d);
            Console.WriteLine("Pre Decrement of b is --d : {0}", --d);
            Console.WriteLine("After this d value will be d : {0}", d);
            //Binary Arithmetic Operators
            int a1 = 10, a2 = 20;
            Console.WriteLine("value of a1 is {0} and a2 is {1}", a1, a2);
            Console.WriteLine("Arithmetic Operations Between a1 and a2");
            Console.WriteLine("a1 + a2 : {0}", a1 + a2);
            Console.WriteLine("a1 - a2 : {0}", a1 - a2);
            Console.WriteLine("a1 * a2 : {0}", a1 * a2);
            Console.WriteLine("a1 / a2 : {0}", a1 / a2);
            Console.WriteLine("a1 % a2 : {0}", a1 % a2);
            //Binary Relational Operators
            int b1 = 10, b2 = 20;
            Console.WriteLine("value of b1 is {0} and b2 is {1}", b1, b2);
            Console.WriteLine("Relational Operations Between b1 and b2");
            Console.WriteLine("a1 < a2 : {0}", a1 < a2);
            Console.WriteLine("a1 <= a2 : {0}", a1 <= a2);
            Console.WriteLine("a1 > a2 : {0}", a1 > a2);
            Console.WriteLine("a1 >= a2 : {0}", a1 >= a2);
            Console.WriteLine("a1 == a2 : {0}", a1 == a2);
            Console.WriteLine("a1 != a2 : {0}", a1 != a2);
            //Binary Logical Operators
            bool c1 = true, c2 = false;
            Console.WriteLine("value of conditions c1 is {0} and c2 is {1}", c1, c2);
            Console.WriteLine("Logical Operations Between conditions c1 and c2");
            Console.WriteLine("c1 && c2 : {0}", c1 && c2);
            Console.WriteLine("c1 || c2 : {0}", c1 || c2);
            Console.WriteLine(" !c1 : {0}", !c1);
            Console.WriteLine(" !c2 : {0}", !c2);
            //Binary BitWise Operators
            int d1 = 5; // Binary: 0101
            int d2 = 3; // Binary: 0011
            Console.WriteLine("value of d1 is {0} and d2 is {1}", d1, d2);
            Console.WriteLine("BitWise Operations Between conditions d1 and d2");
            Console.WriteLine("d1 & d2 = " + (d1 & d2)); // AND 
            Console.WriteLine("d1 | d2 = " + (d1 | d2)); // OR
            Console.WriteLine("d1 ^ d2 = " + (d1 ^ d2)); // XOR
            Console.WriteLine("~d1 = " + (~d1));       // NOT
            Console.WriteLine("d1 << 1 = " + (d1 << 1)); // Left Shift
            Console.WriteLine("d1 >> 1 = " + (d1 >> 1)); // Right Shift
            //Binary Assignment Operators
            int e1 = 5, e2 = 10;
            Console.WriteLine("value of e1 is {0} and e2 is {1}", e1, e2);
            Console.WriteLine("Assignment Operations Between e1 and e2");
            Console.WriteLine("e1 = e2 : Value of e1 : {0}", e1 = e2);
            Console.WriteLine("e1 += e2 : Value of e1 : {0}", e1 += e2);
            Console.WriteLine("e1 -= e2 : Value of e1 : {0}", e1 -= e2);
            Console.WriteLine("e1 *= e2 : Value of e1 : {0}", e1 *= e2);
            Console.WriteLine("e1 /= e2 : Value of e1 : {0}", e1 /= e2);
            Console.WriteLine("e1 %= e2 : Value of e1 : {0}", e1 %= e2);
            //Trinary Operator
            int age1 = 18, age2 = 24;
            Console.WriteLine("Using Trinary operator ");
            Console.WriteLine("age1 is {0} and age2 is {1}", age1, age2);
            Console.WriteLine("What is height age {0}", age1 > age2 ? age1 : age2);
        }
        static void Arrays()
        {
            // initialization of array
            //Example 1:
            // defining array with size 5. But not assigns values
            int[] array1 = new int[5];
            //array1=new int[] {1,2,3,4,5};

            //Example 2:
            // defining array with size 5 and assigning values at the same time
            int[] array2 = new int[5] { 1, 3, 5, 7, 9 };

            //Example 3:
            // defining array with 5 elements which indicates the size of an array
            // we can increse the size of array
            int[] array3 = { 2, 4, 6, 8, 10 };

            //1-D array
            //Adding elements through Run time
            Console.WriteLine("Enter {0} Elements :", array1.Length);
            for (int i = 0; i < array1.Length; i++)
                array1[i] = Convert.ToInt32(Console.ReadLine());
            //Display 1-D array
            Console.Write("Elements in array1 : ");
            foreach (int e in array1)
                Console.Write("{0} ", e);
            Console.WriteLine();

            //2-D array
            int[,] array1_2D = new int[4, 3] { { 1, 2, 3 },
                                              { 4, 5, 6 },
                                              { 7, 8, 9 },
                                              { 10, 11, 12 }
                                            };
            Console.Write("Elements in array1_2D are : ");
            for (int i = 0; i < array1_2D.GetLength(0); i++)
                for (int j = 0; j < array1_2D.GetLength(1); j++)
                    Console.Write("{0} ", array1_2D[i, j]);
            Console.WriteLine();

            //3-D arrar
            int[,,] array1_3D = new int[2, 4, 3] { { { 1, 2, 3 },
                                                     { 4, 5, 6 },
                                                     { 7, 8, 9 },
                                                     { 10, 11, 12 } },{ { 13, 14, 15 },
                                                                        { 16, 17, 18 },
                                                                        { 19, 20, 21 },
                                                                        { 22, 23, 24 } } };
            Console.Write("Elements in array1_3D are : ");
            for (int i = 0; i < array1_3D.GetLength(0); i++)
                for (int j = 0; j < array1_3D.GetLength(1); j++)
                    for (int k = 0; k < array1_3D.GetLength(2); k++)
                        Console.Write("{0} ", array1_3D[i, j, k]);
            Console.WriteLine();

            // Declare a jagged array with 3 rows
            int[][] jaggedArray = new int[3][];
            // Initialize each row with a different length
            jaggedArray[0] = new int[] { 1, 2, 3 };          // First row has 3 elements
            jaggedArray[1] = new int[] { 4, 5, 6, 7 };       // Second row has 4 elements
            jaggedArray[2] = new int[] { 8, 9 };             // Third row has 2 elements
            // Accessing and printing elements
            Console.WriteLine("Elements in jaggedArray are : ");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("Row-{0} : ", i);
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write("{0} ", jaggedArray[i][j]);
                }
                Console.WriteLine();
            }
        }
        static void Strings()
        {
            //string keyword
            string a = "Hi this is a string using string keyword";
            Console.WriteLine(a);
            //String Class
            String b = "Hello This is a string using string class ";
            Console.WriteLine(b);
            //string array
            //example - 1
            string[] str_array1 = new string[3] { "vicky", "prasad", "vivek" };
            //example - 2
            string[] str_array2 = new string[3];
            str_array2 = new string[] { "python", "c++", "java" };
            //example - 3
            string[] str_array3 = { "CSE", "EEE", "ECE", "MECH", "MMT", "CIVIL" };
            //String with + operator
            Console.WriteLine("\nOutput string using + operator");
            string firstName1 = "Visweswara rao";
            string lastName1 = "Parsiboina";
            string name1 = "My full name is: " + firstName1 + " " + lastName1;
            Console.WriteLine(name1);
            //String Concatenation
            Console.WriteLine("\nOutput string using concatenation operator");
            string firstName2 = "Visweswara rao";
            string lastName2 = "Parsiboina";
            string name2 = String.Concat("My full name is: ", firstName2, " ", lastName2);
            Console.WriteLine(name2);
            //String Interpolation
            Console.WriteLine("\nOutput string using String Interpolation");
            string firstName3 = "Visweswara rao";
            string lastName3 = "Parsiboina";
            string name3 = $"My full name is: {firstName3} {lastName3}";
            Console.WriteLine(name3);
            //String Formate
            Console.WriteLine("\nOutput string using String Formate");
            string firstName4 = "Visweswara rao";
            string lastName4 = "Parsiboina";
            string name4 = string.Format("My full name is: {0} {1}", firstName4, lastName4);
            Console.WriteLine(name4);
            //String User Input
            Console.Write("\nEnter the text : ");
            string name5 = Console.ReadLine();
            Console.WriteLine(name5);
        }
        static void TypeCasting()
        {
            //Implicit Casting (automatically) - converting a smaller type to a larger type size
            //char -> int -> long -> float -> double
            int myInt1 = 9;
            double myDouble1 = myInt1;      // Automatic casting: int to double
            Console.WriteLine("myInt1 : {0}", myInt1);
            Console.WriteLine("myDouble1 : {0}", myDouble1);

            //Explicit Casting(manually) - converting a larger type to a smaller size type
            //double -> float -> long -> int -> char
            double myDouble2 = 9.78;
            int myInt2 = (int)myDouble2;    // Manual casting: double to int
            Console.WriteLine("myDouble2 : {0}", myDouble2);
            Console.WriteLine("myInt2 : {0}", myInt2);

            //Type Conversion Methods
            int myInt3 = 10;
            double myDouble3 = 5.25;
            bool myBool3 = true;
            Console.WriteLine("convert int {0} to string {1}", myInt3, Convert.ToString(myInt3));
            Console.WriteLine("convert int {0} to double {1}", myInt3, Convert.ToDouble(myInt3));
            Console.WriteLine("convert double {0} to int {1}", myDouble3, Convert.ToInt32(myDouble3));
            Console.WriteLine("convert bool {0} to string {1}", myBool3, Convert.ToString(myBool3));
        }
        static void ControlStatements()
        {
            //simple If
            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }
            //If - else
            int number = 10;
            if (number > 5)
                Console.WriteLine("Number is greater than 5");
            else
                Console.WriteLine("Number is 5 or less");

            //if - else if ladder
            int marks = 85;
            if (marks >= 90)
                Console.WriteLine("Grade: A+");
            else if (marks >= 80)
                Console.WriteLine("Grade: A");
            else if (marks >= 70)
                Console.WriteLine("Grade: B");
            else
                Console.WriteLine("Grade: C");

            //nested - if
            int age = 20;
            if (age >= 18)
            {
                if (age >= 21)
                    Console.WriteLine("Eligible for a specific privilege");
                else
                    Console.WriteLine("Eligible for general privileges but not all");
            }

            //switch
            char grade = 'B';
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Good");
                    break;
                default:
                    Console.WriteLine("Try harder");
                    break;
            }

            //nested Switch
            string category = "Electronics";
            string item = "Phone";

            switch (category)
            {
                case "Electronics":
                    switch (item)
                    {
                        case "Phone":
                            Console.WriteLine("Selected: Phone");
                            break;
                        case "Laptop":
                            Console.WriteLine("Selected: Laptop");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Category not recognized");
                    break;
            }

            //while loop
            int count = 1;
            while (count <= 5)
            {
                Console.WriteLine("Count: " + count);
                count++;
            }

            //do while loop
            int number2 = 1;
            do
            {
                Console.WriteLine("Number: " + number2);
                number2++;
            } while (number2 <= 3);

            //for loop
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Value of i: " + i);
            }

            //nested for loop
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine("i: " + i + ", j: " + j);
                }
            }

            //infinite for
            for (; ; )
            {
                Console.WriteLine("This is an infinite loop");
                break; // Prevent actual infinite looping
            }

            //break 
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine("i: " + i);
            }

            //continue
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                    continue;
                Console.WriteLine("i: " + i);
            }

            //goto
            int value = 5;
            if (value == 5)
                goto Found;
            Console.WriteLine("Not Found");
        Found:
            Console.WriteLine("Found the value");

            //return
            int Add(int a, int b)
            {
                return a + b;
            }
            Console.WriteLine("Sum: " + Add(3, 5));

            //throw
            int divisor = 0;
            if (divisor == 0)
                throw new DivideByZeroException("Cannot divide by zero");

        }
        static void ClassAndObjects()
        {
            // Object Creation (Using Default Constructor)
            Person person1 = new Person();
            person1.Introduce();

            // Object Creation (Using Parameterized Constructor)
            Person person2 = new Person("Alice", 25);
            person2.Introduce();

            // Using Properties
            person1.Name = "John";
            person1.Age = 30;
            person1.Introduce();

            // Static Members
            Person.DisplayTotalPersons();

            // Method Overloading
            person2.Introduce("I love programming!");

            // Inheritance and Overriding
            Student student = new Student("Bob", 22, "Computer Science");
            student.Introduce();

            // Calling Base Class Method from Derived Object
            ((Person)student).Introduce();

            // Accessing Static Field
            Console.WriteLine("Final Total Persons Count: " + Person.TotalPersons);

        }
        static void methodes()
        {
            MethodExamples example = new MethodExamples();

            // Named Parameters
            example.NamedParameters(lastName: "Doe", firstName: "John");

            // Ref Parameters
            int refValue = 10;
            example.RefParameters(ref refValue);
            Console.WriteLine($"After RefParameters: {refValue}");

            // Out Parameters
            example.OutParameters(out int outValue);
            Console.WriteLine($"After OutParameters: {outValue}");

            // Default Parameters
            example.DefaultParameters();
            example.DefaultParameters(20);

            // Dynamic Parameters
            example.DynamicParameters(5);
            example.DynamicParameters("Hello, dynamic!");
            example.DynamicParameters(new { Name = "Object", Age = 25 });

            // Value Parameters
            int valueParam = 15;
            example.ValueParameters(valueParam);
            Console.WriteLine($"After ValueParameters: {valueParam}");

            // Params Parameters
            example.ParamsParameters(1, 2, 3, 4, 5);
            example.ParamsParameters(); // Calling without any arguments
        }
        static void Constructors()
        {
            // Default Constructor
            ConstructorExamples defaultObj = new ConstructorExamples();
            defaultObj.Display();

            // Parameterized Constructor
            ConstructorExamples paramObj = new ConstructorExamples("John", 25);
            paramObj.Display();

            // Copy Constructor
            ConstructorExamples copyObj = new ConstructorExamples(paramObj);
            copyObj.Display();

            // Using Private Constructor via a Factory Method
            ConstructorExamples privateObj = ConstructorExamples.CreateInstance("Private Instance");
            privateObj.Display();

            // Static Constructor automatically called before any instance creation
            Console.WriteLine("End of Main");
        }
        static void AccessModifiers()
        {
            BaseClass baseObj = new BaseClass();
            DerivedClass derivedObj = new DerivedClass();
            AnotherClass anotherObj = new AnotherClass();

            Console.WriteLine("Access from Main:");
            Console.WriteLine(baseObj.PublicProperty);
            // Console.WriteLine(baseObj.PrivateProperty); // Not accessible
            // Console.WriteLine(baseObj.ProtectedProperty); // Not accessible
            Console.WriteLine(baseObj.InternalProperty); // Accessible (same assembly)
            Console.WriteLine(baseObj.ProtectedInternalProperty); // Accessible
            // Console.WriteLine(baseObj.PrivateProtectedProperty); // Not accessible

            Console.WriteLine();

            baseObj.ShowAccessInBaseClass();
            Console.WriteLine();

            derivedObj.ShowAccessInDerivedClass();
            Console.WriteLine();

            anotherObj.ShowAccessInAnotherClass();
        }
        static void Inheritance() 
        {
            Console.WriteLine("Single Inheritance:");
            Dog dog = new Dog();
            dog.Eat(); // From Animal
            dog.Bark(); // From Dog

            Console.WriteLine("\nMultilevel Inheritance:");
            Puppy puppy = new Puppy();
            puppy.Eat(); // From Animal
            puppy.Bark(); // From Dog
            puppy.Weep(); // From Puppy

            Console.WriteLine("\nHierarchical Inheritance:");
            Cat cat = new Cat();
            cat.Eat(); // From Animal
            cat.Meow(); // From Cat

            Console.WriteLine("\nMultiple Inheritance (via Interfaces):");
            Horse horse = new Horse();
            horse.Walk(); // From IWalkable
            horse.Run(); // From IRunable

            Console.WriteLine("\nHybrid Inheritance:");
            HybridExample hybridDog = new HybridExample();
            hybridDog.Eat(); // From Animal (via Dog)
            hybridDog.Bark(); // From Dog
            hybridDog.Walk(); // From IWalkable
        }
        static void Polymorphism()
        {
            // 1. Method Overloading
            Console.WriteLine("Method Overloading Example:");
            Calculator calc = new Calculator(0);

            // Calling Add method with different parameter combinations
            Console.WriteLine($"Add(2, 3): {calc.Add(2, 3)}");
            Console.WriteLine($"Add(1, 2, 3): {calc.Add(1, 2, 3)}");
            Console.WriteLine($"Add(2.5, 3.5): {calc.Add(2.5, 3.5)}");

            Console.WriteLine("\nOperator Overloading Example:");
            // 2. Operator Overloading
            Calculator c1 = new Calculator(10);
            Calculator c2 = new Calculator(20);
            Calculator c3 = c1 + c2; // Using overloaded + operator
            c3.DisplayValue(); // Should display: Calculator value: 30

            Console.WriteLine("\nMethod Overriding Example:");
            // 3. Method Overriding
            BaseClass1 baseObj = new BaseClass1();
            DerivedClass1 derivedObj = new DerivedClass1();
            BaseClass1 polymorphicObj = new DerivedClass1(); // Polymorphism

            // Calling the Display method from BaseClass
            baseObj.Display(); // Output: BaseClass: Display method.

            // Calling the Display method from DerivedClass
            derivedObj.Display(); // Output: DerivedClass: Overridden Display method.

            // Calling the overridden method using a BaseClass reference
            polymorphicObj.Display(); // Output: DerivedClass: Overridden Display method.

        }

    }
    // Class Definition
    class Person
    {
        // Fields (Instance Variables)
        private string name;
        private int age;

        // Static Field (Shared across all objects)
        public static int TotalPersons = 0;

        // Constructor (Default)
        public Person()
        {
            name = "Unknown";
            age = 0;
            TotalPersons++;
        }

        // Constructor (Parameterized)
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            TotalPersons++;
        }

        // Properties (Encapsulation)
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
                else
                    Console.WriteLine("Age cannot be negative.");
            }
        }

        // Static Method
        public static void DisplayTotalPersons()
        {
            Console.WriteLine("Total Persons: " + TotalPersons);
        }

        // Instance Method
        public void Introduce()
        {
            Console.WriteLine($"Hi, my name is {name}, and I am {age} years old.");
        }

        // Overloaded Method
        public void Introduce(string additionalMessage)
        {
            Console.WriteLine($"Hi, my name is {name}, and I am {age} years old. {additionalMessage}");
        }

        // Destructor
        ~Person()
        {
            Console.WriteLine($"Destructor called for {name}");
        }
    }
    class Student : Person
    {
        // Additional Field
        private string course;

        // Constructor for Student
        public Student(string name, int age, string course) : base(name, age)
        {
            this.course = course;
        }

        // Method Overriding
        public new void Introduce()
        {
            Console.WriteLine($"I am a student enrolled in the {course} course.");
        }
    }
    class MethodExamples
    {
        // Named Parameters
        public void NamedParameters(string firstName, string lastName)
        {
            Console.WriteLine($"First Name: {firstName}, Last Name: {lastName}");
        }

        // Ref Parameters
        public void RefParameters(ref int value)
        {
            value *= 2; // Modifies the original variable
        }

        // Out Parameters
        public void OutParameters(out int result)
        {
            result = 100; // Must be assigned a value inside the method
        }

        // Default Parameters
        public void DefaultParameters(int number = 10)
        {
            Console.WriteLine($"Default Parameter Value: {number}");
        }

        // Dynamic Parameters
        public void DynamicParameters(dynamic input)
        {
            Console.WriteLine($"Dynamic Parameter: {input}");
        }

        // Value Parameters
        public void ValueParameters(int value)
        {
            value += 10; // Changes only the local copy, not the original variable
        }

        // Params Parameters
        public void ParamsParameters(params int[] numbers)
        {
            Console.WriteLine("Params Parameters: " + string.Join(", ", numbers));
        }
    }
    class ConstructorExamples
    {
        private string name;
        private int age;

        // Default Constructor
        public ConstructorExamples()
        {
            name = "Default Name";
            age = 0;
            Console.WriteLine("Default Constructor Called");
        }

        // Parameterized Constructor
        public ConstructorExamples(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine($"Parameterized Constructor Called: Name = {name}, Age = {age}");
        }

        // Copy Constructor
        public ConstructorExamples(ConstructorExamples original)
        {
            this.name = original.name;
            this.age = original.age;
            Console.WriteLine($"Copy Constructor Called: Name = {name}, Age = {age}");
        }

        // Private Constructor
        private ConstructorExamples(string name)
        {
            this.name = name;
            this.age = -1;
            Console.WriteLine($"Private Constructor Called: Name = {name}, Age = {age}");
        }

        // Static Constructor
        static ConstructorExamples()
        {
            Console.WriteLine("Static Constructor Called - Runs Only Once");
        }

        // Method to demonstrate the private constructor
        public static ConstructorExamples CreateInstance(string name)
        {
            return new ConstructorExamples(name); // Accessing the private constructor
        }

        // Display method
        public void Display()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

    }
    class BaseClass
    {
        // Public: Accessible anywhere
        public string PublicProperty = "Public Property";

        // Private: Accessible only within this class
        private string PrivateProperty = "Private Property";

        // Protected: Accessible within this class and its derived classes
        protected string ProtectedProperty = "Protected Property";

        // Internal: Accessible within the same assembly
        internal string InternalProperty = "Internal Property";

        // Protected Internal: Accessible within the same assembly or in derived classes
        protected internal string ProtectedInternalProperty = "Protected Internal Property";

        // Private Protected: Accessible within the containing class or its derived classes in the same assembly
        private protected string PrivateProtectedProperty = "Private Protected Property";

        // Method to show access within the base class
        public void ShowAccessInBaseClass()
        {
            Console.WriteLine("Accessing within BaseClass:");
            Console.WriteLine(PublicProperty);
            Console.WriteLine(PrivateProperty);
            Console.WriteLine(ProtectedProperty);
            Console.WriteLine(InternalProperty);
            Console.WriteLine(ProtectedInternalProperty);
            Console.WriteLine(PrivateProtectedProperty);
        }
    }
    class DerivedClass : BaseClass
    {
        public void ShowAccessInDerivedClass()
        {
            Console.WriteLine("Accessing within DerivedClass:");
            Console.WriteLine(PublicProperty);
            // Console.WriteLine(PrivateProperty); // Not accessible
            Console.WriteLine(ProtectedProperty); // Accessible
            Console.WriteLine(InternalProperty); // Accessible (same assembly)
            Console.WriteLine(ProtectedInternalProperty); // Accessible
            Console.WriteLine(PrivateProtectedProperty); // Accessible (same assembly)
        }
    }
    class AnotherClass
    {
        public void ShowAccessInAnotherClass()
        {
            BaseClass baseObj = new BaseClass();
            Console.WriteLine("Accessing within AnotherClass:");
            Console.WriteLine(baseObj.PublicProperty);
            // Console.WriteLine(baseObj.PrivateProperty); // Not accessible
            // Console.WriteLine(baseObj.ProtectedProperty); // Not accessible
            Console.WriteLine(baseObj.InternalProperty); // Accessible (same assembly)
            Console.WriteLine(baseObj.ProtectedInternalProperty); // Accessible
            // Console.WriteLine(baseObj.PrivateProtectedProperty); // Not accessible
        }
    }
    // Single Inheritance
    // Base Class
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal can eat.");
        }
    }
    // Derived Class
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog can bark.");
        }
    }
    // Multilevel Inheritance
    // Another Derived Class from Dog
    public class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("Puppy can weep.");
        }
    }
    // Hierarchical Inheritance
    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Cat can meow.");
        }
    }
    // Multiple Inheritance (via Interfaces)
    public interface IWalkable
    {
        void Walk();
    }
    public interface IRunable
    {
        void Run();
    }
    // A Class Implementing Multiple Interfaces
    public class Horse : IWalkable, IRunable
    {
        public void Walk()
        {
            Console.WriteLine("Horse can walk.");
        }

        public void Run()
        {
            Console.WriteLine("Horse can run.");
        }
    }
    // Hybrid Inheritance (Combination of Hierarchical and Multiple)
    public class HybridExample : Dog, IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("HybridExample (Dog) can walk.");
        }
    }
    // Base class for Method Overriding demonstration
    public class BaseClass1
    {
        // Virtual method for method overriding
        public virtual void Display()
        {
            Console.WriteLine("BaseClass: Display method.");
        }
    }

    // Derived class that overrides the base class method
    public class DerivedClass1 : BaseClass1
    {
        // Overriding the Display method
        public override void Display()
        {
            Console.WriteLine("DerivedClass: Overridden Display method.");
        }
    }

    // Class for Method Overloading and Operator Overloading
    public class Calculator
    {
        // 1. Method Overloading: Same method name with different parameters

        // Adds two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Adds three integers
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Adds two doubles
        public double Add(double a, double b)
        {
            return a + b;
        }

        // 2. Operator Overloading: Overloading the + operator

        private int value;

        // Constructor to initialize value
        public Calculator(int value)
        {
            this.value = value;
        }

        // Overloading the + operator for Calculator class
        public static Calculator operator +(Calculator c1, Calculator c2)
        {
            return new Calculator(c1.value + c2.value);
        }

        // Method to display the value
        public void DisplayValue()
        {
            Console.WriteLine($"Calculator value: {value}");
        }
    }
}