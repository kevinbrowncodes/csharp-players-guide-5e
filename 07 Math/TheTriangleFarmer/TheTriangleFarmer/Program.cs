double areaTriangle;
int baseTriangle;
int heightTriangle;

Console.WriteLine("Enter triangle base: ");
baseTriangle = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter triangle height: ");
heightTriangle = Convert.ToInt32(Console.ReadLine());

areaTriangle = (baseTriangle * heightTriangle) / 2;

Console.WriteLine("The area of the triangle is " + areaTriangle);