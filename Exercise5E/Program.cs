Console.WriteLine("This program will show degrees in Celsius converted to Farenheit\n");

Console.Write("Enter the degree value in celsius: ");
double c = Convert.ToInt32(Console.ReadLine());

while(c < -271.15)
{
    Console.Write("\nPlease enter a value above the absolute zero (271.15): ");
    c = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("=======  \t ==========");
Console.WriteLine("Celsius  \t Fahrenheit");
Console.WriteLine("=======  \t ==========");

Console.WriteLine("  " + c + "\t\t   " + CelsiustoFarenheit(c));


static double  CelsiustoFarenheit(double celsius)
{
   return celsius * 9.0 / 5.0 + 32;
    
}







