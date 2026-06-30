





//int sum(int a,int b)
//{
//    return a + b;

//}

//int sub(int a, int b)
//{
//    return a - b;

//}

//int mul(int a, int b) {  
//    return a * b; 
//}

//int divi(int a,int b)
//{
//    return a / b;
//}


//Console.WriteLine("Enter the two number; ");
//int x=int.Parse(Console.ReadLine());
//int y=int.Parse(Console.ReadLine());
//sum(x,y);
//sub(x,y);
//divi(x,y);
//mul(x,y);


//Console.WriteLine("the sum of x and y is: "+sum(x,y));
//Console.WriteLine("the sub of x and y is: " + sub(x, y));
//Console.WriteLine("the multiplication of x and y is: " + mul(x, y));
//Console.WriteLine("the division of x and y is: " + divi(x, y));





//int[] arr= new int[5] ;

//Console.WriteLine("enter the marks of students :");
//for(int i = 0; i < 5; i++)
//{

//    arr[i] = int.Parse(Console.ReadLine());

//}

//Console.Write("marks: ");
//for (int i = 0;i < 5; i++)
//{
//    Console.WriteLine(arr[i]);
//}



//string[] friut= new string[5];



//for(int i = 0; i < friut.Length; i++)
//{
//    Console.Write("enter the names of friut "+ ( i + 1)+": ");
//    friut[i] = Console.ReadLine();

//}

//Console.Write("printing: ");
//for(int i = 0;i < friut.Length; i++)
//{
//    Console.WriteLine(friut[i]);
//}


//int[] arr = { 1, 2, 3, 4, 2, 3, 45, 53, 33 };
//int largest = arr[0];

//for(int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] > largest)
//    {
//        largest = arr[i];
//    }
//}
//Console.WriteLine(largest+" is the largest number ");



//int[] arr = new int[5];
//int sum = 0;
//int largest = arr[0];
//int smallest=arr[0];

//Console.Write("enter the numbers  :");
//for (int i = 0; i < 5; i++)
//{

//    arr[i] = int.Parse(Console.ReadLine());
//    if (arr[i] > largest)
//    {
//        largest = arr[i];
//    }
//    else
//    {
//        smallest = arr[i];
//    }
//    sum += arr[i];

//}

//int average=(sum/arr.Length);
//Console.WriteLine();
//Console.WriteLine(average+" the average of numbers  ");

//Console.WriteLine(largest + " is the largest number ");
//Console.WriteLine(smallest + " is the smallest number ");





//int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

//Array.Reverse(arr);
//for(int i=0; i<arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}


//int[] arr= new int[5];

//Console.WriteLine("enter the numbers: ");

//for(int i = 0; i < arr.Length; i++)
//{
//    arr[i] = int.Parse(Console.ReadLine());
//}


//Console.Write("enter the number which you want index: ");
//int index=int.Parse(Console.ReadLine());


//for(int i = 0;i < arr.Length; i++)
//{
//    if(arr[i] == index)
//    {
//        Console.WriteLine(i);
//            }

//}


//int[] arr = new int[5];
//int even_count = 0;
//int odd_count = 0;
//Console.WriteLine("enter the numbers: ");

//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = int.Parse(Console.ReadLine());

//    if (arr[i] % 2 == 0)
//    {
//        even_count++;
//    }
//    else
//        odd_count++;


//}

//Console.WriteLine("the number of even numbers are: "+even_count);
//Console.WriteLine("the number of odd numbers are: "+odd_count);



// count positive and negative numbers in array


//int[] arr= new int[5];

//int positive = 0;
//int negative = 0;

//Console.Write("Enter the numbers: ");
//for( int i=0;i<arr.Length;i++)
//{
//    arr[i] = int.Parse(Console.ReadLine());

//    if (arr[i] > 0)
//    {
//        positive++;

//    }
//    else
//    {
//        negative++;
//    }

//}
//Console.WriteLine("the number of positive numbers in array are: " + positive);
//Console.WriteLine("the number of negative numbers in array are: " + negative);



// shift by 1 bit in array elements 

//int[] arr = { 1, 2, 3, 4, 5, 6 };
//int temp = arr[0];
//for (int i = 0; i < arr.Length-1; i++)

//{
//    arr[i] = arr[i + 1];

//}

//arr[arr.Length-1] = temp;

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}


// copying array to another 

//int[] arr = {1,2,3,4,5,6,7,8};
//int[] arr1= new int[arr.Length];

//for(int i = 0; i < arr.Length;i++)
//{
//    arr1[i] = arr[i];

//}
//for(int i = 0;i < arr.Length;i++)
//{

//    Console.WriteLine(arr1[i]);
//}



//static void ask(string[] fruit)
//{
//    for (int i = 0; i < fruit.Length; i++)
//    {
//        Console.WriteLine("Enter the name of friut  " + (i+1));

//        fruit[i] = Console.ReadLine();
//    }


//}

//static void print(string[] fruit)
//{

//    for (int i = 0; i < fruit.Length; i++)
//    {
//        Console.WriteLine(fruit[i]);
//    }
//}


//string[] fruit = new string[5];
//ask(fruit);
//print(fruit);





static void ask(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.WriteLine("Enter the numbers  " + (i + 1));

        num[i] = int.Parse(Console.ReadLine());

    }

}

static void print(int[] num)
{

    for (int i = 0; i < num.Length; i++)
    {
        Console.WriteLine(num[i]);
    }
}


void sort(int[] num)
{
    for(int i = 0; i < num.Length; i++)
    {
        for(int j = i + 1; j < num.Length; j++)
        {
            if (num[j] < num[i])
            {
                int temp = num[j];
                num[j] = num[i];
                num[i] = temp;



            }
        }

        Console.WriteLine("After sorting: " + num[i]);
    }
    
}


int[] num = new int[5];
ask(num);
    print(num);





