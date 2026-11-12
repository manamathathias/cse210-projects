// Creativity extras:
// 1. I put scriptures in a list so the program can pick one at a random (List<Scripture>library = new List<Scripture>). from
// 2. Random scripture library (Genesis 1:1-10, Matthew 5:3-4, John 3:16, Proverbs 3:5-6)
// 3. Difficulty levels that change how many words are hidden per turn
// 4. Progress counter showing how many words are hidden
// 5. Only visible words are chosen for hiding (stretch challenge)
// 6. These program ask for a difficulty before proceeding, with that, it sets how many words are hidden in each round.
List<Scripture> library = new List<Scripture>
{
    new Scripture(new Reference("Genesis", 1, 1, 10),
        "In the beginning God created the heaven and the earth. And the earth was without form, and void; and darkness was upon the face of the deep. And the Spirit of God moved upon the face of the waters. And God said, Let there be light: and there was light. And God saw the light, that it was good: and God divided the light from the darkness. And God called the light Day, and the darkness he called Night. And the evening and the morning were the first day. And God said, Let there be a firmament in the midst of the waters, and let it divide the waters from the waters. And God made the firmament, and divided the waters which were under the firmament from the waters which were above the firmament: and it was so. And God called the firmament Heaven. And the evening and the morning were the second day. And God said, Let the waters under the heaven be gathered together unto one place, and let the dry land appear: and it was so. And God called the dry land Earth; and the gathering together of the waters called he Seas: and God saw that it was good."),
    new Scripture(new Reference("Matthew", 5, 3, 4),
        "Blessed are the poor in spirit: for theirs is the kingdom of heaven. Blessed are they that mourn: for they shall be comforted."),
};

Random random = new Random();
Scripture scripture = library[random.Next(library.Count)];

Console.Clear();
Console.WriteLine("Choose a difficulty:");
Console.WriteLine("1 - Easy (hide 1 word per turn)");
Console.WriteLine("2 - Medium (hide 3 words per turn)");
Console.WriteLine("3 - Hard (hide 5 words per turn)");
Console.Write("Your choice: ");
string choice = Console.ReadLine();

int wordsPerTurn = 3;
if (choice == "1")
{
    wordsPerTurn = 1;
}
else if (choice == "3")
{
    wordsPerTurn = 5;
}

while (true)
{
    Console.Clear();
    Console.WriteLine(scripture.GetDisplayText());
    Console.WriteLine();
    Console.WriteLine($"Progress: {scripture.GetHiddenCount()} of {scripture.GetWordCount()} words hidden");
    Console.WriteLine();

    if (scripture.IsCompletelyHidden())
    {
        Console.WriteLine("Well done! You have memorized the whole scripture.");
        break;
    }

    Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit.");
    string input = Console.ReadLine();

    if (input.Trim().ToLower() == "quit")
    {
        break;
    }

    scripture.HideRandomWords(wordsPerTurn);
}