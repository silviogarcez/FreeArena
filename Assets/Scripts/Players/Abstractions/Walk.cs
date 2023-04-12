using Assets.Scripts.Players.Abstractions.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Players.Abstractions
{
    public class Walk : IWalk
    {
        private readonly Player person;

        private readonly IJump jump;        
        public float gravityValue { get; set; } = -9.81f * 3;
        public float groundDistance { get; set; } = 0.5f;
        public float jumpForce { get; set; } = 3f;

        Vector3 velocity;

        public Walk(Player person)
        {
            this.person = person;
            this.jump = new Jump();
        }

        public void Walking(float velocidade)
        {
            var time = Time.deltaTime;
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");

            var direction = person.Transform.right * horizontal + person.Transform.forward * vertical;

            if (IsGrounded() && velocity.y < 0)
                velocity.y = -2f;

            person.Character.Move(direction * time * velocidade);

            if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
            {                
                velocity.y = jump.Jumping(jumpForce, gravityValue);
            }
            else
            {
                if (horizontal != 0 && vertical != 0)
                    person.Animator.SetBool("Walking", true);
                else
                    person.Animator.SetBool("Walking", false);
            }

            velocity.y += gravityValue * time;

            person.Character.Move(velocity * time);                
        }

        public bool IsGrounded()
        {
            return Physics.Raycast(person.Transform.position, Vector3.down, groundDistance);
        }
    }
}
