using PlayerN;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
using System.Numerics;

namespace PlayerN
{
    public partial class Player
    {
        private Rectangle sourceRect;
        private Rectangle destRect;
        private const int FRAME_WIDTH = 64; 
        private const int FRAME_HEIGHT = 64;
        private const int SCALE_MULTIPLIER = 3;
        private int currentFrame;    
        private int currentActionRow;
        private float frameTimer;
        private float frameSpeed;   // How long each frame displays in seconds (lower is faster)
        private Texture2D SpriteSheetAttacking;
        private Texture2D SpriteSheetWalking;
        private Texture2D SpriteSheetIdle;
        Vector2 origin;
        private const int FRAMES_IN_ATTACK_SHEET = 8; 
        private const int FRAMES_IN_WALK_SHEET = 6;
        private const int FRAMES_IN_IDLE_SHEET = 12;
        private void DrawPlayer()
        {
            if(isMoving) DrawTexturePro(SpriteSheetWalking, sourceRect, destRect, origin, 0.0f, White);
            else DrawTexturePro(SpriteSheetIdle, sourceRect, destRect, origin, 0.0f, White);
        }

        private void Animations()
        {
            if(isMoving) FrameTimer(FRAMES_IN_WALK_SHEET);
            CalcSourceAndDestRecs();
        }

        private void FrameTimer(int totalFramesInLoop)
        {
            frameTimer += GetFrameTime();

            if (frameTimer >= frameSpeed)
            {
                frameTimer = 0.0f;
                currentFrame++; // Move to next image frame box horizontally
                
                if(!isMoving && currentActionRow == 3)
                {
                    if (currentFrame >= totalFramesInLoop / 3)
                    {
                        currentFrame = 0; // Loop back to the first frame box
                    }
                }else{
                    if (currentFrame >= totalFramesInLoop)
                    {
                        currentFrame = 0; // Loop back to the first frame box
                    }
                }
            }
        }

        private void CalcSourceAndDestRecs()
        {
            
            sourceRect.X = currentFrame * FRAME_WIDTH;       // X coordinate on sheet
            sourceRect.Y = currentActionRow * FRAME_HEIGHT; // Y coordinate on sheet
            sourceRect.Width = FRAME_WIDTH;                    // Width of crop
            sourceRect.Height = FRAME_HEIGHT;                     // Height of crop

            destRect.X = player.X;
            destRect.Y = player.Y;
            destRect.Width = FRAME_WIDTH * SCALE_MULTIPLIER; 
            destRect.Height = FRAME_HEIGHT * SCALE_MULTIPLIER;   
        }       
    } 
}