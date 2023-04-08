using UnityEngine;
using UnityEngine.TextCore.Text;

namespace Assets.Scripts.Players
{
    public class Warrior : MonoBehaviour
    {
        private CharacterController character;
        private Animator animator;
        private Rigidbody rigidbody;
        private Player person;
        float velocidade = 5;
        float jumpForce = 7f;        
        public Controls controls;

        void Start()
        {
            character = GetComponent<CharacterController>();
            animator = GetComponent<Animator>();
            rigidbody = GetComponent<Rigidbody>();

            person = new Player(character, animator, transform, rigidbody, velocidade, jumpForce);
        }

        // Update is called once per frame
        void Update()
        {
            person.Actions();
        }
    }
}
