
using System.Collections;
using System.Threading.Tasks;
using System.Xml.Linq;


Random random = new Random();
char[,] grid =
{
    {'O','O','O','O','O','O','O','O','O','O'},
    {'O','.','.','.','.','.','.','.','.','O'},
    {'O','.','O','O','.','O','.','O','.','O'},
    {'.','.','.','.','.','O','.','O','.','O'},
    {'O','.','O','O','.','.','.','.','.','.'},
    {'O','.','.','.','.','.','O','O','.','O'},
    {'O','.','O','O','.','.','.','.','.','.'},
    {'.','.','.','.','.','O','O','O','.','O'},
    {'O','.','.','O','.','.','.','.','.','.'},
    {'O','O','.','O','.','O','O','O','.','O'}
    

};
//char[,] grid = new char[10, 10];
char man = 'X';
char ghost = 'G';
char ghost2 = 'G';
int[,] manCoord = new int[1, 2];
int[,] ghostCoord = new int[1, 2];
int[,] ghost2Coord = new int[1, 2];
int health = 3;
int score = 0;
char previousGhostCell = ' ';
char previousGhost2Cell = ' ';
ghostCoord[0, 0] = 3;
ghostCoord[0, 1] = 3;
previousGhostCell = grid[3, 3];
ghost2Coord[0, 0] = 8;
ghost2Coord[0, 1] = 8;
previousGhost2Cell = grid[8, 8];
manCoord[0, 0] = 5;
manCoord[0, 1] = 4;
grid[ghost2Coord[0, 0], ghost2Coord[0, 1]] = ghost2;
grid[ghostCoord[0, 0], ghostCoord[0, 1]] = ghost;
grid[manCoord[0, 0], manCoord[0, 1]] = man;

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
                    int newXm = manCoord[0, 0]-1;
                    int newYm = manCoord[0, 1];
                    if (newXm >= 0 && newXm < grid.GetLength(0) && grid[newXm, newYm] != 'O')
                    {
                        if (grid[newXm, newYm] == '.') ++score;
                        if (grid[newXm, newYm] == 'G') --health;
                        if (health > 0)
                        {
                            grid[manCoord[0, 0], manCoord[0, 1]] = ' ';
                            manCoord[0, 0] = newXm;
                            grid[manCoord[0, 0], manCoord[0, 1]] = man;
                        }
                        else
                        {
                            manCoord[0, 0] = 5;
                            manCoord[0, 1] = 4;
                            grid[manCoord[0, 0], manCoord[0, 1]] = man;
                        }
                    }
                }
                break;
            case ConsoleKey.DownArrow:
                {
                    int newXm = manCoord[0, 0]+1;
                    int newYm = manCoord[0, 1];
                    if (newXm >= 0 && newXm < grid.GetLength(0) && grid[newXm, newYm] != 'O')
                    {
                        if (grid[newXm, newYm] == '.') ++score;
                        if (grid[newXm, newYm] == 'G') --health;
                        if (health > 0)
                        {
                            grid[manCoord[0, 0], manCoord[0, 1]] = ' ';
                            manCoord[0, 0] = newXm;
                            grid[manCoord[0, 0], manCoord[0, 1]] = man;
                        }
                        else
                        {
                            manCoord[0, 0] = 5;
                            manCoord[0, 1] = 4;
                            grid[manCoord[0, 0], manCoord[0, 1]] = man;
                        }
                    }
                }
                break;
            case ConsoleKey.LeftArrow:
                {
                    int newXm = manCoord[0, 0];
                    int newYm = manCoord[0, 1]-1;
                    if (newYm >= 0 && newYm < grid.GetLength(1) && grid[newXm, newYm] != 'O')
                    {
                        if (grid[newXm, newYm] == '.') ++score;
                        if (grid[newXm, newYm] == 'G') --health;
                        if (health > 0)
                        {
                            grid[manCoord[0, 0], manCoord[0, 1]] = ' ';
                            manCoord[0, 1] = newYm;
                            grid[manCoord[0, 0], manCoord[0, 1]] = man;
                        }
                        else
                        {
                            manCoord[0, 0] = 5;
                            manCoord[0, 1] = 4;
                            grid[manCoord[0, 0], manCoord[0, 1]] = man;
                        }
                    }
                }
                break;
            case ConsoleKey.RightArrow:
                {
                    int newXm = manCoord[0, 0];
                    int newYm = manCoord[0, 1]+1;
                    if (newYm >= 0 && newYm < grid.GetLength(1) && grid[newXm, newYm] != 'O')
                    {
                        if (grid[newXm, newYm] == '.') ++score;
                        if (grid[newXm, newYm] == 'G') --health;
                        if (health > 0)
                        {
                            grid[manCoord[0, 0], manCoord[0, 1]] = ' ';
                            manCoord[0, 1] = newYm;
                            grid[manCoord[0, 0], manCoord[0, 1]] = man;
                        }
                        else
                        {
                            manCoord[0, 0] = 5;
                            manCoord[0, 1] = 4;
                            grid[manCoord[0, 0], manCoord[0, 1]] = man;
                        }
                    }
                }
                break;
        }
    }
    int oldX = ghostCoord[0, 0];
    int oldY = ghostCoord[0, 1];
    int newX = oldX;
    int newY = oldY;
    int ghostDirection = random.Next(0, 4);
    switch (ghostDirection)
    {
        case 0:newX--; break;
        case 1:newX++; break;
        case 2:newY++; break;
        case 3:newY--; break;
    }
    if (newX >= 0 && newX < grid.GetLength(0) && newY >= 0 && newY < grid.GetLength(1) && grid[newX, newY] != 'O' && grid[newX, newY] != 'G')
    {
        if (grid[newX, newY] == 'X')
        {
            --health;
            grid[oldX, oldY] = previousGhostCell;
            previousGhostCell = ' ';
            ghostCoord[0, 0] = newX;
            ghostCoord[0, 1] = newY;
            grid[newX, newY] = 'G';
            manCoord[0, 0] = 5;
            manCoord[0, 1] = 4;
            grid[manCoord[0, 0], manCoord[0, 1]] = man;

        }
        else
        {
            grid[oldX, oldY] = previousGhostCell;
            previousGhostCell = grid[newX, newY];
            ghostCoord[0, 0] = newX;
            ghostCoord[0, 1] = newY;
            grid[newX, newY] = 'G';
        }
        
    }
    int oldX2 = ghost2Coord[0, 0];
    int oldY2 = ghost2Coord[0, 1];
    int newX2 = oldX2;
    int newY2 = oldY2;
    int ghost2Direction = random.Next(0, 4);
    switch (ghostDirection)
    {
        case 0: newX2--; break;
        case 1: newX2++; break;
        case 2: newY2++; break;
        case 3: newY2--; break;
    }
    if (newX2 >= 0 && newX2 < grid.GetLength(0) && newY2 >= 0 && newY2 < grid.GetLength(1) && grid[newX2, newY2] != 'O' && grid[newX2, newY2] != 'G')
    {
        if(grid[newX2, newY2] == 'X')
        {
            --health;
            grid[oldX2, oldY2] = previousGhost2Cell;
            previousGhost2Cell = ' ';
            ghost2Coord[0, 0] = newX2;
            ghost2Coord[0, 1] = newY2;
            grid[newX2, newY2] = 'G';
            manCoord[0, 0] = 5;
            manCoord[0, 1] = 4;
            grid[manCoord[0, 0], manCoord[0, 1]] = man;
        }
        else
        {
            grid[oldX2, oldY2] = previousGhost2Cell;
            previousGhost2Cell = grid[newX2, newY2];
            ghost2Coord[0, 0] = newX2;
            ghost2Coord[0, 1] = newY2;
            grid[newX2, newY2] = 'G';
        }

    }
    

    for (int i = 0; i < grid.GetLength(0); i++)
    {
        for (int j = 0; j < grid.GetLength(1); j++)
        {
            Console.Write(grid[i, j] + " ");
        }
        Console.WriteLine();
    }
    Thread.Sleep(400);
    if (health == 0)
    {
        Console.WriteLine("Игра окончена, поражение!");
        break;
    }
    if (score == 55)
    {
        Console.WriteLine("Игра окончена, победа!");
        break;
    }
}
while (true);
