string user = Console.ReadLine();

if (user.ToLower == "Маша")
{
    Console.WriteLine("Ура, это Маша!");  // ошибки могут быть из-за разного регистра
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(user);
}