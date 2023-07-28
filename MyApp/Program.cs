// See https://aka.ms/new-console-template for more information

// variable declaration with Interpolation
/*string aFriend = "Suyog";
Console.WriteLine($"Hello { aFriend}");
Console.ReadLine();*/


// String Methods

/* string firstFriend = "Irshad";
string lastFriend = "Ankit";
Console.WriteLine($"My Friends are {firstFriend} and {lastFriend}");
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters");
Console.WriteLine($"The name {lastFriend} has {lastFriend.Length} letters");*/


//Trim Method
/* string greeting = "     Hello World!    ";
Console.WriteLine($"[{greeting}]");
string trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]"); */


//Replace Method
/*string sayHello = "Hello World !";
Console.WriteLine(sayHello);

sayHello = sayHello.Replace("Hello", "Greetigs");
Console.WriteLine(sayHello);

//toUpperCase & toLowerCase
Console.WriteLine(sayHello.ToLower());
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello);*/


// contains Method (StartWith,EndsWith)

/* string songLyrics = "You say greeting, and I say hello";
var result = songLyrics.Contains("greeting");
Console.WriteLine(result);
Console.WriteLine(songLyrics.Contains("kendra"));
Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.EndsWith("and"));*/


// Number Methods & Assignment

/*int a = 10;
int b = 11;
int c = a + b;
Console.WriteLine(c);*/


//double

/*double d = 1.0 / 3.0;
Console.WriteLine(d);

decimal d2 = 1.0M;
decimal d3 = 3.0M;
Console.WriteLine(d2/d3);*/


//loops in C#

/*int a = 5;
int b = 3;
int c = 4;
if ((a + b + c > 10) || (a==b))
{
    Console.WriteLine("The ans is greater than 10");
    Console.WriteLine("The first number is equal to second");
}
else { Console.WriteLine("The ans is less than 10");
    Console.WriteLine("or The first number is not equal to second");
}*/


//While Loop

/*int counter = 0;
while (counter < 10)
{
    Console.WriteLine($"the counter is {counter}");
    counter++;
}*/

//For  Loop

/*for (int index = 0; index < 10; index++)
{
    Console.WriteLine($"The index is {index}");
    Console.ReadLine();
}*/


/*int sum = 0;
for (int i = 1; i<= 20; i++)
{
    if (i % 3 == 0)
    {
        sum = sum + 1;
    }
}
Console.WriteLine($"THE SUM IS {sum}");*/


// Array ,List,Collections

/*var names = new List<string>{"suyog","harshu","ojasvi"};
names.Add("Sam");
names.Add("Ram");
//names.Remove("harshu");
foreach (string name in names)
{
    Console.WriteLine($" hello {name}");
  
}
Console.WriteLine(names[1]);*/

//IndexOf Method
/*var index = names.IndexOf("ojasvi");
Console.WriteLine($"found index at {index}");*/



//











