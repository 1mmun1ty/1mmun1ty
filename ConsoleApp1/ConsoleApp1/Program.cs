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


Random rnd = new Random();
float hpplayer = 100;
float hpenemy = 100;
float dmgplayer = rnd.Next(10, 15);
float dmgenemy = rnd.Next(1, 15);
float defplayer = 2;
float defenemy = 4;
float dmggivehero = dmgenemy/defplayer;
float dmggiveenemy = dmgplayer/defenemy;
while (hpplayer > 0 && hpenemy > 0)  // цикл будет работать, пока оба персонажа не погибнут
{
    hpplayer -= dmggiveenemy;
    hpenemy -= dmggivehero;
    dmgplayer = rnd.Next(10, 15);
    dmgenemy = rnd.Next(1, 15);
    dmggivehero = dmgenemy / defplayer;
    dmggiveenemy = dmgplayer / defenemy;
    Console.WriteLine("У игрока осталось: " + hpplayer);
    Console.WriteLine("У врага осталось: " + hpenemy);
}

// после того, как один из персонажей погибнет, цикл завершится
/*if (hpplayer <= 0)
{
    Console.WriteLine("Враг победил!");
}
else
{
    Console.WriteLine("Вы победили врага!");
}*/
float tphp = hpplayer - dmggivehero;
float tpenemy = hpenemy - dmggiveenemy;
Console.WriteLine("У игрока осталось: " + tphp);
Console.WriteLine("У врага осталось: " + tpenemy);


