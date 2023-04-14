string type;
string ingredient;
string seasoning;

/* Make a tuple variable to represent a soup compose of the three enumeration types */
(string Type, string Ingredient, string Seasoning) soup = ("", "", "");

/* Let the user pick a type, main ingredient, and seasoning from the allowed
 * choices and fill the tuple with the results */
// type
Console.WriteLine("Pick a type: ");
Console.WriteLine($"{Type.Soup}, {Type.Stew}, {Type.Gumbo}");
soup.Type = Console.ReadLine();

// ingredient
Console.WriteLine("Pick a ingredient: ");
Console.WriteLine($"{Ingredient.Mushrooms}, {Ingredient.Chicken}, {Ingredient.Carrots}, {Ingredient.Potatoes}");
soup.Ingredient = Console.ReadLine();

// seasoning
Console.WriteLine("Pick a seasoning: ");
Console.WriteLine($"{Seasoning.Spicy}, {Seasoning.Salty}, {Seasoning.Sweet}");
soup.Seasoning = Console.ReadLine();

/* When done, display the contents of the soup tuple variable in a format like
 * "Sweet Chicken Gumbo" */
Console.WriteLine();
(type, ingredient, seasoning) = soup;
Console.WriteLine($"{seasoning} {ingredient} {type}");

/* Define enumerations for the three variations on food: type, ingredient, and seasoning */
#region
enum Type
{
    Soup,
    Stew,
    Gumbo
}

enum Ingredient
{
    Mushrooms,
    Chicken,
    Carrots,
    Potatoes
}

enum Seasoning
{
    Spicy,
    Salty,
    Sweet
}
#endregion