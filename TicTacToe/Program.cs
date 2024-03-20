using System.Collections.Generic;


List<string> TTT = [" "  ," "  ," "  ," "  ," "  ," "  ," "  ," "  , " " ];
bool quitter = false;

void ExecuteCommand(string iCommand)
{
    // Parse command
    var list = iCommand.Split(",");
    if (iCommand == "quitter")
    {
        quitter = true;
    }
    else
    {
        int x = -1;
        Int32.TryParse(list[0], out x);

        int y = -1;
        Int32.TryParse(list[1], out y);

        string player = list[2];

        if( x >= 0 && y >= 0 && x <= 2 && y <=2
            && ( player == "O" || player == "X")
            )
        {
            SetValue(x, y, player);
        }
        else
        {
            Console.WriteLine("Wtf ?");
        }
    }
    
}

void SetValue(int x, int y, string value)    //met value aux coordonnées x,y
{
    if (x < 3 & y < 3 & x >= 0 & y >= 0)
    {
        int index = x + 3 * y;
        TTT[index] = value;

    }
    return;
}
void Trace()
{
    for (int i = 0; i < TTT.Count; i = i + 3 )
    {
        Console.WriteLine($"{TTT[i]}|{TTT[i + 1]}|{TTT[i + 2]}");
    }
}

int GetValue(int x, int y)
{
    int index = x + 3 * y;
    Console.WriteLine(TTT[index]);
    return index;
}

Console.WriteLine("Tic-Tac-Toe starts");



do
{
    Console.WriteLine("==================");
    Trace();
    Console.WriteLine("==================");
    Console.WriteLine("P1 : Add a value  ");

    Console.WriteLine("     x,y,O        ");
    
    string command = Console.ReadLine();
    ExecuteCommand(command);


    Console.WriteLine("   ");
}
while (quitter == false);