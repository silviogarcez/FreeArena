using Assets.Scripts.Players.Abstractions;
using Assets.Scripts.Players.Abstractions.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Players
{
    public class Player : IPlayer
    {
        public CharacterController Character { get; }
        public Animator Animator { get; }
        public Transform Transform { get; }
        public Rigidbody Rigidbody { get; }
        public float Velocidade { get; }
        public float JumpForce { get; }
        private Walk walk { get; set; }
        private Jump jump { get; set; }

        public Player(CharacterController character, Animator animator, Transform transform, Rigidbody rigidbody, float velocidade, float jumpForce)
        {
            Character = character;
            Animator = animator;
            Transform = transform;
            Rigidbody = rigidbody;
            Velocidade = velocidade;
            JumpForce = jumpForce;
            walk = new Walk(this);
            jump = new Jump(this);
        }

        private void Idle()
        {
            //throw new System.NotImplementedException();
        }

        public void Actions()
        {
            //Idle();
            walk.Walking(Velocidade);
            jump.Jumping(JumpForce);
        }
    }
}

