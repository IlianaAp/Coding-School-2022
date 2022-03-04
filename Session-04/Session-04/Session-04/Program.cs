// See https://aka.ms/new-console-template for more information
using Session_04;


//1.
var c1 = new Class1();
string myName = "iliana apostolidou";
string reversedName = c1.ReverseName(myName);
Console.WriteLine($"{myName} in reverse is {reversedName}");
Console.WriteLine(" ");

//2.
Console.WriteLine("Type a number ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Type 1 for sum or 2 for product of 1..{number}:");
int choice = Convert.ToInt32(Console.ReadLine());

var c2 = new Class2();
int answer;
if (choice == 1)
{
    answer = c2.Sum(number);
    Console.WriteLine($"The sum is {answer}");
}
else if (choice == 2)
{
    answer = c2.Product(number);
    Console.WriteLine($"The product is {answer}");
}
else
{
    Console.WriteLine("Invalid choice");
}
Console.WriteLine(" ");

//3.
Console.WriteLine("Type a number  ");
number = Convert.ToInt32(Console.ReadLine());
var c3 = new Class3();
Console.Write("The prime numbers are : ");
c3.PrimeNumbers(number);
Console.WriteLine(" ");
Console.WriteLine(" ");


//4.
var array1 = new int[] { 2, 4, 9, 12 };
var array2 = new int[] { 1, 3, 7, 10 };
var c4 = new Class4();
var arrayResults = c4.MultiplyTwoArrays(array1, array2);
for (int i = 0; i < arrayResults.Length; i++)
{
    Console.Write(arrayResults[i] + " ");
}
Console.WriteLine(" ");
Console.WriteLine(" ");

//5.
var array3 = new int[] { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
var c5 = new Class5();
var array4 = c5.SortLowToHigh(array3);
for (int i = 0; i < array4.Length; i++)
{
    Console.Write(array4[i] + " ");
}
