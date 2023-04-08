/* code for computing an array's minimum and average values */
#region
// find minimum value of an array using for loop
int[] arrayMin1 = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue; // Start higher than anything in the array.
for (int index = 0; index < arrayMin1.Length; index++)
{
    if (arrayMin1[index] < currentSmallest)
        currentSmallest = arrayMin1[index];
}
Console.WriteLine(currentSmallest);

// find average value of an array using for loop
int[] arrayAvg1 = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int total = 0;
for (int index = 0; index < arrayAvg1.Length; index++)
    total += arrayAvg1[index];
float average = (float)total / arrayAvg1.Length;
Console.WriteLine(average);
#endregion

/* modify the code to use foreach loops instead of for loops */
#region
// find minimum value of an array using foreach loop
int[] arrMin2 = new int[9] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int minValue = int.MaxValue;
foreach (var num in arrMin2)
{
    if(num < minValue) {
        minValue = num;
    }
}
Console.WriteLine("The minimum value is: " + minValue);

// find average value of an array using foreach loop
int[] arrMax2 = new int[9] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
double total2 = 0;
double avg2 = 0;
foreach (var num in arrMax2)
{
    total2 += num;
}

avg2 = (total2 / arrMax2.Length);

Console.WriteLine("The average value is: " + avg2);
#endregion