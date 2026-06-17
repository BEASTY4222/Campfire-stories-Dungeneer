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
                        HitBox.X = PlayerHurtBox.X - 10;
                        HitBox.Y = PlayerHurtBox.Y - 25;
                        HitBox.Width = 100;
                        HitBox.Height = 30;
                        break;
                    case 4:
                        HitBox.X = PlayerHurtBox.X - 10;
                        HitBox.Y = PlayerHurtBox.Y + 95;
                        HitBox.Width = 100;
                        HitBox.Height = 30;
                        break;
                    case 2:
                        HitBox.X = PlayerHurtBox.X + 65;
                        HitBox.Y = PlayerHurtBox.Y;
                        HitBox.Width = 50;
                        HitBox.Height = 100;
                        break;
                    case 1:
                        HitBox.X = PlayerHurtBox.X - 45;
                        HitBox.Y = PlayerHurtBox.Y;
                        HitBox.Width = 50;
                        HitBox.Height = 100;
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
                        HitBox.X = PlayerHurtBox.X - 10;
                        HitBox.Y = PlayerHurtBox.Y - 25;
                        HitBox.Width = 100;
                        HitBox.Height = 30;
                        break;
                    case 4:
                        HitBox.X = PlayerHurtBox.X - 10;
                        HitBox.Y = PlayerHurtBox.Y + 95;
                        HitBox.Width = 100;
                        HitBox.Height = 30;
                        break;
                    case 2:
                        HitBox.X = PlayerHurtBox.X + 65;
                        HitBox.Y = PlayerHurtBox.Y;
                        HitBox.Width = 50;
                        HitBox.Height = 100;
                        break;
                    case 1:
                        HitBox.X = PlayerHurtBox.X - 45;
                        HitBox.Y = PlayerHurtBox.Y;
                        HitBox.Width = 50;
                        HitBox.Height = 100;
                        break;
                }
            }
        }
    }
}