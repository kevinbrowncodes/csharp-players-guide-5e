using TheLockedDoor;

string? doorRequest;
string? passcode = null;

while(passcode == null)
{
    Console.WriteLine("Enter a passcode: \n");
    passcode = Console.ReadLine();
}

Door door = new Door(passcode);

Console.WriteLine($"\nThe door is {door.DoorStatus}.");

while(door.DoorStatus != DoorStatus.Opened)
{
    Console.WriteLine("\nWhat do you want to do to the door? \n");
    Console.WriteLine("Open");
    Console.WriteLine("Close");
    Console.WriteLine("Unlock");
    Console.WriteLine("Lock");
    Console.WriteLine("Change Passcode \n");
    doorRequest = Console.ReadLine();
    door.UpdateDoorStatus(doorRequest);

    Console.WriteLine($"\nThe door is {door.DoorStatus}.");
}

