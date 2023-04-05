int estatePoint = 1;
int duchyPoint = 3;
int provincePoint = 6;
int estateNum;
int duchyNum;
int provinceNum;
int total;

Console.WriteLine("Number of estates: ");
estateNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Number of duchies: ");
duchyNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Number of provinces: ");
provinceNum = Convert.ToInt32(Console.ReadLine());

total = (estatePoint * estateNum) + (duchyPoint * duchyNum) + (provincePoint * provinceNum);

Console.WriteLine("Total: " + total);

