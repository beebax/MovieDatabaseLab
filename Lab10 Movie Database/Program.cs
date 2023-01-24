

using Lab10_Movie_Database;

List<Movies> ourMovies = new List<Movies>()
{
    new Movies("Midsommar", "horror"),
    new Movies("Get Out", "horror"),
    new Movies("Howl's Moving Castle", "animated"),
    new Movies("Spirited Away", "animated"),
    new Movies("Ratatouille", "animated"),
    new Movies("The Shape of Water", "drama"),
    new Movies("The Lobster", "drama"),
    new Movies("Everything Everywhere All At Once", "sci fi"),
    new Movies("The Fifth Element", "sci fi"),
    new Movies("Annihilation", "sci fi"),
};
Console.WriteLine("Welcome to the movie database.");

bool runProgram = true;
while (runProgram)
{

    while (true)
    {
        Console.WriteLine("Please select a category: horror, animated, drama, or sci fi.");
        string input = Console.ReadLine().ToLower().Trim();
        if (input == "horror" || input == "animated" || input == "drama" || input == "sci fi")
        {
            foreach (Movies m in ourMovies.Where(m => m.Category.ToLower() == input))
            {
                Console.WriteLine(m.GetGenreMovies());
            }
            break;
        }
        else
        {
            Console.WriteLine("Invalid category. Please try again.");
        }
    }
    
    runProgram = Validator.GetContinue("Would you like to choose another category?", "Y", "N");
}

Console.WriteLine("Thank you for using our database. Goodbye.");
