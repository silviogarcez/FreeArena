namespace Assets.Scripts.Players.Abstractions.Interfaces
{
    public interface IJump
    {
        public float Jumping(float jumpForce, float gravityValue);

        public bool JumpingValidation();
    }
}
