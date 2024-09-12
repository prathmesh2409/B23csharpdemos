int a = 10, b = 2;
Console.WriteLine($"addition :{a+b}");
Console.WriteLine($"substraction :{a - b}");
Console.WriteLine($"multiplication:{a * b}");
Console.WriteLine($"division:{a /b}");
Console.WriteLine($"reaminder {a & b}");



int c = a;
Console.WriteLine($"c: {c}");
//c = c + 1;
c++;
Console.WriteLine($"c: {c}"); //11
//Console.WriteLine($"c++: {c++}");  //11   //post incriment
Console.WriteLine($"++c: {++c}");  //12   // pre incriment


//c = c + 1;
c += 10;  //22

c *= 2; //44
Console.WriteLine($"c: {c}");


Console.WriteLine($"a:{a}b:{b} c:{c}");
bool result= a== b;
Console.WriteLine($"a==b:{result}");

result = a != b;
Console.WriteLine($"a!=b:{result}");

 result = a <=b;
Console.WriteLine($"a <= b:{result}");

result = a == b && a < c;
Console.WriteLine($"a == b && a < c:{result}");

result = a == b || a < c;
Console.WriteLine($"a == b || a < c:{result}");





Console.ReadLine();