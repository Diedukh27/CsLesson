//------------------------------------------------------------------------------------

//Console.WriteLine("Enter rating: ");
//double rating1 = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter rating: ");
//double rating2 = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter rating: ");
//double rating3 = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter rating: ");
//double rating4 = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter rating: ");
//double rating5 = double.Parse(Console.ReadLine());

//double rating = (rating1 + rating2 + rating3 + rating4 + rating5) / 5;
//Console.WriteLine("Result: " + rating);
//------------------------------------------------------------------------------------


//Console.WriteLine("Enter dagrees:");
//double dargees = double.Parse(Console.ReadLine());
//double fahrenheit = dargees * 9 / 5 + 32;
//Console.Write($"Result:  " + fahrenheit);
//------------------------------------------------------------------------------------

//Console.WriteLine("Enter the revolutions of Mars around the Sun:");
//double around = double.Parse(Console.ReadLine());
//const int days = 686;
//double Marsdays = around * days;
//Console.WriteLine("Result: " + Marsdays);
//------------------------------------------------------------------------------------
//Console.Write("Enter age: ");
//int age = int.Parse(Console.ReadLine());

//if (age >= 15 && age <= 55)
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine("you can study ");
//    Console.ResetColor();

//}
//else
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine(" you not study ");
//    Console.ResetColor();
//}



Console.Write("Enter price; ");

double price = double.Parse(Console.ReadLine());

if ( price >=1000 && price <= 5000)
{
    Console.WriteLine("discount 10% ");

    double  price1 = price -  price  * (10 / 100.0);
    Console.WriteLine($"result: {price1} ");
}
else
{
    Console.ForegroundColor= ConsoleColor.Red;
    Console.WriteLine("not discount: ");
    Console.ResetColor();

}
if (price >= 5000)
{
    Console.WriteLine("discount 25% ");

    double price1 = price - price * (25 / 250.0);
    Console.WriteLine($"result: {price1} ");
}






