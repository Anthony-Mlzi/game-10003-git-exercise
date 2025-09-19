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
        // Place your variables here:

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Anthony's Game");
            Window.SetSize(400, 400);
            Window.TargetFPS = 60;
            Window.ClearBackground(Color.OffWhite);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Black);
            Input.IsKeyboardKeyDown(KeyboardInput.Space);
            if (Input.IsKeyboardKeyDown(KeyboardInput.Space))
            {
                Draw.LineSize = 20;
                Draw.LineColor = Color.White;
                Draw.Line(10, 200, 390, 200);
            }
        }
    }

}
