using System;
using System.Linq.Expressions;
using System.Net.Sockets;

int result = 0;

int r = 0;
int l = 0;

string[] input1 = Console.ReadLine().Split(' ');
string[] input2 = Console.ReadLine().Split(' ');

int[] Input1 = Array.ConvertAll(input1, int.Parse); //9 18               ||
int[] tomter = Array.ConvertAll(input2, int.Parse); //1 5 3 4 6 2 1 2 4  ||  6
int antal = Input1[0];
int budget = Input1[1];
int loop = (antal-1)*2;



for(int i = 0; i < loop; i++)
    {
           
    }

if(result <= budget)
{
    
    
}
else if(result > budget)
{
    for(int i = 0; i < antal; i++)
    {
        result -= tomter[i];   
    }
    
}


    



