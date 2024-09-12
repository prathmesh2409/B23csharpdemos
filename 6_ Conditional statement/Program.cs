#region if statement
/*Console.WriteLine("Please enter a number");
int i = int.Parse(Console.ReadLine());
if (i == 10) 
{
    Console.WriteLine($"{i}:TEN");
}

else if (i == 20)
{
    Console.WriteLine($"{i}:Twenty");
}
else if (i == 30)
{
    Console.WriteLine($"{i}:Thrity");
}
else if (i == 40)
{
    Console.WriteLine($"{i}:Fourty");
}
else if (i == 50)
{
    Console.WriteLine($"{i}:fifty");
}
else if (i == 60)
{
    Console.WriteLine($"{i}:sixty");
}
else if (i == 70)
{
    Console.WriteLine($"{i}:seventy");
}
else if (i == 80)
{
    Console.WriteLine($"{i}:eighty");
}
else if (i == 90)
{
    Console.WriteLine($"{i}:ninety");
}
else if (i == 100)
{
    Console.WriteLine($"{i}:hundred");
}

else
{
    Console.WriteLine($"{i}:NOT 10 20 30 40 50 60 70 80 90 100");
}*/



#endregion if statement




//#region Ternary Opretors
//Console.WriteLine("Please enter a number");
//int i = int.Parse(Console.ReadLine());

//(condition) ? "statement 1" : "statement 2"

//string result = (i == 10) ? " TEN" : "NOT TEN";
//Console.WriteLine($"{i}:{result}");


//#endregion Ternary Opretors


//#region switch statement

//Console.WriteLine("Please enter a number");
//int i = int.Parse(Console.ReadLine());
//switch (i)
//{

//    case 10:
//    Console.WriteLine($"{i}: TEN");
//break;
//    case 20:
//    Console.WriteLine($"{i}: TWENTY");
//    break;
//case 30:
//    Console.WriteLine($"{i}: THIRTY");
//    break;
//default:
//    Console.WriteLine($"{i}:  NOT 10 20 30");
//    break;


//}
//#endregion switch statement 

#region switch statement

Console.WriteLine("plese enter your order stutes");
string stutes = Console.ReadLine().ToUpper();

switch (stutes)
{

    case "PLACED":
        Console.WriteLine("Your order is placed succesfully");
        break;
    case "DISPATCHED":
        Console.WriteLine("Your order is on the way ");
        break;
    case "DELIVERD":
        Console.WriteLine("Your order is deliverd to receptionist");
        break;
    case "CANCELLED":
        Console.WriteLine("Your order is cancelled succesfully");
        break;
    default:
        Console.WriteLine("invalid order stutes ");
        break;
}

#endregion switch statement

Console.ReadLine();