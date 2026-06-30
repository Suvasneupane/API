
//int [] arr = { 3, 4, 2, 4, 5,7,8,9 };
//int n = arr.Length;
//int i;
//int j;
//for (i = 0; i < n - 1; i++)
//{
//    for (j = i + 1; j < n; j++)
//    {
//        if (arr[i] > arr[j])
//        {
//            int temp = arr[i];
//            arr[i] = arr[j];
//            arr[j] = temp;
//        }
//    }
//}

//for (i = 0; i < n; i++)
//{
//    Console.WriteLine(arr[i]);
//}


//int[] arr = { 1, 2, 3, 4, 5 };
//int start = 0;
//int end = arr.Length - 1;

//while (start > end)
//{
//    int temp = arr[start];
//    arr[start] = arr[end];
//    temp = arr[end];
//    start++;
//    end--;

//}




// count how many times each element appears 

//int[] arr = { 1, 2, 3, 4, 2, 3, 4};
//int i, j;
//for (i = 0; i < arr.Length; i++)
//{
//    for (j = 0; j < i; j++)
//    {
//        if (arr[i] == arr[j])
//        {


//        }

//    }
//}
//Console.WriteLine(arr[i]);





// print duplicate numbers from the array  

//int[] arr = {1,2,1,3,3,4,4,5 };
//int i, j;

//for (i = 0; i < arr.Length; i++)
//{
//    for (j = 0; j < i; j++)
//    {
//        if (arr[i] == arr[j])
//        {
//            Console.WriteLine(arr[i]);
//        }
//    }
//}




// rotate an array to the left by 1 position [ 1,2,3,4]=> [2,3,4,1]

//int[] arr = { 1, 2, 3, 4, 5 };
//int i;

//int temp = arr[0];
//arr[0] = arr[arr.Length - 1];
//arr[arr.Length-1] = temp;

//for (i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}






//string name = "suvas neupane";
//int age = 19;
//string address = "sunwal";
//int roll=32;



//Console.WriteLine("my name is " + (name)+ " my age is " + (age)+
//    " my address is " + (address)+ " my roll no is " + (roll));



//Console.WriteLine("enter your name  ");
//string name= Console.ReadLine();
//Console.WriteLine("enter your age");
//int age = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("enter your address ");
//string address=Console.ReadLine();


//Console.WriteLine("your name is "+ name);

//Console.WriteLine("your age is " + age);
//Console.WriteLine("your address is " + address);



//Console.WriteLine("enter the degree in celcius ");
//int celcius = Convert.ToInt32(Console.ReadLine());
//float fahrenheit = ((celcius * 9 / 5) + 32);
//Console.WriteLine(fahrenheit);



//Console.WriteLine("enter the three number ");
//int a= Convert.ToInt32 (Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int c = Convert.ToInt32(Console.ReadLine());


//if (a > b && a > c)
//{
//    Console.WriteLine("greatest number is " + a);

//}
//else if (b > a && b > c)
//{
//    Console.WriteLine(" greatest number is " + b);
//}
//else
//{
//    Console.WriteLine("greatest number is " + c);
//}


// even odd

//Console.WriteLine("enter the number ");
//int a=Convert.ToInt32 (Console.ReadLine());
//if (a % 2 == 0)
//{
//    Console.WriteLine( a + " is even number ");
//}
//else
//{
//    Console.WriteLine( + a + " is odd number  ");
//}



//int choice;
//Console.WriteLine("enter the first number ");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("enter the second number ");
//double b = Convert.ToDouble(Console.ReadLine());


//Console.WriteLine("enter your choice  ");
//Console.WriteLine("1.ADD ");
//Console.WriteLine("2.SUB ");
//Console.WriteLine("3.MUL ");
//Console.WriteLine("4.DIV ");

// choice =Convert.ToInt32( Console.ReadLine());

//switch(choice)
//{
//    case 1:
//        Console.WriteLine("addition= " + (a + b));
//        break;

//    case 2:
//        Console.WriteLine("substraction= " + (a - b));
//        break;

//    case 3:
//        Console.WriteLine("multiplication= " + (a * b));
//        break;
//    case 4:
//        Console.WriteLine("division= " + (a / b));
//        break;

//    default:
//        Console.WriteLine("invalid choice ");
//        break;


//}


 

//int s1 =Convert.ToInt32( Console.ReadLine());