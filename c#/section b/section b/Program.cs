

Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());

int reversed = 0;
int temp = num;

while (temp != 0)
{
    int digit = temp % 10;          
    reversed = reversed * 10 + digit; 
    temp /= 10;                     
}

Console.WriteLine($"Reversed: {reversed}");
