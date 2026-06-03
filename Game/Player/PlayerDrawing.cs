using PlayerN;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

namespace PlayerN
{
    public partial class Player
    {
        private void DrawPlayer()
        {
            DrawRectangleRec(player, Red);
        }        
    } 
}