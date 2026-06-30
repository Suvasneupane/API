using System;
using System.Collections.Generic;
using System.Text;

namespace hospital_management.Hospital
{


    public class Patient:Doctor
    {
        public string patient_name;
        public string patient_address;
        public int patient_age;

        public void patient_details()
        {
            Console.WriteLine();
            Console.Write("Enter the name: ");
            patient_name = Console.ReadLine();
            Console.Write("Enter the address: ");
            patient_address = Console.ReadLine();
            Console.Write("Enter the age: ");
            patient_age = int.Parse(Console.ReadLine());

        }


        
        public void patient_print()
        {
            Console.WriteLine();
            Console.WriteLine("Your Doctor: " + Doctor.doctor_name);
            Console.WriteLine("Name: "+patient_name);
            Console.WriteLine("Address: "+patient_address);
            Console.WriteLine("Age: "+patient_age);
            Console.WriteLine();
        }


       


        public void patient_edit()
        {
            Console.Write("Enter new Name: ");
            patient_name = Console.ReadLine();

            Console.Write("Enter new address: ");
            patient_address = Console.ReadLine();

            Console.Write("Enter new Age: ");
            patient_age = int.Parse(Console.ReadLine());

        }


        public void patient_delete()
        {
            patient_name = " ";
            patient_address= " ";
            patient_age = 0;

        }


        public void patient_display()
        {

            Console.WriteLine("Name: " + patient_name);
            Console.WriteLine("Address: " + patient_address);
            Console.WriteLine("Age: " + patient_age);
            Console.WriteLine();
        }



    }
}
