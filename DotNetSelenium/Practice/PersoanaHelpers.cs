internal static class PersoanaHelpers
{

    private static string GetAge(int age)
    {

        if (age >= 100)
        {
            return "You are ancient!";
        }
        else if (age >= 50)
        {
            return "You are still old!";
        }
        else
        {
            return "You are still young!";
        }
    }
}