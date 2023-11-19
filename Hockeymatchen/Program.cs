using System;

string[] input1 = Console.ReadLine().Split(' ');    //Räddningar, Mål, Skott
int[] lag1 = Array.ConvertAll(input1, int.Parse);   //0, 1, 2

string[] input2 = Console.ReadLine().Split(' ');
int[] lag2 = Array.ConvertAll(input2, int.Parse);


//Om ett lag gjorde inga skott, så gjorde de inga mål
if(lag1[2] == 0){lag1[1] = 0;} 
if(lag2[2] == 0){lag2[1] = 0;}


if(lag1[0] == -1 && (lag2[1] != -1 && lag2[2] != -1)){int result = Math.Abs(lag2[2] - lag2[1]); lag1[0] = result;} // ena lagets räddningar är lika med skillnaden mellan det andra lagets mål och skott
if(lag1[1] == -1 && (lag1[2] != -1 && lag2[0] != -1)){int result = Math.Abs(lag1[2] - lag2[0]); lag1[1] = result;} // ena lagets mål är lika med skillnaden mellan ena lagets skott och andra lagets räddningar
if(lag1[2] == -1 && (lag2[0] != -1 && lag1[1] != -1)){int result = Math.Abs(lag1[1] + lag2[0]); lag1[2] = result;} // ena lagets skott är lika med summa av ena lagets mål och andra lagets räddningar

if(lag2[0] == -1 && (lag1[2] != -1 && lag1[1] != -1)){int result = Math.Abs(lag1[2] - lag1[1]); lag2[0] = result;} 
if(lag2[1] == -1 && (lag2[2] != -1 && lag1[0] != -1)){int result = Math.Abs(lag2[2] - lag1[0]); lag2[1] = result;}
if(lag2[2] == -1 && (lag1[0] != -1 && lag2[1] != -1)){int result = Math.Abs(lag2[1] + lag1[0]); lag2[2] = result;} 



Console.WriteLine($"{lag1[0]} {lag1[1]} {lag1[2]}\n{lag2[0]} {lag2[1]} {lag2[2]}");