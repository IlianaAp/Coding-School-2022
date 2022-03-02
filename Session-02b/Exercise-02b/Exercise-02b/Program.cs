// See https://aka.ms/new-console-template for more information


// 1.
Console.WriteLine("Hello Iliana");

// 2.

int num1 = 5;
int num2 = 6;

int sum = num1 + num2;
float division = (float)num1 / num2;

Console.WriteLine($"The sum of the numbers {num1} and {num2} is {sum}");
Console.WriteLine($"The division of the numbers {num1} and {num2} is {division.ToString("n2")}");

// 3.

double answer;

answer = -1 + 5 * 6;
Console.WriteLine($"The first answser is : {answer}");

answer = 38 + 5 % 7;
Console.WriteLine($"The second answser is : {answer}");

answer = 14 + (-3 * 6) / (double)7;
Console.WriteLine($"The third answser is : {answer}");

answer = 2 + ((double)13 / 6 * 6) + Math.Sqrt(7);
Console.WriteLine($"The fourth answser is : {answer}");

answer = (double)(Math.Pow(6, 4) + Math.Pow(5, 7)) / (9 % 4);
Console.WriteLine($"The fifth answser is : {answer}");

// 4.
int age = 20;
string gender = "female";

Console.WriteLine($"You are {gender} and look younger than {age}");

// 5. 
int seconds = 123456789;
int minutes = 0;
int hours = 0;
int days = 0;
int years = 0;
int remainingSeconds = 0;

hours = seconds / 3600;
remainingSeconds = seconds - (hours * 3600);
minutes = remainingSeconds / 60;
remainingSeconds = remainingSeconds - (minutes * 60);
days = hours / 24;
hours = hours - (days * 24);
years = days / 365;
days = days - (years * 365);

Console.WriteLine($"{seconds} seconds is equal to {minutes} minutes, {hours} hours, {days} days and {years} years");

// 5.
minutes = seconds / 60;
hours = seconds / 3600;
days = hours / 24;
years = days / 365;

Console.WriteLine($"{seconds} seconds is equal to {minutes} minutes, {hours} hours, {days} days and {years} years");


// 6.

TimeSpan timeSpan = TimeSpan.FromSeconds(123456789);
Console.WriteLine($"{timeSpan.TotalSeconds} seconds is equal to {timeSpan.TotalMinutes} minutes, {timeSpan.TotalHours} hours, {timeSpan.Days} days and {timeSpan.Days / 365} years");

// 7.
double celsius = 36.6;
double kelvin = 0;
double fahrenheit = 0;

kelvin = celsius + 273.15;
fahrenheit = celsius * 1.8 + 32;

Console.WriteLine($"{celsius} celsius degrees is {kelvin.ToString("n2")} Kelvin and {fahrenheit.ToString("n2")} Farhrenheit");
