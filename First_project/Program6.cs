using System;
using System.Collections;

ArrayList a = new ArrayList();
a.Add("hello");
a.Add("bye");
a.Add("Apple");
a.Add("Samsung");

Console.WriteLine(a[1]);

foreach(String item in a)
{
    Console.WriteLine(item);
}

Console.WriteLine (a.Contains("hello"));