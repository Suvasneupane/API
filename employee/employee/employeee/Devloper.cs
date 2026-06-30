public class Developer:Employee
{
    
    public string CurrentProject;

    public void display()
    {
        Console.WriteLine("post : developer ");
        Console.WriteLine("name : " +EmployeeName);
        Console.WriteLine("salary: " + EmployeeSalary);
        Console.WriteLine("current project " + CurrentProject); ;
    }

    public double bonus()
    {
        return  (EmployeeSalary * 10 / 100);
    }
}