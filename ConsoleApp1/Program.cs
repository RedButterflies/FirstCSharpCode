
string name = "Jake";
string lastName = "Kwiatkowski";
string fullName = "Jakob Kwiatkowski";
Console.WriteLine(name +" " + lastName);
Console.WriteLine(fullName);

int a = 5;
int b = 6;
Console.WriteLine("wynik: ");
Console.WriteLine(a + b);
int c = 90;
int d = 70;
int x = 600;
Console.WriteLine("wynik c+d+x: ");
Console.WriteLine(c + d + x);
int e, y, f;
e= y = f = 60;
Console.WriteLine("wynik dodawania e+y+f: ");
Console.WriteLine(e + y + f);
double doubleVariable = 3.3D;
float floatVariable = 6.6F;
bool boolVariable = true;
char charVariable = 'A';
Console.WriteLine(doubleVariable);
Console.WriteLine(floatVariable);
Console.WriteLine(boolVariable);
Console.WriteLine(charVariable);

int var1 = 7;
Console.WriteLine(var1);
float var2 = var1;
Console.WriteLine(var2);
double var3 = var2;
Console.WriteLine(var3);

double var4 = 66.8;
int var5 = (int)var4;
Console.WriteLine(var4);
Console.WriteLine(var5);

int varInt = 9;
double varDouble = 8.89;
bool varBool = true;

Console.WriteLine(Convert.ToString(varInt));
Console.WriteLine(Convert.ToDouble(varInt));
Console.WriteLine(Convert.ToInt32(varDouble));
Console.WriteLine(Convert.ToString(varBool));


Console.WriteLine("Input some facts about yourself: ");
Console.WriteLine("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your name: ");
string namee = Convert.ToString(Console.ReadLine());
Console.WriteLine("Enter your last name: ");
string lastNamee =Convert.ToString(Console.ReadLine());
Console.WriteLine("Enter your height: ");
float height = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter the name of your favourite animal: ");
string animal = Convert.ToString(Console.ReadLine());
Console.WriteLine("Enter the name of your favourite colour: ");
string favColour = Convert.ToString(Console.ReadLine());
Console.WriteLine("Enter your favourite letter: ");
char favLetter = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Facts about you: ");
Console.WriteLine("Your first name: " + namee);
Console.WriteLine("Your last name: " + lastNamee);
Console.WriteLine("Your age: " + age);
Console.WriteLine("Your height: " + height);
Console.WriteLine("Your favourite animal: " + animal);
Console.WriteLine("Your favourite colour: " + favColour);
Console.WriteLine("Your favourite letter: " + favLetter);


//Arithmetic Operations
Console.WriteLine("Enter value 1: ");
int q = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value 2: ");
int t = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value 3: ");
int s= Convert.ToInt32(Console.ReadLine());

int addition = q + t + s;
Console.WriteLine("Addition result: " + addition);

int substraction = q - t;
Console.WriteLine("Substraction result: " + substraction);

int multiplication = q * t * s;
Console.WriteLine("Multiplication result: " + multiplication);

float division = (float)q / t;
Console.WriteLine("Division result: " + division);

int modulo = q % t;
Console.WriteLine(modulo);

Console.WriteLine(++q);

Console.WriteLine(--t);



