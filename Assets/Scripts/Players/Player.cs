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
        public float Velocidade { get; }
        public float JumpForce { get; }
        private Walk walk { get; set; }        

        public Player(CharacterController character, Animator animator, Transform transform, float velocidade, float jumpForce)
        {
            Character = character;
            Animator = animator;
            Transform = transform;
            Velocidade = velocidade; 
            JumpForce = jumpForce;
            walk = new Walk(this);
        }

        public void Actions()
        {            
            walk.Walking(Velocidade);
        }
    }
}

