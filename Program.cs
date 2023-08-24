
// Math

//double a = 10.4;
//double b = Math.Sqrt(a);
//Console.WriteLine(a);

//Console.WriteLine(Math.Round(4.99));

//Console.WriteLine(Math.Sqrt(64));
//Console.WriteLine(Math.Cos(4));


/*============================================**/

// Display Variable

string name = "topu";
Console.WriteLine(name + " Bhuyan");

int x = 5, y = 6, z = 7;
Console.WriteLine(x + y + z);

Console.WriteLine("********************");
// Indentifiers 

int minutesperHour = 60;
int m = 60;
Console.WriteLine(minutesperHour);
Console.WriteLine(m);

Console.WriteLine("********************");
// Data Type

int myNum = 10000;
Console.WriteLine(myNum);

float myNum1 = 5.75F;
Console.WriteLine(myNum1);

double myNum2 = 19.33;
Console.WriteLine(myNum2);

Console.WriteLine("============================================");
// Type Casting

Console.WriteLine("Type Casting");
int myInt = 9;
double myDouble = myInt;
Console.WriteLine(myInt);
Console.WriteLine("**************");

double myDouble1 = 10.78;
int myInt1 = (int)myDouble;
Console.WriteLine(myDouble);
Console.WriteLine(myInt1);
Console.WriteLine("**************");

int myInt3 = 10;
double myDoubl3 = 5.25;
bool myBool = true;

Console.WriteLine(Convert.ToString(myInt3));
Console.WriteLine(Convert.ToString(myDoubl3));
Console.WriteLine(Convert.ToString(myBool));

Console.WriteLine("============================================");
Console.WriteLine("Uset Input");

//Console.WriteLine("Enter UserName");
//string UserName = Console.ReadLine();
//Console.WriteLine("UserName is : " + UserName);
//Console.WriteLine("**************");


//Console.WriteLine("Enter Your age: ");
//double d = new double();
//int  Age = Console.ReadLine();  
//Console.WriteLine("Your age is: " + d);
Console.WriteLine("============================================");
Console.WriteLine("Boolen Expreash");

int myAge = 25;
int votingAge = 18;
Console.WriteLine(myAge >= votingAge);
Console.WriteLine("**************");

int myAge1 = 25;
int votingAge1 = 18;

if(myAge1 <= votingAge1)
{
    Console.WriteLine("Old enough to vote ! ");
}
else
{
    Console.WriteLine("Not enough to vote !");
}
Console.WriteLine("**************");

int time = 20;
if (time < 18)
{
    Console.WriteLine("Good day ");
}
else
{
    Console.WriteLine("Good evening ");
}
Console.WriteLine("**************");

int time2 = 20;
if(time2 < 10)
{
    Console.WriteLine("Good Moring");
}
else if(time2 < 20)
{
    Console.WriteLine("Good evening");
}
else
{
    Console.WriteLine("Good bye");
}
Console.WriteLine("**************");

int day = 4;
switch(day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tusday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thusday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saterday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;

}
Console.WriteLine("**************");

int day1 = 4;
switch(day)
{
    case 6:
        Console.WriteLine("Today is saterday");
        break;
    case 7:
        Console.WriteLine("Today is sunday");
        break;
    default:
        Console.WriteLine("Loking forword to the weekend");
        break; 

}
Console.WriteLine("**************");

string[] cars = { "volvo", "BMW", "Mazda" };
foreach (string i in cars)
{
    Console.WriteLine(i);
}
Console.WriteLine("**************");
// Break 
Console.WriteLine("Break");

for (int i  = 0; i < 10; i++)
{
    if(i == 4)
    {
        break;
    }
    Console.WriteLine(i);
}

Console.WriteLine("Continue");
for (int j = 0; j < 4; j++)
{
    if (j == 4)
    {
        continue;
    }
    Console.WriteLine(j);
}
Console.WriteLine("________________");
int k = 0;
while(k < 10)
{
    if(k == 4)
    {
        k++;
        continue;
    }
    Console.WriteLine(k);
    k++;
}
Console.WriteLine("---------Array--------");

string[] Cars = { "volvo", "BMW", "Ford", "Mazda" };
Cars[0] = "Ope1";
Console.WriteLine(Cars[2]);
Console.WriteLine("_________");

string[] cars1;
cars1 = new string[] { "volvo", "BMW", "Ford", "Mazda" };

Console.WriteLine("---------Loop Through an Array--------");

string[] carS = { "volvo", "BMW", "Ford", "Mazda" };
for (int l = 0; l < carS.Length; l++)
{
    Console.WriteLine(carS[l]) ;
}
Console.WriteLine("_________");

string[] cars3 = { "volvo", "BMW", "Ford", "Mazda" };
foreach(string s  in cars3)
{
    Console.WriteLine(s);
}
Console.WriteLine("--------Sort Arrays---------");

string[] cars4 = { "volvo", "BMW", "Ford", "Mazda" };
Array.Sort(cars4);
foreach (string i in cars4)
{
    Console.WriteLine(i);
}
Console.WriteLine("_________");

int[] myNumbers = { 5, 1, 8, 9 };
Console.WriteLine(myNumbers.Max());
Console.WriteLine(myNumbers.Min());
Console.WriteLine(myNumbers.Sum());

Console.WriteLine("--------Multidimensional Arrays---------");

int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
numbers[0, 0] = 5;
Console.WriteLine(numbers[0,0]);
Console.WriteLine("_________");

int[,] numbers1 = { { 1, 4, 2 }, { 3, 6, 8 } };
for (int m1 = 0; m1 < numbers1.GetLength(0); m1++)
{
    for (int n = 0; n < numbers1.GetLength(1); n++) 
    {
        Console.WriteLine(numbers1[m1,n]);
    }
}

