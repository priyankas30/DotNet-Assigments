using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("Amol", 123465, 10);
            Employee o2 = new Employee("Amol", 123465);
            Employee o3 = new Employee("Amol");
            Employee o4 = new Employee();

            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);

            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);
            Console.ReadLine();

        }
    }
    class Employee
    {
        public Employee(string name=null, decimal basicSal=0, short deptNo=0)
        {
           
            //empNo=++empNo;
            empNo = ++eNo;
            NAME = name;
            BASIC = basicSal;
            DEPARTMENT = deptNo;

        }
        //Name Property
        private string name;
        public string NAME
        {
            set
            {
                if (value != null)
                    name = value;
                else
                    Console.WriteLine("Invalid Entry");
            }
            get
            {
                return name;
            }
        }
        //EmpNo propperty
        private int empNo;

        public int EmpNo
        {
            get
            {
                return empNo;
            }
        }


        private static int eNo;
        public static int Eno
        {
            set
            {
                eNo = 0;

            }
            get
            {
                return eNo;
            }
        }
        //Salaary Property
        private decimal basicSal;
        public decimal BASIC
        {
            set
            {
                if (value < 450000 && value > 0)
                    basicSal = value;
                else
                    Console.WriteLine("Invalid Salary");
            }
            get
            {
                return basicSal;
            }
        }
        //Department Property
        private short deptNo;
        public short DEPARTMENT
        {
            set
            {
                if (value > 0)
                    value = deptNo;
                else
                    Console.WriteLine("Invalid Department No");
            }
            get
            {
                return deptNo;
            }

        }
        //property ends
        public decimal getNetSalary()
        {
            return BASIC + 1500;
        }

    }
}
