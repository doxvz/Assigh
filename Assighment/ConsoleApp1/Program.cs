Console.WriteLine("Enter the first number:");
int fN = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int sN = int.Parse(Console.ReadLine());
Console.WriteLine("Select opretor:");
String oP = Console.ReadLine();

if(oP == "+" || oP == "-" || oP == "" || oP == "/" )
{
    if(oP == "+")
    {
        Console.WriteLine("Result: " +fN+" + "+sN+" = "+(fN + sN));
    }
    else if(oP == "-")
    {
        Console.WriteLine("Result: " +fN+" - "+sN+" = "+(fN - sN));
    }
    else if(oP == "")
    {
        Console.WriteLine("Result: " +fN+" * "+sN+" = "+(fN * sN));
    }
    else if(oP == "/")
    {
        if(sN!=0)
        {
            Console.WriteLine("Result: " +fN+" / "+sN+" = "+(fN / sN));
        }   
        else
        {
            Console.WriteLine("Error! Division by zero is not allowed.");
        }
    }
    else
    {
        Console.WriteLine("Wrong operator! Please use '+', '-', '', or '/' only.");
    }

}

else{
    Console.WriteLine("Wrong operator! Please use '+', '-', '', or '/' only.");
}
