
////using System;

////public class HelloWorld
////{
////    public static void Main(string[] args)
////    {
////        int choice;
////        Console.WriteLine("enter the two number ");
////        int a = Convert.ToInt32(Console.ReadLine());
////        int b = Convert.ToInt32(Console.ReadLine());
////        Console.WriteLine("enter your choice: ");

////        Console.WriteLine("1.Addition  ");
////        Console.WriteLine("2.Subtraction  ");
////        Console.WriteLine("3.Division ");
////        Console.WriteLine("4.Multiplication  ");

////        choice = Convert.ToInt32(Console.ReadLine());


////        switch (choice)
////        {
////            case 1:
////                { int sum = a + b;
////                    Console.WriteLine("Sum of  a and b is: "  + sum);
////                    break;
////                }

////            case 2:
////                { int sub = a - b;
////                    Console.WriteLine("Subtraction of a and b is: " + sub);
////                    break;
////                }

////            case 3:
////                {
////                    int divi = a / b;
////                    Console.WriteLine("Division of a and b " + divi);
////                    break;
////                }

////            case 4:
////                {
////                    int mul = a * b;
////                    Console.WriteLine("Multiplication of a and b " + mul);
////                    break;
////                }

////            default:
////                {
////                    Console.WriteLine("Invalid choice ");
////                    break;
////                }


////        }



////    }
////}




//for (int i = 1; i <= 100; i++)
//{ Console.WriteLine(i); }




//// multiplaction table
//// login system
//// odd even negative 

////using if else 



// odd even 
//int n;
//Console.WriteLine("Enter a number ");
//n = Convert.ToInt32(Console.ReadLine());

//if (n % 2 == 0)
//{
//    Console.WriteLine("Even number ");
//}
//else
//    Console.WriteLine("Odd number");


// positive negative  or zero



//int n;
//        Console.Write("Enter a number ");
//        n = Convert.ToInt32(Console.ReadLine());

//    if (n == 0)
//    {
//        Console.WriteLine("Zero number ");
//    }
//    else if (n > 0)
//    {

//        Console.WriteLine("Positive  number");
//    }

//    else
//        Console.WriteLine("Negative number ");



// 1 to 50 using for and while loo[

//for(int i = 1; i <=50; i++) { Console.WriteLine(i); }


//int n;
//Console.WriteLine("Enter a number ");
//n = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Multiplication Table of " + n);

//for(int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(n +  "X"+ i + "=" +(i*n));
//}


//int marks;

//Console.Write("Enter the marks: ");


//marks = Convert.ToInt32(Console.ReadLine());

//if (marks > 90)
//{
//    Console.WriteLine("A +");
//}
//else if (marks > 80)
//{
//    Console.WriteLine("A");
//}
//else if (marks > 70)
//{
//    Console.WriteLine("B+");
//}
//else if (marks > 60)
//{
//    Console.WriteLine("B");
//}
//else if (marks > 50)
//{
//    Console.WriteLine("C");
//}
//else if (marks > 40) { Console.WriteLine("D"); }
//else
//    Console.WriteLine("You are fail. ");




//Console.Write("Enter the age: ");
//int age=Convert.ToInt32(Console.ReadLine());

//if (age < 18)
//{
//    Console.WriteLine("You are child. ");
//}
//else if (age > 18 && age < 60)
//{
//    Console.WriteLine("You are Adult");

//}
//else
//    Console.WriteLine("Senior ");



//Console.WriteLine("Enter the three number ");
//    int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int c = Convert.ToInt32(Console.ReadLine());

//if (a > b && a > c)
//{
//    Console.WriteLine( a+ " is the greatest number");
//}
//else if (b > a && b > c)
//{
//    Console.WriteLine(b+ " is the greatest number");
//}
//else
//    Console.WriteLine(c+ " is the greatest number ");


// use of foreach
//string[] week = { "sunday", "monday" };
//foreach(string day in week)
//{
//    Console.WriteLine(day);
//}



//Console.Write("Enter a number: ");
//int n=Convert.ToInt32(Console.ReadLine());

//int count = 0;
//for (int i = 1; i <= n; i++)
//{
//    if (n % i == 0)
//    {
//        count++;
//    }
//}
//if (count == 2)
//{
//    Console.WriteLine(n + " is a prime number ");
//}
//else
//    Console.WriteLine(n + " is a composite number");







//prime number up to nnumber


//Console.WriteLine("enter a number ");
//int n=Convert.ToInt32(Console.ReadLine());

//for(int i = 2; i <= n; i++)
//{
//    bool prime = true;
//    for(int j = 2; j < i; j++)
//    {
//        if (i % j == 0)
//        {
//            prime = false;
//            break;
//        }
//    }
//    if (prime) { 
//        Console.WriteLine(i);
//    }

//}




//count prime and composite from array



//Console.WriteLine("Composite Numbers: ");




//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//int count = 0;
//for (int i = 1; i <=arr.Length; i++)
//{
//    if (arr[i] % i == 0)
//    {
//        count++;
//    }
//if (count == 2)
//{
//    Console.WriteLine(arr[i] + " is a prime number ");
//}
//}




//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,19 };


//Console.Write("Prime Numbers: ");
//for (int i = 0; i < arr.Length; i++)
//{
//    bool prime = true;
//    if (arr[i] < 2)
//        prime = false;

//    for (int j = 2; j * j <= arr[i]; j++)
//    {
//        if (arr[i] % j == 0)
//        {
//            prime = false;
//            break;
//        }
//    }
//    if (prime)
//    {
//        Console.Write(arr[i]);
//    }
//}


//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 19 };


//Console.Write("Prime Numbers: ");
//for (int i = 0; i < arr.Length; i++)
//{
//    int count = 0;
//    for (int j = 2; j <=arr.Length; j++)
//    {
//        if (arr[i] % j == 0 )
//        {
//            count++;
//        }
//    }
//    if (count == 1)
//    {
//        Console.WriteLine(arr[i]+" ");
//    }

//}








//void message()
//{
//    Console.WriteLine("Welcome to C#");
//}

//message();

//void print(int a){

//}
//Console.Write("enter a number: ");
//int a = Convert.ToInt32(Console.ReadLine());

//print(a);
//Console.WriteLine(a);






// area of circle , rectangle and triangle 




//void circle(double r)
//{
//   double area= ( 3.14*r* r);
//    Console.WriteLine("Area of circle is: "+area);
//}
//void rectangle(int l,int b)
//{
//    int area = l * b ;
//    Console.WriteLine("Area of rectangle is: " + area);
//        }

//void triangle(int h,int b)
//{
//    double area = ( 0.5*(h * b));
//    Console.WriteLine("Area of triangle is: " + area);

//}


//Console.Write("Enter the radius of circle: ");
//int r = Convert.ToInt32(Console.ReadLine());
//circle(r);

//Console.Write("Enter the length of rectangle: ");
//int l=Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the breadth of rectangle: ");
//int b = Convert.ToInt32(Console.ReadLine());
////Console.Write("Enter the height of rectangle: ");
////int h = Convert.ToInt32(Console.ReadLine());

//rectangle(l, b);

//Console.Write("Enter the height of triangle: ");
//int rh = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the breadth of triangle: ");
//int rb = Convert.ToInt32(Console.ReadLine());
//triangle(rh, rb);




// void swap(ref int  a, ref int b){

//    int temp = a;
//    a = b;
//    b = temp;
//    Console.WriteLine("the value after swapping x: " +a+ " Y: "+b);

//}

//int x=10,y=11;

//swap(ref x, ref y);



//for(int i = 1; i <= 100; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

// number 100 to 1
//for (int i = 100; i >= 1; i--)
//{
//    Console.WriteLine(i);
//}

//count how many digits in number 

//Console.WriteLine("Enter the number: ");
//int a=Convert.ToInt32(Console.ReadLine());






























