// See https://aka.ms/new-console-template for more information
int a = 3;
int b = a++;
Console.WriteLine($"a is {a}, b is {b}");

#region Exploring unary operators
int c = 3;
int d = ++c;
//prefix means incerement c before assigning it.
Console.WriteLine($"c is {c}, d is {d}");
#endregion

#region Exploring binary operators
int e = 11;
int f = 3;
Console.WriteLine($"e is{e}, f is {f}");
Console.WriteLine($"e + f = {e + f}");
Console.WriteLine($"e - f = {e - f}");
Console.WriteLine($"e * f = {e *f}");
Console.WriteLine($"e / f = {e / f}");
Console.WriteLine($"e % f = {e % f}");
double g = 11.0;
Console.WriteLine($"g is {g:N1},f is{f}");
Console.WriteLine($"g / f = {g / f}");
#endregion

#region Exploring Assigning operators
int p = 6;
p += 3; // Equivalent to: p = p + 3;
p -= 3; // Equivalent to: p = p - 3;
p *= 3; // Equivalent to: p = p * 3;
p /= 3; // Equivalent to: p = p / 3;
#endregion

#region Exploring null operators 
string? authorname = Console.ReadLine();
//Prompt user to enetr an author name.
//The maxlength variable will be lenght of authorname if it is.
// not null, or 30 if authorName is null. 
int maxLenght = authorname?.Length ?? 30;
// The authorname variable will be "unknown" if authorname was null.
authorname ??= "unknown";
#endregion

#region Exploring Logic operators
bool p = true;
bool q = false;
Console.WriteLine($"AND | P |  q |");
Console.WriteLine($"p | {p $ p, -5} | {p & q,-5}");