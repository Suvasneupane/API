using System;
using System.Collections.Generic;
using System.Text;

namespace hospital_management.Hospital
{
   public class Doctor
    {

        public static string doctor_name;

        public static  string doctor_department;



        public void add()
        {
            Console.Write("Enter the name: ");
            doctor_name = Console.ReadLine();

            Console.Write("Enter the department: ");
            doctor_department = Console.ReadLine();

        }

        public void edit()
        {
            Console.Write("Enter the new name: "); 
            doctor_name = Console.ReadLine();
            Console.Write("Enter the new department: ");
            doctor_department = Console.ReadLine();
        }

        public void delete()
        {
            doctor_name = " ";
            doctor_department= " ";

           
        }

        public void details()
        {
            Console.WriteLine();
            Console.WriteLine("Name: "+doctor_name);
            Console.WriteLine("Department: "+doctor_department);
            Console.WriteLine();
           
            
        }
       



    }
}
