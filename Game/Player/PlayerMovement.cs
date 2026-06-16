using PlayerN;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.KeyboardKey;
using System.Numerics;

namespace PlayerN
{
    public partial class Player
    {
        private float PLAYER_MOVESPEED = 3f;
        private float PLAYER_SPRINT_SPEED = 60f;
        private bool isSprinting = false; 
        private bool isMoving = false;
        private void HandleMovement()
        {
            if(IsKeyDown(W) || IsKeyDown(D) || IsKeyDown(S) || IsKeyDown(A)) isMoving = true;
            else{ 
                isMoving = false;
                
                
            }
            if(IsKeyDown(LeftShift)) isSprinting = true;
            else isSprinting = false;

            if(IsKeyDown(W)) {
                currentActionRow = 3;
                player.Y -= isSprinting ? PLAYER_SPRINT_SPEED : PLAYER_MOVESPEED ;
            }
            if(IsKeyDown(D)) {
                currentActionRow = 2;
                player.X += isSprinting ? PLAYER_SPRINT_SPEED : PLAYER_MOVESPEED; 
            }
            if(IsKeyDown(S)) {
                currentActionRow = 4;
                player.Y += isSprinting ? PLAYER_SPRINT_SPEED : PLAYER_MOVESPEED;
            }
            if(IsKeyDown(A)) {
                currentActionRow = 1;
                player.X -= isSprinting ? PLAYER_SPRINT_SPEED : PLAYER_MOVESPEED;
            }
        }
    }
}