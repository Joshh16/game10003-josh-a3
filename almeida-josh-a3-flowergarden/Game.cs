// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    
    public class Game
    {
        Garden garden = new Garden();
        public void Setup()
        {
            Window.SetTitle("Flower Garden");
            Window.SetSize(400, 400);
            Draw.SetLineSize(2);
            
        }
        public void Update()
        {
            // Sky
            Window.ClearBackground(135, 206, 235);

            // Clouds
            Draw.SetFillColor(255, 255, 255);
            
            // Cloud 1
            Draw.Circle(75, 75, 15);
            Draw.Circle(90, 65, 18);
            Draw.Circle(105, 75, 15);

            // Cloud 2
            Draw.Circle(275, 110, 15);
            Draw.Circle(290, 100, 18);
            Draw.Circle(305, 110, 15);

            // Cloud 3
            Draw.Circle(200, 50, 15);
            Draw.Circle(215, 40, 18);
            Draw.Circle(230, 50, 15);

            // Grass
            Draw.SetFillColor(0, 160, 0);
            Draw.Rectangle(0, 300, 400, 100);

            // Sun
            Draw.SetFillColor(255, 255, 0);
            Draw.Circle(390, 20, 30);

            garden.CheckFlowerClick();
            garden.DrawGarden(this);

        }
public void DrawFlower(int x, int y, int colorType)
        {
            // Draw stem
            Draw.SetFillColor(0, 150, 0);
            Draw.Rectangle(x, y + 10, 6, 290 - y);

            // Choose flower color
            if (colorType == 0)
            {
                Draw.SetFillColor(255, 192, 203);
            }
            else if (colorType == 1)
            {
                Draw.SetFillColor(128, 0, 128);
            }
            else
            {
                Draw.SetFillColor(255, 0, 0);
            }

            // Draw petals
            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    Draw.Circle(x - 10, y, 10);
                }
                else if (i == 1)
                {
                    Draw.Circle(x + 10, y, 10);
                }
                else if (i == 2)
                {
                    Draw.Circle(x, y - 10, 10);
                }
                else
                {
                    Draw.Circle(x, y + 10, 10);
                }
            }

            // Draw flower centre
            Draw.SetFillColor(255, 255, 0);
            Draw.Circle(x, y, 7);
        }
    }
}
