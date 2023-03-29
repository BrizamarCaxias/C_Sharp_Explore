// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//In C#  values of that is not references is not possible to be null so we using Nullable

Nullable<double> x; // is the same that double? x;
Nullable<double> y; // is the same that double? y;
x = null;
y = 10.0;

//Method of Nullable
Console.WriteLine(x.GetValueOrDefault());
Console.WriteLine(y.GetValueOrDefault());

Console.WriteLine(x.HasValue);
Console.WriteLine(y.HasValue);

//Console.WriteLine(x.Value);
Console.WriteLine(y.Value);
//Oprator 
double h = x ?? 0.0