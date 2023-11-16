using System;
using System.Xml;
using System.Xml.XPath;

string input1 = Console.ReadLine(); /*Räddningar, Mål, Skott*/
string[] rad1 = input1.Split(' ');
int[] lag1 = Array.ConvertAll(rad1, int.Parse);

string input2 = Console.ReadLine();
string[] rad2 = input2.Split(' ');
int[] lag2 = Array.ConvertAll(rad2, int.Parse);

int[] stats = lag1.Concat(lag2).ToArray();

while(stats[0] == -1 || stats[1] == -1 || stats[2] == -1 || stats[3] == -1 || stats[4] == -1 || stats[5] == -1)
{
    if(stats[0] == -1 && (stats[4] != -1 && stats[5] != -1)){int result = Math.Abs(stats[4] - stats[5]); stats[0] = result;}
    if(stats[1] == -1 && (stats[2] != -1 && stats[3] != -1)){int result = Math.Abs(stats[2] - stats[3]); stats[1] = result;} /*Rätt*/
    if(stats[2] == -1 && (stats[3] != -1 && stats[1] != -1)){int result = Math.Abs(stats[1] + stats[3]); stats[2] = result;} /*Rätt*/
    if(stats[3] == -1 && (stats[2] != -1 && stats[1] != -1)){int result = Math.Abs(stats[2] - stats[1]); stats[3] = result;} /*Rätt*/
    if(stats[4] == -1 && (stats[5] != -1 && stats[0] != -1)){int result = Math.Abs(stats[0] - stats[5]); stats[4] = result;}
    if(stats[5] == -1 && (stats[0] != -1 && stats[4] != -1)){int result = Math.Abs(stats[4] + stats[0]); stats[5] = result;} /*Rätt*/
}
    
Console.WriteLine($"{stats[0]} {stats[1]} {stats[2]}\n{stats[3]} {stats[4]} {stats[5]}");

/*NOPE*/