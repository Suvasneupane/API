public class Manager:Employee
{
    
    public string Department;

    public void display()
    {

        Console.WriteLine("post: manager");
        Console.WriteLine("name: "+EmployeeName);
        Console.WriteLine("salary: "+EmployeeSalary); 
    }

    public double bonus()
    {
        return  (EmployeeSalary * 50 / 100);
    }
}