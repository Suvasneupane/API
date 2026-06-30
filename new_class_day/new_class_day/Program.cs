


using new_class_day;
using new_class_day.calculator;



Console.WriteLine("Enter two number: ");
int x=int.Parse(Console.ReadLine());
int y=int.Parse(Console.ReadLine());

int sum=Calculator.sum(x,y) ;
int sub=Calculator.sub(x, y);
int mul=Calculator.mul(x, y);
int divi = Calculator.divi(x, y);


Console.WriteLine("Enter your choice: ");
Console.WriteLine("1.Addition");
Console.WriteLine("2.Subtraction");
Console.WriteLine("3.Multiplication");
Console.WriteLine("4.Division");

int choice = int.Parse(Console.ReadLine());


switch (choice)
{
    case 1:
        {
            Console.WriteLine("Sum is "+ sum);
            break;
        }
        case 2: {
            Console.WriteLine("Sub is "+ sub);
            break;
        } case 3: {
            Console.WriteLine("Multiplication: " + mul);
            break;

        }
    case 4:
        {
            Console.WriteLine("Division: " + divi);
            break;
        }

    default:
        {
            Console.WriteLine("Invalid ");
            break;
        }
}