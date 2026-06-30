class Program
{

    static void Main(String[] args)
    {




        for(int i = 0; i <= 10; i++)
        {
            Console.Write("Name: "); 
            string name= Console.ReadLine();
            
            Console.Write("Salary: ");
            double salary= double.Parse(Console.ReadLine());

            Console.Write("Post: ");
            string post= Console.ReadLine();

            



            if (post == "manager")
            {
                Console.Write("department: ");

                Manager mgr=new Manager();

                mgr.EmployeeName = name;
                mgr.EmployeeSalary=salary;
                mgr.Department = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();

                mgr.display();

                Console.WriteLine("total bonus: "+ mgr.bonus());
                Console.WriteLine();

                
            }
            else
            { 
                Console.WriteLine();
                Console.Write("current Projects: ");
                Developer dev = new Developer();

                dev.EmployeeName = name;
                dev.EmployeeSalary = salary;
                dev.CurrentProject=Console.ReadLine();

                dev.display();
                Console.WriteLine(" total bonus  "+ dev.bonus());

                Console.WriteLine();
            }

        }

    }

}