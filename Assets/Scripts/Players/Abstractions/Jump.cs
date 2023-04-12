using Assets.Scripts.Players.Abstractions.Interfaces;
using Assets.Scripts.Util;
using System.Threading;
using UnityEngine;

namespace Assets.Scripts.Players.Abstractions
{
    public class Jump : IJump
    {
        private readonly Player player;

        public float jumpForce { get; set; } = 3f;

        public Jump(Player player)
        {
            this.player = player;
        }

        public float Jumping(float jumpForce, float gravityValue)
        {
            var ret = Mathf.Sqrt(jumpForce * -2f * gravityValue);
            player.Animator.SetBool("Jumping", true);                        
            return ret;
        }

        public bool JumpingValidation()
        {

            if (Input.GetKeyDown(KeyCode.Space) && player.IsGrounded())
            {
                return true;
            }

            //player.Animator.SetBool("Jumping", false);
            return false;
        }
    }
}
