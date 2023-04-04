/* Types */
//  1.  byte
//  2.  short
//  3.  int
//  4.  long
//  5.  sbyte
//  6.  ushort
//  7.  uint
//  8.  ulong
//  9.  char
//  10. string
//  11. float
//  12. double
//  13. decimal
//  14. bool

byte byteNum = 255;
short shortNum = 32_767;
int intNum = 2_147_483_647;
long longNum = 9_223_372_036_854_775_807;
sbyte sbyteNum = 127;
ushort ushortNum = 65_535;
uint uintNum = 4_294_967_295;
ulong ulongNum = 18_446_744_073_709_551_615;
char charText = 'a';
string stringText = "alpha";
float floatNum = 3.4e38F;
double doubleNum = 1.7e308;
decimal decimalNum = 7.9e28M;
bool boolText = true;

byteNum = 0;
shortNum = -32_768;
intNum = -2_147_483_648;
longNum = -9_223_372_036_854_775_808;
sbyteNum = -128;
ushortNum = 0;
uintNum = 0;
ulongNum = 0;
charText = '\u0061';
stringText = "omega";
floatNum = -3.4e38F;
doubleNum = -1.7e308;
decimalNum = -7.9e28M;
boolText = false;

Console.WriteLine(byteNum);
Console.WriteLine(shortNum);
Console.WriteLine(intNum);
Console.WriteLine(longNum);
Console.WriteLine(sbyteNum);
Console.WriteLine(ushortNum);
Console.WriteLine(uintNum);
Console.WriteLine(ulongNum);
Console.WriteLine(charText);
Console.WriteLine(stringText);
Console.WriteLine(floatNum);
Console.WriteLine(doubleNum);
Console.WriteLine(decimalNum);
Console.WriteLine(boolText);

