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
        private Texture2D SpriteSheetRunning;
        private Texture2D SpriteSheetWalkAttack;
        private Texture2D SpriteSheetRunningAttack;
        Vector2 origin;
        private const int FRAMES_IN_ATTACK_SHEET = 8; 
        private const int FRAMES_IN_WALK_SHEET = 6;
        private const int FRAMES_IN_IDLE_SHEET = 12;
        private const int FRAMES_IN_RUNNING_SHEET = 8;
        private const int FRAMES_IN_WALKATTACK_SHEET = 6;
        private const int FRAMES_IN_RUNATTACK_SHEET = 8;
        private void DrawPlayer()
        {
            //DrawRectangleLinesEx(player,5,Red);
            //DrawRectangleLinesEx(destRect,5, Green);
            //DrawRectangleLinesEx(PlayerHurtBox,5, Blue);
            DrawRectangleLinesEx(HitBox,5, Orange);
            if(isAttackingAndMoving && isRunning) DrawTexturePro(SpriteSheetRunningAttack, sourceRect, destRect, origin, 0.0f, White); 
            else if(isAttackingAndMoving) DrawTexturePro(SpriteSheetWalkAttack, sourceRect, destRect, origin, 0.0f, White); 
            else if(isAttacking) DrawTexturePro(SpriteSheetAttacking, sourceRect, destRect, origin, 0.0f, White);
            else if(isMoving && isRunning) DrawTexturePro(SpriteSheetRunning, sourceRect, destRect, origin, 0.0f, White);
            else if(isMoving) DrawTexturePro(SpriteSheetWalking, sourceRect, destRect, origin, 0.0f, White);
            else DrawTexturePro(SpriteSheetIdle, sourceRect, destRect, origin, 0.0f, White);
        }

        private void Animations()
        {
            if(isAttackingAndMoving && isRunning) FrameTimer(FRAMES_IN_RUNATTACK_SHEET);
            else if(isAttackingAndMoving) FrameTimer(FRAMES_IN_WALKATTACK_SHEET);
            else if(isAttacking) FrameTimer(FRAMES_IN_ATTACK_SHEET);
            else if(isMoving && isRunning) FrameTimer(FRAMES_IN_RUNNING_SHEET);
            else if(isMoving) FrameTimer(FRAMES_IN_WALK_SHEET);
            else FrameTimer(FRAMES_IN_IDLE_SHEET);
            CalcSourceAndDestRecs();
        }

        private void FrameTimer(int totalFramesInLoop)
        {
            frameTimer += GetFrameTime();
            if(!isMoving && currentActionRow == 3 && !isAttacking) frameSpeed = 0.36f;
            else frameSpeed = 0.12f;

            if (frameTimer >= frameSpeed)
            {
                frameTimer = 0.0f;
                currentFrame++; // Move to next image frame box horizontally
                
                if(!isMoving && currentActionRow == 3 && !isAttacking)
                {
                    if (currentFrame >= totalFramesInLoop / 3)
                    {
                        currentFrame = 0; // Loop back to the first frame box
                    } 
                }else{
                    if (currentFrame >= totalFramesInLoop)
                    {
                        currentFrame = 0; // Loop back to the first frame box
                        if(isAttacking || isAttackingAndMoving){
                            isAttacking = false;
                            isAttackingAndMoving = false;
                            HitBox.X = 0;
                            HitBox.Y = 0;
                            HitBox.Width = 0;
                            HitBox.Height = 0;
                        }
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
            
            // Calibrate the hurtBox
            PlayerHurtBox.X = destRect.X + 60;
            PlayerHurtBox.Y = destRect.Y + 50;

           
            
        }       
    } 
}