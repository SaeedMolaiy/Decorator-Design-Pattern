using Decorator.Models;

var c = new Repository();

var d1 = new DatabaseLogger();
var d2 = new Logger();

// Link decorators
d1.SetComponent(c);
d2.SetComponent(d1);

d1.Operation();
Console.WriteLine();
d2.Operation();

// Wait for user
Console.ReadKey();
