

//string[] words = { "hello","hiii" ,"world","nepal","programming","radiant","college" };

//Random random = new Random();

// string word = words[random.Next(words.Length)];
//char[] guess = new char[word.Length];

//for (int i=0; i<guess.Length; i++)
//{

//    guess[i] = '-';

//}


//Console.WriteLine(guess);

//int lives =(2+ guess.Length);
//Console.WriteLine(lives);



//while (lives > 0)
//{

//    Console.WriteLine(guess);

//    Console.WriteLine("Enter a letter: ");
//    char letter = Convert.ToChar(Console.ReadLine());

//    if (word.Contains(letter))
//    {
//        for (int i = 0; i < word.Length; i++)
//        {
//            if (word[i] == letter)
//            {
//                guess[i] = letter;

//            }
//        }
//    }
//    else
//    {
//        lives--;
//        Console.WriteLine("Wrong");

//    }

//    Console.WriteLine("Remaining Lives: " + lives);

//    if (new string(guess) == word)
//    {
//        Console.WriteLine("you won the game ");
//        break;

//    }
//}

//    if (lives == 0)
//    {
//        Console.WriteLine("Game Over");
//        Console.WriteLine("Word was: "+ word);
//    }




//string[] words = { "radiant", "college", "training" };
//Random random = new Random();
//string word = words[random.Next(words.Length)];
//char[] guess = new char[word.Length];

//for (int i = 0; i < word.Length; i++)
//{
//    guess[i] = '_';

//}

//Console.WriteLine(guess);

//int lives = (2 + (word.Length));
//Console.WriteLine(lives);

//while (lives > 0)
//{
//    Console.WriteLine(guess);

//    Console.Write("Enter the letter: ");
//    char letter = Convert.ToChar(Console.ReadLine());

//    if (word.Contains(letter))
//    {
//        for (int i = 0; i < word.Length; i++)
//        {
//            if (word[i] == letter)
//            {
//                guess[i] = letter;
//            }
//        }
//    }
//    else
//    {
//        lives--;
//        Console.WriteLine("Wrong input ");

//    }

//    Console.WriteLine("Remaining lives: " + lives);

//    if (new string(guess) == word)
//    {
//        Console.WriteLine("you won the game ");
//        Console.WriteLine("word: " + word);
//        break;
//    }

//    if (lives == 0)
//    {
//        Console.WriteLine("You lose the game ");

//        Console.WriteLine("the word was " + word);
//    }



//}





string words()
{
    string[] words = { "radiant", "hello", "nepal" };
    Random random = new Random();
    string word = words[random.Next(words.Length)];
    return word;

    

}

char[] underscore(string word)
{
    char[] guess = new char[word.Length];
    for (int i = 0; i < word.Length; i++)
    {
        guess[i] = '-';
    }
    Console.WriteLine(new string(guess));
    return guess;
}


int lives(string word)
{
    int lives = 2 + (word.Length);
    Console.WriteLine("Your total lives are: " + lives);
    return lives;
}






void loop(string word,char[] guess,int lives)
{

    while (lives > 0)
    {
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
                Console.WriteLine("You won the game!");
                Console.WriteLine("Word: " + word);
                return;
            }
        
           

        }

        
    
    else
    {
        lives--;
        Console.WriteLine("wrong guess ");
    }
    Console.WriteLine("Remaining lives: " + lives);
    Console.WriteLine("you lose the game!");
    Console.WriteLine("the word wwas: " + word);
}



string word = words();
char[] guess = underscore(word);
int lives = lives(word);
loop(word, guess, lives);
