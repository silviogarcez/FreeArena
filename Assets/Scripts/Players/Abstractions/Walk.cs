using Assets.Scripts.Players.Abstractions.Interfaces;
using Assets.Scripts.Util;
using UnityEngine;

namespace Assets.Scripts.Players.Abstractions
{
    public class Walk : IWalk
    {
        private readonly Player player;

        private readonly IJump jump;        
        public float gravityValue { get; set; } = -9.81f * 3;
        
        public float jumpForce { get; set; } = 3f;

        Vector3 velocity;

        public Walk(Player player)
        {
            this.player = player;
            this.jump = new Jump(player);
        }

        public void Walking(float velocidade)
        {
            var time = Time.deltaTime;
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");

            var direction = player.Transform.right * horizontal + player.Transform.forward * vertical;

            if (player.IsGrounded() && velocity.y < 0)
                velocity.y = -2f;

            player.Character.Move(direction * time * velocidade);

            if (jump.JumpingValidation())
            {                
                velocity.y = jump.Jumping(jumpForce, gravityValue);
            }
            else
            {
                player.Animator.SetBool("Walking", true);
                //if (horizontal != 0 && vertical != 0)
                //    person.Animator.SetBool("Walking", true);
                //else
                    
            }
            //person.Animator.SetBool("Jumping", false);

            velocity.y += gravityValue * time;

            player.Character.Move(velocity * time);

            

        }


    }
}
