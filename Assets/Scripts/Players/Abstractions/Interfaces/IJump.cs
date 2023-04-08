namespace Assets.Scripts.Players.Abstractions.Interfaces
{
    public interface IJump
    {
        public void Jumping(float jumpForce);

        public bool IsGrounded();
    }
}
