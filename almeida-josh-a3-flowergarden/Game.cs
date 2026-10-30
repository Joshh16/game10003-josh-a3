// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Flower Garden");
            Window.SetSize(400, 400);
            Draw.SetLineSize(2);

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            //Sky
            Window.ClearBackground(135, 206, 235);

            // Grass
            Draw.SetFillColor(Color.Green);
            Draw.Rectangle(0, 300, 400, 100);

            // Flower stem
            Draw.SetFillColor(0,150,0);
            Draw.Rectangle(78, 250, 6, 50);

            // Flower petals
            Draw.SetFillColor(255, 192, 203);
            Draw.Circle(68, 240, 10);
            Draw.Circle(88, 240, 10);
            Draw.Circle(78, 230, 10);
            Draw.Circle(78, 250, 10);

            // Flower centre
            Draw.SetFillColor(Color.Yellow);
            Draw.Circle(78, 240, 7);

            // Flower 2 stem
            Draw.SetFillColor(0,150,0);
            Draw.Rectangle(198, 220, 6, 80);

            // Flower 2 petals
            Draw.SetFillColor(128, 0, 128);
            Draw.Circle(188, 210, 10);
            Draw.Circle(208, 210, 10);
            Draw.Circle(198, 200, 10);
            Draw.Circle(198, 220, 10);

            // Flower 2 centre
            Draw.SetFillColor(Color.Yellow);
            Draw.Circle(198, 210, 7);

            // Flower 3 stem
            Draw.SetFillColor(0,150,0);
            Draw.Rectangle(318, 250, 6, 50);

            // Flower 3 petals
            Draw.SetFillColor(Color.Red);
            Draw.Circle(308, 240, 10);
            Draw.Circle(328, 240, 10);
            Draw.Circle(318, 230, 10);
            Draw.Circle(318, 250, 10);

            // Flower 3 centre
            Draw.SetFillColor(Color.Yellow);
            Draw.Circle(318, 240, 7);

        }
    }

}
