
using System.Collections;
using System.Threading.Tasks;
using System.Xml.Linq;


Random random = new Random();
char[,] grid = new char[20, 20];
char man = 'X';
char ghost = 'G';
char ghost2 = 'G';
//char[] ghost = new char[1];
//char[] ghost2 = new char[1];
int[,] manCoord = new int[1, 2];
int[,] ghostCoord = new int[1, 2];
int[,] ghost2Coord = new int[1, 2];
int health = 3;
int score = 0;
for (int i = 0; i < grid.GetLength(0); i++)
{
    for (int j = 0; j < grid.GetLength(1); j++)
    {
        grid[i, j] = '.';
        Console.Write(grid[i, j] + " ");
    }
    Console.WriteLine(); 
}
ghostCoord[0, 0] = 15;
ghostCoord[0, 1] = 8;
ghost2Coord[0, 0] = 10;
ghost2Coord[0, 1] = 3;
manCoord[0, 0] = 10;
manCoord[0, 1] = 5;
do
{
    Console.Clear();
    Console.WriteLine("Health: "+health);
    Console.WriteLine("Score: " + score);
    if (Console.KeyAvailable)
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        switch (key.Key)
        {
            case ConsoleKey.UpArrow:
                {
                    --manCoord[0, 0];
                    try
                    {
                            int x = manCoord[0, 0];
                            int y = manCoord[0, 1];
                            if (grid[x, y] == '.') score++;
                            if (grid[x, y] == 'G')
                            {
                                health--;
                                manCoord[0, 0] = 10;
                                manCoord[0, 1] = 5;
                            }
                            grid[x, y] = 'X';
                            grid[x + 1, y] = ' ';
                    }
                    catch (Exception ex)
                    {
                        manCoord[0, 0] = 0;
                    }
                }
                break;
            case ConsoleKey.DownArrow:
                {
                    ++manCoord[0, 0];
                    try
                    {
                            int x = manCoord[0, 0];
                            int y = manCoord[0, 1];
                            if (grid[x, y] == '.') score++;
                            if (grid[x, y] == 'G')
                            {
                                health--;
                                manCoord[0, 0] = 10;
                                manCoord[0, 1] = 5;
                            }
                            grid[x, y] = 'X';
                            grid[x - 1, y] = ' ';
                    }
                    catch (Exception ex)
                    {
                        manCoord[0, 0]=19;
                    }
                }
                break;
            case ConsoleKey.LeftArrow:
                {
                    --manCoord[0, 1];
                    try
                    {
                            int x = manCoord[0, 0];
                            int y = manCoord[0, 1];
                            if (grid[x, y] == '.') score++;
                            if (grid[x, y] == 'G')
                            {
                                health--;
                                manCoord[0, 0] = 10;
                                manCoord[0, 1] = 5;
                            }
                            grid[x, y] = 'X';
                            grid[x, y + 1] = ' ';
                    }
                    catch (Exception ex)
                    {
                        manCoord[0, 1]=0;
                    }
                }
                break;
            case ConsoleKey.RightArrow:
                {
                    ++manCoord[0, 1];
                    try
                    {
                            int x = manCoord[0, 0];
                            int y = manCoord[0, 1];
                            if (grid[x, y] == '.') score++;
                            if (grid[x, y] == 'G')
                            {
                                health--;
                                manCoord[0, 0] = 10;
                                manCoord[0, 1] = 5;
                            }
                            grid[x, y] = 'X';
                            grid[x, y - 1] = ' ';
                    }
                    catch (Exception ex)
                    {
                        manCoord[0, 1] = 19;
                    }
                }
                break;
        }
    }
    int ghostDirection = random.Next(0, 4);
    switch (ghostDirection)
    {
        case 0:
            {
               if (ghostDirection == 0)
               {
                    --ghostCoord[0, 0];
                    try
                    {
                            int x = ghostCoord[0, 0];
                            int y = ghostCoord[0, 1];
                        if (grid[x, y] == '.')
                        {
                            grid[x, y] = 'G';
                            grid[x+1, y] = '.';
                        }
                        else if (grid[x, y] == ' ')
                        {
                            grid[x, y] = 'G';
                            grid[x+1, y] = ' ';
                        }
                        else if (grid[x, y] == ' ')
                        {
                            grid[x, y] = 'X';
                            grid[x, y + 1] = ' ';
                        }
                    }
                    catch (Exception ex)
                    {
                        ++ghostCoord[0, 0];
                    }
               }
            }
            break;
        case 1:
            {
                if (ghostDirection == 1)
                {
                    ++ghostCoord[0, 0];
                    try
                    {
                            int x = ghostCoord[0, 0];
                            int y = ghostCoord[0, 1];
                        if (grid[x, y] == '.')
                        {
                            grid[x, y] = 'G';
                            grid[x-1, y ] = '.';
                        }
                        else if (grid[x, y] == ' ')
                        {
                            grid[x, y] = 'G';
                            grid[x-1, y] = ' ';
                        }
                        else if (grid[x, y] == ' ')
                        {
                            grid[x, y] = 'X';
                            grid[x, y + 1] = ' ';
                        }
                    }
                    catch (Exception ex)
                    {
                        --ghostCoord[0, 0];
                    }
                }
            }
            break;
        case 2:
            {
                if (ghostDirection == 2)
                {
                    ++ghostCoord[0, 1];
                    try
                    {
                            int x = ghostCoord[0, 0];
                            int y = ghostCoord[0, 1];
                        if (grid[x, y] == '.')
                        {
                            grid[x, y] = 'G';
                            grid[x, y - 1] = '.';
                        }
                        else if (grid[x, y] == ' ')
                        {
                            grid[x, y] = 'G';
                            grid[x, y - 1] = ' ';
                        }
                        else if (grid[x, y] == ' ')
                        {
                            grid[x, y] = 'X';
                            grid[x, y + 1] = ' ';
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        --ghostCoord[0, 1];
                    }
                }
            }
            break;
        case 3:
            {
                if (ghostDirection == 3)
                {
                    --ghostCoord[0, 1];
                    try
                    {
                            int x = ghostCoord[0, 0];
                            int y = ghostCoord[0, 1];
                        if (grid[x, y] == '.')
                        {
                            grid[x, y] = 'G';
                            grid[x, y+1] = '.';
                        }
                        else if(grid[x, y] == ' ')
                        {
                            grid[x, y] = 'G';
                            grid[x, y + 1] = ' ';
                        }
                            else if (grid[x, y] == ' ')
                            {
                                grid[x, y] = 'X';
                                grid[x, y + 1] = ' ';
                            }
                    }
                    catch (Exception ex)
                    {
                        ++ghostCoord[0, 1];
                    }
                }
            }
            break;
    }
    int ghost2Direction = random.Next(0, 4);
    switch (ghost2Direction)
    {
        case 0:
            {
                if (ghost2Direction == 0)
                {
                    --ghost2Coord[0, 0];
                    try
                    {
                            int x = ghost2Coord[0, 0];
                            int y = ghost2Coord[0, 1];
                            if (grid[x, y] == '.')
                            {
                                grid[x, y] = 'G';
                                grid[x + 1, y] = '.';
                            }
                            else if (grid[x, y] == ' ')
                            {
                                grid[x, y] = 'G';
                                grid[x + 1, y] = ' ';
                            }
                            else if (grid[x, y] == ' ')
                            {
                                grid[x, y] = 'X';
                                grid[x, y + 1] = ' ';
                            }
                    }
                    catch (Exception ex)
                    {
                        ++ghost2Coord[0, 0];
                    }
                }
            }
            break;
        case 1:
            {
                if (ghost2Direction == 1)
                {
                    ++ghost2Coord[0, 0];
                    try
                    {
                            int x = ghost2Coord[0, 0];
                            int y = ghost2Coord[0, 1];

                            if (grid[x, y] == '.')
                            {
                                grid[x, y] = 'G';
                                grid[x - 1, y] = '.';
                            }
                            else if (grid[x, y] == ' ')
                            {
                                grid[x, y] = 'G';
                                grid[x - 1, y] = ' ';
                            }
                            else if (grid[x, y] == ' ')
                            {
                                grid[x, y] = 'X';
                                grid[x, y + 1] = ' ';
                            }
                    }
                    catch (Exception ex)
                    {
                        --ghost2Coord[0, 0];
                    }
                }
            }
            break;
        case 2:
            {
                if (ghost2Direction == 2)
                {
                    ++ghost2Coord[0, 1];
                    try
                    {
                            int x = ghost2Coord[0, 0];
                            int y = ghost2Coord[0, 1];

                            if (grid[x, y] == '.')
                            {
                                grid[x, y] = 'G';
                                grid[x, y - 1] = '.';
                            }
                            else if (grid[x, y] == ' ')
                            {
                                grid[x, y] = 'G';
                                grid[x, y - 1] = ' ';
                            }
                            else if (grid[x, y] == ' ')
                            {
                                grid[x, y] = 'X';
                                grid[x, y + 1] = ' ';
                            }
                    }
                    catch (Exception ex)
                    {
                        --ghost2Coord[0, 1];
                    }
                }
            }
            break;
        case 3:
            {
                if (ghost2Direction == 3)
                {
                    --ghost2Coord[0, 1];
                    try
                    {
                            int x = ghost2Coord[0, 0];
                            int y = ghost2Coord[0, 1];
                            if (grid[x, y] == '.')
                            {
                                grid[x, y] = 'G';
                                grid[x, y + 1] = '.';
                            }
                            else if (grid[x, y] == ' ')
                            {
                                grid[x, y] = 'G';
                                grid[x, y + 1] = ' ';
                            }
                            else if (grid[x, y] == ' ')
                            {
                                grid[x, y] = 'X';
                                grid[x, y + 1] = ' ';
                            }
                    }
                    catch (Exception ex)
                    {
                        ++ghost2Coord[0, 1];
                    }
                }
            }
            break;
    }
    for (int i = 0; i < grid.GetLength(0); i++)
    {
        for (int j = 0; j < grid.GetLength(1); j++)
        {
            Console.Write(grid[i, j] + " ");
        }
        Console.WriteLine();
    }
    Thread.Sleep(500);
    if (health == 0)
    {
        Console.WriteLine("Игра окончена");
        break;
    }
}
while (true);
