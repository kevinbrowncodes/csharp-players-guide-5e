using ThePasswordValidator;

string? passwordInput;
bool isValidPassword = false;

while (true)
{
    Console.Write("What is the password? ");
    passwordInput = Console.ReadLine();
    PasswordValidator passwordValidator = new PasswordValidator(passwordInput);
    isValidPassword = passwordValidator.CheckPassword(passwordInput);

    Console.WriteLine($"The input password is {passwordInput}");
    Console.WriteLine($"The input password is {isValidPassword}");
}