using System.Runtime.CompilerServices;

int i = 1;
object o = i;
Console.WriteLine(object.ReferenceEquals(o, i));
Console.WriteLine(o.Equals(i));