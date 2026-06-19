using Raylib_cs;
using PlayerN;
using static Raylib_cs.Raylib;

namespace PlayerN
{
    public partial class Player
    {
        private Rectangle HitBox;
        bool isAttacking = false;
        bool isAttackingAndMoving = false;

        private void HandleAttacking()
        {
            if (IsMouseButtonPressed(MouseButton.Left) && isMoving)
            {
                isAttackingAndMoving = true;
                currentFrame = 0;
            }else if (isAttackingAndMoving)
            {
                switch (currentActionRow)
                {
                    case 3:
                        HitBox.X = PlayerHurtBox.X - 5;
                        HitBox.Y = PlayerHurtBox.Y - 15;
                        HitBox.Width = 35;
                        HitBox.Height = 20;
                        break;
                    case 4:
                        HitBox.X = PlayerHurtBox.X - 5;
                        HitBox.Y = PlayerHurtBox.Y + 25;
                        HitBox.Width = 35;
                        HitBox.Height = 20;
                        break;
                    case 2:
                        HitBox.X = PlayerHurtBox.X + 25;
                        HitBox.Y = PlayerHurtBox.Y;
                        HitBox.Width = 20;
                        HitBox.Height = 30;
                        break;
                    case 1:
                        HitBox.X = PlayerHurtBox.X - 20;
                        HitBox.Y = PlayerHurtBox.Y;
                        HitBox.Width = 20;
                        HitBox.Height = 30;
                        break;
                }
            }
            else if (IsMouseButtonPressed(MouseButton.Left))
            {
                isAttacking = true;
                currentFrame = 0;
                switch (currentActionRow)
                {
                    case 3:
                        HitBox.X = PlayerHurtBox.X - 5;
                        HitBox.Y = PlayerHurtBox.Y - 15;
                        HitBox.Width = 35;
                        HitBox.Height = 20;
                        break;
                    case 4:
                        HitBox.X = PlayerHurtBox.X - 5;
                        HitBox.Y = PlayerHurtBox.Y + 25;
                        HitBox.Width = 35;
                        HitBox.Height = 20;
                        break;
                    case 2:
                        HitBox.X = PlayerHurtBox.X + 25;
                        HitBox.Y = PlayerHurtBox.Y;
                        HitBox.Width = 20;
                        HitBox.Height = 30;
                        break;
                    case 1:
                        HitBox.X = PlayerHurtBox.X - 20;
                        HitBox.Y = PlayerHurtBox.Y;
                        HitBox.Width = 20;
                        HitBox.Height = 30;
                        break;
                }
            }
        }
    }
}