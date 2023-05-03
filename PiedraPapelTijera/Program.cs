
Console.WriteLine("Game: Rock Paper Scissors");

while (true)
{
    Console.WriteLine("Are you Ready?");
    Console.WriteLine("Let's Begin!!");

    var selectedChoise = SelectedChoise();
    var yourChoise = char.Parse(selectedChoise);

    Console.WriteLine($"You Selected {yourChoise}");

    var opponetChoise = GetOpponentChoise();
    Console.WriteLine($"I Selected {opponetChoise}");
    Console.WriteLine(" ");

    DecideWinner(opponetChoise, yourChoise);

    Console.WriteLine(" ");
    Console.WriteLine("Do you want to play again? YES or NO ");
    var playAgain = Console.ReadLine();

    if (playAgain?.ToLower() == "yes")
        continue;
    else
        break;     

}

string SelectedChoise()
{
    Console.WriteLine("Choose one opcion -> R, P or S -> [R]ock, [P]aper or [S]cissors: ");
    var selectedChoise = Console.ReadLine();

    if (selectedChoise?.ToLower() != "r" && selectedChoise?.ToLower() != "p" && selectedChoise?.ToLower() != "s")
    {
        Console.WriteLine("Please, select only one letter: R, P or S");
        selectedChoise = SelectedChoise();
    }

    return selectedChoise.ToUpper();
}

char GetOpponentChoise()
{
    char[] options = new char[] { 'R', 'P', 'S' };

    Random random= new Random();
    int randomIndex = random.Next(0,options.Length);

    return options[randomIndex];
}

void DecideWinner(char opponetChoise,char yourChoise)
{
    if (opponetChoise == yourChoise)
    {
        Console.WriteLine("TIE!! ");
        return;
    }

    switch (yourChoise)
    {
        case 'R':
            if (opponetChoise == 'P')
                Console.WriteLine("Paper beats Rock, I WIN!");
            else if (opponetChoise == 'S')
                Console.WriteLine("Rock beats Scisors, YOU WIN!");
            break;  
        case 'P':
            if (opponetChoise == 'R')
                Console.WriteLine("Paper beats Rock, YOU WIN!");
            else if (opponetChoise == 'S')
                Console.WriteLine("Scissors beats Paper, I WIN!");
            break;
        case 'S':
            if (opponetChoise == 'R')
                Console.WriteLine("Rock beats Scissors, I WIN!");
            else if (opponetChoise == 'P')
                Console.WriteLine("Scisors beats Paper, YOU WIN!");
            break;

        default:
            break;
    }
}