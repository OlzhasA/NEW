using System;

//arrays

String[] a = { "First", "Second", "Third", "Fourth" };
int[] b = {1,2,3,4,5};

String[] c = new String[4];
c[0] = "One";
c[1] = "Two";
c[2] = "Three";

Console.WriteLine(b[0]);

for (int i = 0; i < a.Length; i++)
{
    Console.WriteLine(a[i]);
    if (i == 1) 
    {
        Console.WriteLine("Match is found");
        break;
    }
    
}
