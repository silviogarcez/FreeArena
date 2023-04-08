using Assets.Scripts.Players.Abstractions.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Players.Abstractions
{
    [RequireComponent(typeof(Rigidbody))]
    public class Jump : IJump
    {
        private readonly Player person;                
        public float groundDistance { get; set; } = 0.5f;

        public Jump(Player person)
        {
            this.person = person;            
        }

        public void Jumping(float jumpForce)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                person.Rigidbody.velocity = Vector3.up * jumpForce;
                //person.Rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);                
            }            

        }

        public bool IsGrounded()
        {
            return Physics.Raycast(person.Transform.position, Vector3.down, groundDistance);
        }
    }
}
