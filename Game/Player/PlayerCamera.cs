using Raylib_cs;
using PlayerN;
using static Raylib_cs.Raylib;

namespace PlayerN
{
    
    public partial class Player
    {
        public Camera2D PlayerCam{get; private set;}

        private void HandleCamera()
        {
            Camera2D tempCam = PlayerCam;
            tempCam.Target.X = PlayerHurtBox.X + PlayerHurtBox.Width / 2;
            tempCam.Target.Y = PlayerHurtBox.Y + PlayerHurtBox.Height / 2;
            PlayerCam = tempCam;
        }

    }
}