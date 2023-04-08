using Assets.Scripts.Players.Abstractions.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Players.Abstractions
{
    public class Walk : IWalk
    {
        private CharacterController character;
        private Animator animator;
        private Transform transform;
        private Vector3 inputs;

        public Walk(Player person)
        {
            character = person.Character;
            animator = person.Animator;
            transform = person.Transform;
        }

        public void Walking(float velocidade)
        {
            var time = Time.deltaTime;
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");
            //var direction = new Vector3(horizontal, 0, vertical);

            inputs.Set(horizontal, 0, vertical);
            character.Move(inputs * time * velocidade);
            character.Move(Vector3.down * time);

            if (inputs != Vector3.zero)
            {
                animator.SetBool("Walking", true);
                //transform.forward = Vector3.Slerp(transform.forward, inputs, time * 10);
            }
            else
                animator.SetBool("Walking", false);

            
        }
    }
}
