using Assets.Scripts.Players.Abstractions.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Players.Abstractions
{
    public class Walk : IWalk
    {
        private readonly Player person;                
        private Vector3 inputs;

        public Walk(Player person)
        {
            this.person = person;            
        }

        public void Walking(float velocidade)
        {
            var time = Time.deltaTime;
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");
            //var direction = new Vector3(horizontal, 0, vertical);

            inputs.Set(horizontal, 0, vertical);
            person.Character.Move(inputs * time * velocidade);
            //person.Character.Move(Vector3.down * time);

            if (inputs != Vector3.zero)
            {
                person.Animator.SetBool("Walking", true);
                //transform.forward = Vector3.Slerp(transform.forward, inputs, time * 10);
            }
            else
                person.Animator.SetBool("Walking", false);
        }
    }
}
