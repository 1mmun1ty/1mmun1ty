// See https://aka.ms/new-console-template for more information

using System.Security.AccessControl;
using System.Threading.Channels;

string a = "Hello";
string b = " Wolrd!";
string c = a+ b;
Console.WriteLine(c);

double first = 5;
double second = 7;
double third = 10;
double plus = first + second + third;
Double minus = third - second - third;
Double delenie = third/second/first;
double ymnozenie = first*second*third;
Console.WriteLine(plus);
Console.WriteLine(minus);
Console.WriteLine(delenie);
Console.WriteLine(ymnozenie);
 
Console.WriteLine("Введите ваше имя:");
string name = Console.ReadLine();
Console.WriteLine("Введите вашу фамилию:");
string surname = Console.ReadLine();
Console.WriteLine("Введите ваше отчество:");
string otchestvo = Console.ReadLine();

Console.WriteLine(name + " " + surname + " " + otchestvo);



float hpplayer = 100;
float hpenemy = 100;
float dmgplayer = 7;
float dmgenemy = 4;
float defplayer = 2;
float defenemy = 4;
float dmggivehero = dmgenemy/defplayer;
float dmggiveenemy = dmgplayer/defenemy;
float tphp = hpplayer - dmggivehero;
float tpenemy = hpenemy - dmggiveenemy;
Console.WriteLine("У игрока осталось: " + tphp);
Console.WriteLine("У врага осталось: " + tpenemy);


