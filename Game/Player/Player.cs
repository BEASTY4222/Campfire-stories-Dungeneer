using Raylib_cs;
using PlayerN;

namespace PlayerN
{
    

    public partial class Player
    {
        private float PLAYER_MOVESPEED = 300f;
        private float PLAYER_SPRINT_SPEED = 600f;
        private float playerVelocity = 0f;
        private bool isSprinting = false;

        private Rectangle player = new(700, 350, 75, 75);
        public Player(){}

        public void Draw()
        {
            DrawPlayer();
        }

        public void Actions()
        {
            HandleMovement();
        } 
    }
}