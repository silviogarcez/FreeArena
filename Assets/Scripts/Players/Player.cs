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
        private Walk walk { get; set; }        

        public Player(CharacterController character, Animator animator, Transform transform, float velocidade)
        {
            Character = character;
            Animator = animator;
            Transform = transform;
            Velocidade = velocidade;
            walk = new Walk(this);
        }

        private void Idle()
        {
            //throw new System.NotImplementedException();
        }

        public void Actions()
        {
            Idle();
            walk.Walking(Velocidade);
        }
    }
}

