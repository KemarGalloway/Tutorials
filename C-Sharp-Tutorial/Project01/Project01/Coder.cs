using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01
{
    class Coder
    {
        private string fName;
        private string lName;
        private int age;
        private float salary;
        private char expertise;

        public string FirstName
        {
            get { return this.fName; }
            set
            {
                this.fName = value;
            }
        }

        public string lastName
        {
            get { return this.lName; }
            set
            {
                this.lName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                value = this.age;
                if (value < 0)
                {
                    Console.WriteLine("Age cannot be less than 0");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public float Salary
        {
            get { return this.salary; }
            set
            {
                value = this.salary;
                if(salary < 100000.00)
                {
                    Console.WriteLine("Salary cannot be below $100,000.00");
                    Console.WriteLine("Coders are AWESOME!");
                }
                else
                {
                    this.salary = value;
                }
            }
        }

        public char Expertise
        {
            get { return this.expertise; }
            set
            {
                value = this.expertise;
                switch(value)
                {
                    case 'A':
                        Console.WriteLine("Specializes in C++ ");
                        break;
                    case 'B':
                        Console.WriteLine("Specializes in C# ");
                        break;
                    case 'C':
                        Console.WriteLine("Specializes in Java ");
                        break;
                    case 'D':
                        Console.WriteLine("Specializes in Objective C ");
                        break;
                    case 'E':
                        Console.WriteLine("Specializes in PHP ");
                        break;
                    case 'F':
                        Console.WriteLine("Specializes in MatLab ");
                        break;

                    default:
                        Console.WriteLine("Other speciality");
                        break;

                }
            }
        }

        public virtual void solveProblems()
        {
            Console.WriteLine("Problem attempted");
        }

        public virtual Double purchaseCoffee()
        {
            Double price = 23.23;
            return price;
        }


    }
}
