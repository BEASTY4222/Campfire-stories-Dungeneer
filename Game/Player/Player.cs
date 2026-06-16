using Raylib_cs;
using PlayerN;
using static Raylib_cs.Raylib;
using System.Numerics;

namespace PlayerN
{
    

    public partial class Player
    {
        private Rectangle player = new(700, 350, 75, 75);
        public Player()
        {
            currentFrame = 0;
            currentActionRow = 0;
            frameTimer = 0.0f;
            frameSpeed = 0.12f;

            origin = new Vector2(0f,0f);
            
            SpriteSheetAttacking = LoadTexture("../Game/Assests/swords man Charactet/PNG/Swordsman_lvl2/With_shadow/Swordsman_lvl2_attack_with_shadow.png");
            SpriteSheetWalking = LoadTexture("../Game/Assests/swords man Charactet/PNG/Swordsman_lvl2/With_shadow/Swordsman_lvl2_Walk_with_shadow.png");
            SpriteSheetIdle = LoadTexture("../Game/Assests/swords man Charactet/PNG/Swordsman_lvl2/With_shadow/Swordsman_lvl2_Idle_with_shadow.png");
        }

        public void Draw()
        {
            DrawPlayer();
        }

        public void Actions()
        {
            HandleMovement();

            Animations();
        } 

        public void Dispose()
        {
            UnloadTexture(SpriteSheetAttacking);
            UnloadTexture(SpriteSheetWalking);
        }
    }
}