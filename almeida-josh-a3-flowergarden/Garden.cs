using System;
using System.Numerics;
namespace MohawkGame2D;

public class Garden
{
    // Store the three flowers
    Flower flower1;
    Flower flower2;
    Flower flower3;

    // Create the flowers
    public Garden()
    {
        flower1 = new Flower(78, 240, 0);
        flower2 = new Flower(198, 210, 1);
        flower3 = new Flower(318, 240, 2);
    }

    // Draw all three flowers
    public void DrawGarden(Game game)
    {
        game.DrawFlower((int)flower1.X, (int)flower1.Y, flower1.ColorType);
        game.DrawFlower((int)flower2.X, (int)flower2.Y, flower2.ColorType);
        game.DrawFlower((int)flower3.X, (int)flower3.Y, flower3.ColorType);
    }
}
