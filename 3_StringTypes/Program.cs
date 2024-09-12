string name = "Prathmesh";
Console.WriteLine(name);
Console.WriteLine(name.ToUpper());
Console.WriteLine(name.ToLower());

name = "         Prathmesh";
Console.WriteLine(name);
Console.WriteLine(name.Trim());

name = "Prathmesh";

Console.WriteLine(name);
Console.WriteLine(name.TrimStart());
Console.WriteLine(name.TrimEnd());


name = "SHREE DUNAKHE";
Console.WriteLine(name);
Console.WriteLine(name.Replace("SHREE" ,"PRATHMESH"));

name= "\"PRATHMESH \"";
Console.WriteLine(name);

name="\\PRATHMESH\\";
Console.WriteLine(name);

name = "'PRATHMESH'";
Console.WriteLine(name);

string para = "This is 1st sentence \nThis is 2nd sentence";
Console.WriteLine(para);

para = "this is 1st sentence\tthis is 2nd sentence";
Console.WriteLine(para);

string path= @"C:\Users\admin\source\repos\B23csharpdemos";
Console.WriteLine(path);


string firstname = "PRATHMESH" ,lastname = "DUNAKHE";
string fullname = firstname + lastname;
Console.WriteLine(fullname);

fullname = firstname +" "+ lastname;
Console.WriteLine(fullname);

string .Concat(firstname," ", lastname);
Console.WriteLine(fullname);

fullname= string.Join(',', firstname, lastname);
Console.WriteLine(fullname);

fullname = "fullname=" + firstname + " " + lastname;
Console.WriteLine(fullname);    //fullname= prathmesh dunakhe

fullname = string.Format("fullname :{0}{1}", firstname,lastname);
Console.WriteLine(fullname);

fullname = "$fullname={firstname},{lastname}";
Console.WriteLine(fullname);


Console.WriteLine("please enter your email");
string email = Console.ReadLine();



int index = email.IndexOf('@');
string username = email.Substring(0, index);
string Domain = email.Substring(index + 1, email.Length - (index + 1));
Console.WriteLine($"  Username : {username} Domain : {Domain}");








Console.ReadLine();