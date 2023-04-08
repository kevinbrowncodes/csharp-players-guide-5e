/* Make a program that creates an array of length 5 */
int[] arr1 = new int[5];

/* Ask the user for five numbers an put them in the array */
Console.WriteLine("Please provide five numbers: ");
for (int i = 0; i < arr1.Length; i++)
{
    arr1[i] = Convert.ToInt32(Console.ReadLine());
}

/* Make a second array of length 5 */
int[] arr2 = new int[5];

/* Use a loop to copy values out of the original array into the new one */
Console.WriteLine("replication in process...");
for (int i = 0; i < arr2.Length; i++)
{
    arr2[i] = arr1[i];
}

/* Display the contents of both arrays one at a time to illustrate that the Replicator of D'To works again */
Console.WriteLine("contents of replication 1: ");
for (int i = 0; i < arr1.Length; i++)
{
    
    if (!(i == (arr1.Length - 1))) {
        Console.Write($"{arr1[i]}, ");
        continue;
    }
    Console.Write($"{arr1[i]}");
    break;
}

Console.WriteLine();

Console.WriteLine("contents of replication 2: ");
for (int i = 0; i < arr2.Length; i++)
{
    if (!(i == (arr2.Length - 1)))
    {
        Console.Write($"{arr2[i]}, ");
        continue;
    }
    Console.Write($"{arr2[i]}");
    break;
}
