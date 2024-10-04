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



//Console.Write("Enter price; ");

//double price = double.Parse(Console.ReadLine());

//if ( price >=1000 && price <= 5000)
//{
//    Console.WriteLine("discount 10% ");

//    double  price1 = price -  price  * (10 / 100.0);
//    Console.WriteLine($"result: {price1} ");
//}
//else
//{
//    Console.ForegroundColor= ConsoleColor.Red;
//    Console.WriteLine("not discount: ");
//    Console.ResetColor();

//}
//if (price >= 5000)
//{
//    Console.WriteLine("discount 25% ");

//    double price1 = price - price * (25 / 250.0);
//    Console.WriteLine($"result: {price1} ");
//}




//Console.WriteLine("Enter your Email");
//string Email = Console.ReadLine();

//if (Email.Contains("@") && Email.Contains("."))
//{

//     Console.WriteLine("Good Email");

//}
//else
//{
//    Console.WriteLine("No Good Email");
//}


//Console.WriteLine("Enter your name: ");
//string name = Console.ReadLine();

//if (name.Length > 1)
//{
//    Console.WriteLine("good");
//}
//else
//{
//    Console.WriteLine("No Good");
//}

//Console.WriteLine("Enter sentances");
//string sentances = Console.ReadLine();

//if ( sentances.Length >= 20 )
//{

//   var a1 =  sentances.Replace('.', '!');

//    Console.WriteLine($"Your sentences: {a1} ");

//}
//if (sentances.Length <= 20)
//{
//    var a2 = sentances.Replace('.', '/');
//    Console.WriteLine($"Your sentences: {a2} ");

//}



//Console.WriteLine("Enter your rating");
//int rating = int.Parse(Console.ReadLine());

//if (rating >=1 && rating <=3)
//{
//    Console.WriteLine("no good rating");

//}
//if (rating >=4 && rating <= 8)
//{
//    Console.WriteLine("good rating");
//}
//if (rating >=9 && rating <= 12)
//{
//    Console.WriteLine("Perfect rating");

//}


//Console.WriteLine("Enter carency 1USD 2EURO 3PLN ");
//int carency = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter GRN ");
//int GRN = int.Parse(Console.ReadLine());    

//switch (carency)
//{
//   case 1 : Console.WriteLine($"Result: {GRN / 41,14} "); break;
//   case 2 : Console.WriteLine($" Result: {GRN / 46}  "); break;
//   case 3 : Console.WriteLine($"Result: {GRN / 10,74}"); break;
//   default: Console.WriteLine("NO"); break;
//}



//Console.Write("Enter line length: ");
//int number = int.Parse(Console.ReadLine());

//for (int count = 0; count < number; count++)
//{

//    Console.Write("#");

//}



//Console.WriteLine("Enter number");
//int number1 = int.Parse(Console.ReadLine());


//Console.Write("Enter line symbol:");
//string symbol1 = (Console.ReadLine());

//for (int count = 0; count < number1; count++)
//{
//    Console.Write($"{symbol1}");
//}




Console.Write("Enter number1: ");
int startone= int.Parse(Console.ReadLine());

Console.Write("Enter number2: ");
int startend = int.Parse(Console.ReadLine());

for (int count = startone; count <= startend; count++)
{
    Console.Write($" {count}");
}
















    


   











