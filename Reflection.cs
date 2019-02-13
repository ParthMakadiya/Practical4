using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Reflection
{
    class Student
    {
        String name, enroll_no, branch;
        public Student(String name)
        {
            this.name = name;
        }
        public Student(String name, String enroll_no)
        {
            this.name = name;
            this.enroll_no = enroll_no;
        }
        public Student(String name, String enroll_no, String branch)
        {
            this.name = name;
            this.enroll_no = enroll_no;
            this.branch = branch;
        }
        public String getName()
        {
            return this.name;
        }
        public String getEnroll()
        {
            return this.enroll_no;
        }
        public String getBranch()
        {
            return this.branch;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Type t = Type.GetType("Reflection.Student");
            ConstructorInfo[] ci = t.GetConstructors();
            MethodInfo[] mi = t.GetMethods();
            foreach (ConstructorInfo c in ci)
            {
                Console.WriteLine(c.ToString());
            }
            foreach (MethodInfo m in mi)
            {
                Console.WriteLine(m.ToString());
            }
            Console.ReadLine();
        }
    }
}
 
