

string words()
{
    string[] words = { "radiant", "hello", "nepal" };
    Random random = new Random();
    string word = words[random.Next(words.Length)];
    return word;
}

char[] underscore(string word)
{
    char[] guess=new char[word.Length];
    for(int i = 0; i < word.Length; i++)
    {
        guess[i] = '_';
    }
    Console.WriteLine(new string (guess));
    return guess;
}

int Lives(string word)
{
    int lives = 2 + word.Length;
    Console.WriteLine("Your total lives are : "+Lives);
    return lives;
}

void loop(string word, char[] guess, int Lives)
{
    while (Lives > 0)
    {
        Console.WriteLine("current word: " + new string(guess));
        Console.WriteLine("enter the letter: ");
        char letter = char.Parse(Console.ReadLine());

        if (word.Contains(letter))
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == letter)
                {
                    guess[i] = letter;
                }
            }
            if (new string(guess) == word)
            {
                Console.Write("you won the game ");
                Console.WriteLine("the word was: " + word);
                return;

            }

        }
        else
        {
            Lives--;
            Console.WriteLine("Wrong guess");
        }
        Console.Write("Your remainig lives are: " + Lives);
    }
    Console.Write("you lose the game");
    Console.Write("the word was: " + word);

}







string word = words();
char[] guess= underscore(word);
int lives = Lives(word);
loop(word, guess, lives);