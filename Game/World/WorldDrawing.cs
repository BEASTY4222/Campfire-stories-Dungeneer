using Raylib_cs;
using static Raylib_cs.Raylib;

namespace WorldN
{
    public class World
    {
        private Texture2D SpriteDungeon;

        public World()
        {
            SpriteDungeon = LoadTexture("../Game/Assests/map.png");
        }

        public void DrawWorld()
        {
            DrawTexture(SpriteDungeon,0,0, Color.RayWhite);
        }
    }
}