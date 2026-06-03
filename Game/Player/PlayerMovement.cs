using PlayerN;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.KeyboardKey;

namespace PlayerN
{
    public partial class Player
    {
        private void HandleMovement()
        {
            if(IsKeyDown(LeftShift)) isSprinting = true;
            else isSprinting = false;

            if(IsKeyDown(W)) {
                player.Y -= isSprinting ? PLAYER_SPRINT_SPEED : PLAYER_MOVESPEED ;
                playerVelocity += 0.1f * GetFrameTime();
            }
            if(IsKeyDown(D)) {
                player.X += isSprinting ? PLAYER_SPRINT_SPEED : PLAYER_MOVESPEED; 
                playerVelocity += 0.1f * GetFrameTime();
            }
            if(IsKeyDown(S)) player.Y += isSprinting ? PLAYER_SPRINT_SPEED : PLAYER_MOVESPEED;
            if(IsKeyDown(A)) player.X -= isSprinting ? PLAYER_SPRINT_SPEED : PLAYER_MOVESPEED;
        }
    }
}