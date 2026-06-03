using Raylib_cs;
using PlayerN;
using System.Numerics;


namespace Main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Raylib.InitWindow(1400, 700, "Top Down");
            Raylib.SetTargetFPS(144);

            Player player = new Player();
            Vector2 camPos = new Vector2(750,350);
            Vector2 camOff = new Vector2(0,0);
            Camera2D tempCam = new Camera2D(camOff,camPos,0,0.5f);

            while (!Raylib.WindowShouldClose())
            {
                player.Actions();

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);
                Raylib.BeginMode2D(tempCam);

                player.Draw();
                
                Raylib.EndMode2D();
                Raylib.EndDrawing();
            }

                    
            Raylib.CloseWindow();
        }
    }
}
