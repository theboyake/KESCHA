// int a=1;
// int b=2;
// int c=a+b;
// System.Console.WriteLine(c);



// int a, b, sum;
// System.Console.Write("Enter the first number >>> ");
// a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter the second number >>> ");
// b = Convert.ToInt32(Console.ReadLine());
// sum = a + b;
// System.Console.WriteLine("{0} ga {1} ni qoshsa {2} bo'ladi", a, b, sum);




// System.Console.WriteLine(sizeof(char));
// char smallA = 'a';
// char capitalA = 'A';

// System.Console.WriteLine((int)smallA);
// System.Console.WriteLine((int)capitalA);

// System.Console.WriteLine(long.MaxValue);
// System.Console.WriteLine(decimal.MaxValue);




// System.Console.Write("Enter your name >>> ");
// string name = Console.ReadLine();
// string greeting = $"Hello {name}";
// System.Console.WriteLine(greeting);


System.Console.Write("Enter your age >>> ");
string ageAsString = Console.ReadLine();
System.Console.WriteLine("Converting ...");
int age = Convert.ToInt32(ageAsString);
System.Console.WriteLine($"Succesfully converted {age}");

int keschaAge = 3;
int ageDifference = age - keschaAge;
System.Console.WriteLine($"The difference between your and Kescha's age {ageDifference}");