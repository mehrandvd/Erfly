#r "System.Linq"
#r "Erfly.App"

using System;
using System.Linq;
using Erfly.App;

Console.WriteLine("I'm alive here...");

var numbers = new int[] {1, 2, 3, 4, 5};
var sum = numbers.Sum();

if (sum > Treshold - 7)
    throw new TresholdException($"Numbers are much more than Treshold ({Treshold})!");

Console.WriteLine($"The sum is: {sum}");