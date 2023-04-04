Console.WriteLine("What kind of thing are we talking about?");

// Thing type
string a = Console.ReadLine();

Console.WriteLine("How would you describe it? Big? Azure? Tattered?");

// Thing description
string b = Console.ReadLine();

// text "Doom"
string c = "Doom"; /* Modified to fix the "of of" bug */

// text "3000"
string d = "3000";

Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");
