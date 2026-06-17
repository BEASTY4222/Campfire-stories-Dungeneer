using Raylib_cs;
using PlayerN;
using System.Numerics;
using WorldN;


namespace Main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Raylib.InitWindow(1400, 700, "Top Down");
            Raylib.SetTargetFPS(144);

            Player player = new Player();
            World world = new World();
            

            while (!Raylib.WindowShouldClose())
            {
                player.Actions();

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.DarkGray);
                Raylib.BeginMode2D(player.PlayerCam);

                world.DrawWorld();
                player.Draw();
                
                
                Raylib.EndMode2D();
                Raylib.EndDrawing();
            }

            player.Dispose();
            Raylib.CloseWindow();
        }
    }
}
