/* Student Database Lab
 * Mattalynn Darden
 * 2/7/2024 */

//Write a program that will recognize invalid inputs when the user requests information about students in a class.

//Create 3 arrays and fill them with student information—one with name, one with hometown, one with favorite food
int studentNumber = 0;
string category = "default";
bool continueLearning = true;
string userDecision = "default";

string[] studentName = new string[9] { "John", "Jane", "Mattie D UC", "Tiffany", "Jill", "Todd", "Christina", "Melly", "Chryssy" };
string[] studentHometown = new string[9] { "Pontiac", "Miami", "Detroit", "New York", "Houston", "Cali", "Milford", "Waterford", "Warren" };
string[] studentFavFood = new string[9] { "pizza", "tacos", "pasta", "pickles", "doughnuts", "salad", "hummus", "french toast", "medditeranean" };

while (continueLearning)
{
    Console.WriteLine("Welcome! Which student would you like to learn about? Enter a number between 1-9:");
    studentNumber = int.Parse(Console.ReadLine());

    while (true)
    {
        if (studentNumber <= studentName.Length && studentNumber >= 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Number out of range. Please enter a number between 1-9.");
            studentNumber = int.Parse(Console.ReadLine());
        }
    }

    Console.WriteLine($"Student {studentNumber} is {studentName[(studentNumber -1)]}. What would you like to know? Enter \"Hometown\" or \"Favorite Food\":");

    while (true)
    {
        category = Console.ReadLine().ToLower().Trim();
        if (category == "hometown" || category == "favorite food")
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid category! Please enter \"hometown\" or \"favorite food\":");
        }
    }

    if (category.ToLower().Trim() == "hometown")
    {
        Console.WriteLine($"{studentName[studentNumber - 1]} is from {studentHometown[studentNumber -1]}.");
    }
    else if (category.ToLower().Trim() == "favorite food")
    {
        Console.WriteLine($"{studentName[studentNumber - 1]}'s favorite food is {studentFavFood[studentNumber - 1]}.");
    }

    Console.WriteLine("Would you like to learn about another student? (y / n)");
    userDecision = Console.ReadLine().ToLower().Trim();

    if (userDecision != "y")
    {
        continueLearning = false;
    }
}
Console.WriteLine("Goodbye!");