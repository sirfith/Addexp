// See https://aka.ms/new-console-template for more information
using System.Globalization;
//Console.WriteLine("Hello, World!");
int[] incarray = { 034000, 47000, 65000, 93000, 130000, 190700, 250000, 366000, 500000, 725000 },
lvlarray = { 3430000, 4800000, 6830000, 9570000, 13600000, 18900000, 27200000, 38200000, 54600000, 76600000 };
int xp = 2400000,j = 0 ,lvl = 20, max = 310;
for (int i = 0; i < max; i++)
{
    xp = xp + incarray[j];
    j++;
    if (j > 9)
    { j = 0; }
    for (int k = 0; k < 10; k++)
    {
        if (xp > lvlarray[k])
        { lvl = 21 + k; }
        else
            break;
    }
    // Console.WriteLine("xp: {0}  lvl: {1}",xp,lvl);
    // Console.WriteLine(xp);
     Console.WriteLine("{0} {1}",lvl,xp);
   // Console.WriteLine(lvl);
}
