using System.Reflection;

bool playagain = true;
while (playagain)
{
    Console.Write("Enter a sentence: ");
    string sentence = Console.ReadLine();

    foreach (string item in sentence.Split(" "))
    {
        Console.WriteLine(item);
    }

    Console.Write("Would you like to continue (y/n) ?: ");
    string answer = Console.ReadLine();

    if (answer == "n")
    {
        Console.WriteLine("Goodbye!");
        playagain = false;
    }

}


List<string> words = new List<string>();
int counter = 1;
for (int i = 0; i < counter; i++)
{
    Console.Write("Enter some text: ");
    string sentence = Console.ReadLine();
    words.Add(sentence);

    Console.Write("You have entered: ");

    foreach (string word in words)
    {
        Console.Write($"{word} ");
    }

    Console.WriteLine();

    Console.Write("Would you like to continue (y/n) ?: ");
    string answer = Console.ReadLine();

    if (answer == "n")
    {
        Console.WriteLine("Goodbye!");
        break;
    }
    counter = counter + 1;
}
