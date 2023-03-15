using System;
using System.Reflection.Metadata;
using ПЗ_5;

var Tom = new Cat("Tom", 3, Paroda.Britanskaya);

Console.WriteLine(Tom.ToString());

var Bob = Tom;
Bob.NAME = "Bob";

Console.WriteLine(Tom.ToString());
Console.WriteLine(Bob.ToString());



var Beta = new Cat("Beta", 3, Paroda.Sfinks);
var Barsik = (Cat)Beta.Clone();

Barsik.NAME = "Barsik";

Console.WriteLine(Beta.ToString());
Console.WriteLine(Barsik.ToString());

