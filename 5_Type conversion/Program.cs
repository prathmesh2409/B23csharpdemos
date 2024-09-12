int i= 10;
Console.WriteLine($"i:{i}");


float f = 325.45f;
Console.WriteLine($"f:{f}");

f = i;  //int=> float
Console.WriteLine($"f:{f}");


//--------------type casting method---------------------------/
f  = 325.45f;
i =(int) f;  //float=>int
Console.WriteLine($"i:{i}");

//--------------------------end typecast method---------------------------------

byte b = 10;
i = b;      //byte=int
Console.WriteLine($"i:{i}");

string s = "777";
//i =s    // string=>int
i =Convert.ToInt32(s);  // string=>int
Console.WriteLine($"i:{i}");//777

short s1 = Convert.ToInt16(s);
Console.WriteLine($"s1:{s1}");

i = int.Parse(s);
Console.WriteLine($"i:{i}");
s = "2000";
bool stutes = int.TryParse(s, out i);
Console.WriteLine($"converstion stutes:{stutes} i:{i}");


object o = 10;  //int
o = true;//bool
o = '$';//char
o = "prathmesh";//string

int i1 = 10;
object o1 = i1;  //int=>object// boxing
Console.WriteLine($"o1:{o1}");

int i2 = (int) o1;//onject =>int //unboxing
Console.WriteLine($"i2:{i2}");

Console.ReadLine();