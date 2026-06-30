//string[] arr = { "suvas", "ujwal", "parkas" };

//foreach(var item in arr)
//{
//    Console.WriteLine(item);
//}



//int[] arr = { 1, 2, 3, 4,11,5, 6, 7, 8, 9 };
//int greatest = arr[0];
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] > greatest)
//    {
//        greatest = arr[i];
//    }
//}
//Console.WriteLine(greatest);





//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//int lowest = arr[0];

//for (int i = 0; i < 9; i++)
//{
//    if (arr[i] < lowest)
//    {
//        lowest = arr[i];
//    }
//}
//Console.WriteLine(lowest);



// calculate the average of the numbers in the array
// calculate the sum of the numbers in the array
//count the number of even and odd number in the array




//using System;
//class Program
//{
//    static void Main()
//    {
//        int[] arr = { 1, 2, 3, 4, 5 };
//        int i;
//        int sum = 0;

//        for (i = 0; i <arr.Length; i++)
//        {
//            sum = sum + arr[i];
//        }
//        //sum = sum / 5;

//        Console.WriteLine(sum /arr.Length);
//    }
//}




//int[] arr = { 1, 2, 3, 3, 3, 3 };

//Array.Sort(arr);

//int largest = arr[arr.Length - 1];
//int secondlargest = -1;

//// loop from second last element backwards
//for (int i = arr.Length - 2; i >= 0; i--)
//{
//    if (arr[i] != largest)
//    {
//        secondlargest = arr[i];
//        break;
//    }
//}

//Console.WriteLine("Second largest is " + secondlargest);





//using System;
//class Program
//{
// static void Main()
//    {
//        int[] arr = { 1, 2, 3, 4, 5 };
//        int i;
//        int sum = 0;

//        for (i = 0; i < 5; i++)
//        {
//            sum = sum + arr[i];
//        }

//        Console.WriteLine(sum);
//    }
//}



//using System;
//class Program
//{
//    static void Main()
//    {
//        int i;

//        int[] arr = { 1, 2, 3, 4, 5 };
//        int odd = 0;
//        int even = 0;

//        for (i = 0; i < 5; i++)
//        {
//            if (arr[i] % 2 == 0)
//            {
//                even++;
//            }
//            else
//            {
//                odd++;
//            }


//        }

//        Console.WriteLine("Odd numbers: " + odd);
//        Console.WriteLine("Even numbers: " + even);

//    }
//    }







//int i;
//int j;

//for (i = 1; i <= 5; i++)
//{
//    for (j = 1; j <= i; j++)
//    {

//        Console.Write("*");

//    }
//    Console.Write("\n");
//}




//int i;
//int j;

//for (i = 5; i >= 1; i--)
//{
//    for (j = 1; j <= i; j++)
//    {

//        Console.Write(j);

//    }
//    Console.Write("\n");
//}



//int i;
//int j;

//for (i = 5; i >= 1; i--)
//{
//    for (j = 1; j <= i; j++)
//    {

//        Console.Write("*");

//    }
//    Console.Write("\n");
//}




//int[] arr = { 1, 2, 3, 3, 4, 5, 5, 5 };

//int largest = arr[0];
//int second = int.MinValue;

//for (int i = 1; i < arr.Length; i++)
//{
//    if (arr[i] > largest)
//    {
//        second = largest;
//        largest = arr[i];
//    }
//    else if (arr[i] < largest && arr[i] > second)
//    {
//        second = arr[i];
//    }
//}

//if (second == int.MinValue)
//    Console.WriteLine("No second largest element");
//else
//    Console.WriteLine("Second largest = " + second);






// 1.find the second largest number in array
//2. count how many number are greater than average of the array .
//3.reverse the array 
//4.sort the array in ascending order 
//5.find the sum of even and odd numbers in the array 


// 1.find the second largest number in array

//int[] arr = { 1, 2, 3,3,3,3 ,4};
//int i;

//Array.Sort(arr);
//int secondlargest = arr[arr.Length - 2];
//Console.WriteLine("second largest is " + secondlargest);


//2. count how many number are greater than average of the array .


//int[] arr = { 1, 2, 3, 4, 5 };
//int i;
//int sum = 0;
//int greater_than_average = 0;

//for (i = 0; i < arr.Length; i++)
//{
//    sum = sum + arr[i];
//}

//int average = (sum / arr.Length);


//for (i = 0; i < arr.Length; i++)

//{
//    if (average < arr[i])
//    {

//        greater_than_average++;
//    }
//}

//Console.WriteLine("number greater than average are " + greater_than_average);




//3.reverse the array 

//int[] arr = { 1, 2, 3, 4, 5 };
//int i;
//Array.Reverse(arr);

//for (i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}



//4.sort the array in ascending order 

//int[] arr = { 4, 5, 3, 4, 6, 7 };
//int i;
//Array.Sort(arr);
//for (i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}



//5.find the sum of even and odd numbers in the array 

//int[] arr = { 1, 2, 3, 4, 5 };
//int i;
//int even=0;
//int odd=0;
//for (i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 0)
//    {
//        even += arr[i];
//    }
//    else
//    {
//        odd += arr[i];

//    }
//}

//Console.WriteLine("sum of even number is " + even);
//Console.WriteLine("sum of odd number is "+ odd);


////desending order 

//int[] arr = { 1, 2, 77, 45, 7, 8, 9 };
//int i;
//Array.Sort(arr);
//Array.Reverse(arr);
//for (i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}


// greater than average

//int[] arr = { 1, 2, 3, 4, 5 };
//int i;
//int sum = 0;
//int count = 0;
//for(i=0; i<arr.Length; i++)
//{
//    sum += arr[i];

//}

//int average=(sum/arr.Length);

//for (i = 0; i < arr.Length; i++)
//{
//    if (arr[i] > average)
//    {
//        count++;

//    }
//}

//Console.WriteLine(count);



// second largest number in array 

//int[] arr = { 1,2,3,3,3,3,33,4,5,44,55,12};
//Array.Sort(arr);
//int second_largest = arr[arr.Length - 2];
//Console.WriteLine(second_largest);




////count odd even 

//int[] arr = { 1, 2, 3, 4, 5,6 };
//int i;
//int even = 0;
//int odd = 0;
//for (i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 0)
//    {
//        even++;
//    }
//    else
//    {
//        odd++;
//    }
//}
//Console.WriteLine("number of even in array is " + even);
//Console.WriteLine("number of odd in array is " + odd);


// count duplicate number in the array

//int[] arr = { 1, 2, 3, 1,4, 5, 5, 3 };
//int i;
//int j;
//int count=0;
//for (i = 0; i < arr.Length; i++)
//{
//    for (j = 0; j < i; j++)
//    {
//        if (arr[i] == arr[j])
//    {



//        count++;
//        }
//    } 
//}

//Console.WriteLine(count);

// sorting

//int[] arr = { 11, 3, 41, 2, 5, 77 };
//int i;
//Array.Sort(arr);
//for(i=0;i<arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}

//pattern 

//int i;
//int j;
//for (i = 5; i >= 1; i--)
//{
//    for (j = 1; j < i; j++)
//    {
//        Console.Write(j);
//    }
//    Console.Write("\n");

//}



//find the sum of even and odd numbers in the array 
//int[] arr = { 1, 2, 3, 4, 5 };
//int i;
//int even = 0;
//int odd = 0;
//for (i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 0)
//    {
//        even += arr[i];

//    }
//    else
//    {
//        odd += arr[i];

//    }
//}
//Console.WriteLine("sum of even number " + even);
//Console.WriteLine("sum of odd number "+odd);








//int[] arr = { 5, 5, 5 };

//var arr1 = arr.Distinct().ToArray();
//Array.Sort(arr1);
//if (arr1.Length < 2)
//{
//    Console.WriteLine("there is no second largest ");

//}
//else
//{

//int second_largest = arr1[arr1.Length - 2];
//Console.WriteLine(second_largest);
//}


//int[] arr = { 1, 2, 3, 4, 3, 4, 5, 6, 7, 9, 6, 5 };
//var arr1 = arr.Distinct().ToArray();
//Array.Sort(arr1);
//if (arr1.Length < 2)
//{
//    Console.WriteLine("there is no second largest number ");

//}
//else
//{
//    int second_largest = arr1[arr1.Length - 2];
//    Console.WriteLine(second_largest);
//}



//int[] arr = { 1, 2, 3, 3, 4, 4, 5, 6, 7, 8 };
//int i;
//int j;
//int count = 0;

//for (i = 0; i < arr.Length; i++)
//{
//    for (j = 0; j < i; j++)
//    {
//        if (arr[i] == arr[j])
//        {
//            count++;

//        }
//    }
//}
//Console.WriteLine(count);


