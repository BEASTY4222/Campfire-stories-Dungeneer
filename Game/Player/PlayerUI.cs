using Raylib_cs;
using static Raylib_cs.Raylib;
using PlayerN;

namespace PlayerN
{
    public partial class Player
    {
        private Texture2D playerUi;

        private void DrawUi()
        {
            DrawTexture(playerUi,(int)player.X - 350,(int)player.Y - 200, Color.White);
        }
    }
}