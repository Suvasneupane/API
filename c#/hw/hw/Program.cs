//print even numbers 1 to 100
//for(int i = 1; i <= 100; i++) { if (i % 2 == 0) { Console.WriteLine(i); } }

//print 100 to 1
//for (int i = 100; i >= 1; i--) {  Console.WriteLine(i); }



//Console.WriteLine("enter the number: ");
//int n = int.Parse(Console.ReadLine());

//int temp = n;
//int reverse = 0;
//while (temp != 0)
//{
//    reverse = reverse * 10 + temp % 10;
//    temp /= 10;

//}

//Console.WriteLine("Number after reverse: " + reverse);



//Console.WriteLine("enter the number: ");
//int n=int.Parse(Console.ReadLine());
//int count = 0;

//while (n > 0)
//{

//    n /= 10;
//    count++;
//}
//Console.WriteLine("The number of digits are: "+count);



//Console.WriteLine("enter the number: ");
//int n = int.Parse(Console.ReadLine());

//int temp = n;
//int reverse = 0;

//while (temp != 0)
//{
//    reverse = reverse * 10 + temp % 10;
//    temp /= 10;
//}

//Console.WriteLine("Reversed number: " + reverse);


//Console.WriteLine("Enter the number: ");
//int n=int.Parse(Console.ReadLine());
//int temp = n;
//int reverse = 0;
//while (temp != 0)
//{
//    reverse = reverse * 10 + temp % 10;
//       temp /= 10;

//}
//if (reverse == n)
//{
//    Console.WriteLine(n + " is a palindrome number.");
//}
//else
//    Console.WriteLine(n + " is not palindrome.");



//for(int i = 1; i <= 5; i++)
//{
//    for(int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine(" ");
//}


//downward pattern
//for (int i = 5; i >= 1; i--)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine(" ");
//}


//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write(j);
//    }
//    Console.WriteLine(" ");
//}






//Console.WriteLine("enter the number: ");
//int n=int.Parse(Console.ReadLine());


//int i;
//Console.WriteLine("Prime numbers:");
//for (i=2; i <= n; i++)
//{
//    bool prime = true;
//    for (int j = 2; j<i;j++)
//    {
//        if (i % j == 0)
//        {

//        prime = false;
//        break;
//        }

//    }
//    if (prime)
//    {
//        Console.WriteLine(i);
//    }
//}
//Console.WriteLine("Composite numbers are: ");
//for (i = 2; i <= n; i++)
//{
//    bool prime = true;
//    for (int j = 2; j < i; j++)
//    {
//        if (i % j == 0)
//        {

//            prime = false;
//            break;
//        }

//    }
//    if (prime==false)
//    {
//        Console.WriteLine(i);
//    }
//}



//Console.WriteLine("enter the number: ");
//int n = int.Parse(Console.ReadLine());

//int count = 0;
//int i;

//for (i = 2; i*i <= n; i++)
//{

//        if (n%i == 0)
//        {
//            count++;

//    }
//    if (count == 2)
//    {
//        Console.WriteLine(n + " is a prime number.");
//    }
//    else
//        Console.WriteLine(n + " is not prime number");
//}



//Console.Write("Enter the number: ");
//int n=int.Parse(Console.ReadLine());
//  int count = 0;

//    for (int j = 2; j <= n; j++)
//    {
//        if (n % j == 0)
//        {
//            count++;
//        }

//}
//if (count == 1)
//{
//    Console.WriteLine(n + " is prime number");
//}

//else
//    Console.WriteLine(n + " is not prime number");







//Console.Write("Enter the number: ");
//int n=int.Parse(Console.ReadLine());
//int fact = 1;
//for(int i = 1; i <= n; i++)
//{
//    fact *= i;

//}
//Console.WriteLine("The factorial of " + n + " is " + fact);






//Console.Write("Enter the number:");
//int n=int.Parse(Console.ReadLine());

//int fib=1 ;
//int a = 0, b = 1;
//for(int i = 1; i <= n; i++)
//{
//    Console.WriteLine(fib+" ");
//    fib = a + b;
//    a = b;
//    b=fib;
//}



//Console.Write("Enter the number: ");
//int n=int.Parse(Console.ReadLine());

//int fib = 0;
//int a = 0, b = 1;
//for(int i = 1; i <= n; i++)
//{
//    fib = a + b;
//    a = b;
//    b = fib;

//    Console.Write(fib+" ");
//}





//using System;

//public class HelloWorld
//{




//    public static void Main(string[] args)
//    {


//string account_holder_name = " ";
//int account_number = 12345;
//double balance = 0;





//        int choice;
//        Console.WriteLine("enter your choice: " ) ;
//        choice=int.Parse(Console.ReadLine());


//        switch(choice)
//        {
//            case 1:
//        }









//    }
//}





static string account_holder_name = "";
int account_number = 1234;
double balance = 0;
static void  show()
{
    Console.WriteLine("Our online banking");
    Console.WriteLine("1.Create Account");
    Console.WriteLine("2. Deposite money");
    Console.WriteLine("3.Withdraw money");
    Console.WriteLine("4.Check blance");
    Console.WriteLine("5.Show account details");
    Console.WriteLine("6. Exit");



}


void create() {
    
    Console.Write("enter your name: ");
    account_holder_name = Console.ReadLine();

    Console.WriteLine("enter your initial balance: ");
    balance=double.Parse(Console.ReadLine());
    Console.WriteLine("Account created successfully ");



            }
void deposite() {
    if (account_holder_name = "")
    {
        con
    }
    

    
                                }
void withdraw() {        
                                



                                }
void check() {






                                       }
void details() { 





                                                        }
void exit() { 






                                                        }




Console.Write("enter your choice:");
int choice=int.Parse(Console.ReadLine());

show();
switch (choice)
{
    case 1:
        {
            create();
            break;
        }

    case 2:
        {
            deposite();
            break;
        }

    case 3:
        {
            withdraw();
            break;
        }

    case 4:
        {
            check();
            break;
        }
    case 5:
        {
            details();
            break;
        }
    case 6:
        {
            exit();
            break;
        }


}