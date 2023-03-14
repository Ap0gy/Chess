namespace Chess;

public class Board
{

    private Board(int dimensionX, int dimensionY)
    {

        Coords[] boardArray = new Coords[dimensionX*dimensionY];
    }
}

public record Coords(int x, int y)
{ }