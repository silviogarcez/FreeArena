using UnityEngine;

namespace Assets.Scripts.Players
{
    public class Warrior : MonoBehaviour
    {
        private CharacterController character;
        private Animator animator;
        private Player person;
        float velocidade = 5;
        private Vector3 inputs;
        public Controls controls;

        void Start()
        {
            character = GetComponent<CharacterController>();
            animator = GetComponent<Animator>();
            person = new Player(character, animator, transform, velocidade);
        }

        // Update is called once per frame
        void Update()
        {
            person.Actions();
        }
    }
}
