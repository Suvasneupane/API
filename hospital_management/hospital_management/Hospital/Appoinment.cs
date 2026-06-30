using System;
using System.Collections.Generic;
using System.Text;

namespace hospital_management.Hospital
{
    public class Appoinment:Patient
    {
        int date_;
        int number;
        public void appoinment_date()
        {
            Console.WriteLine();
            Console.Write("Ente the date of appoinment: ");
            date_=int.Parse(Console.ReadLine());

            Console.Write("Regrestration Number: ");
             number=int.Parse(Console.ReadLine());
        }
        public void appoinment_print_date()
        {
            Console.WriteLine();
            Console.WriteLine("Appoinment Details: ");
            Console.WriteLine("Date: "+date_);
            Console.WriteLine("Registration Number: "+number);
          
        }

    }
}
