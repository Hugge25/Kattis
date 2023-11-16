using System;

int a = 7;
int p = 13;

string solda = Console.ReadLine();
string[] frukter = solda.Split(' ');

int[] totalt = Array.ConvertAll(frukter, int.Parse);
int Axel = totalt[0]*a;
int Petra = totalt[1]*p;

if(Axel == Petra)
    Console.WriteLine("lika");
    
else if(Axel > Petra)
    Console.WriteLine("Axel");
    
else
    Console.WriteLine("Petra");