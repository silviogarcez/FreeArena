using UnityEngine;
using UnityEngine.TextCore.Text;

namespace Assets.Scripts.Players
{
    public class Warrior : MonoBehaviour
    {
        private CharacterController character;
        private Animator animator;        
        private Player person;
        float velocidade = 5;
        float jumpForce = 10f;        
        public Controls controls;

        void Start()
        {
            character = GetComponent<CharacterController>();
            animator = GetComponent<Animator>();            

            person = new Player(character, animator, transform, velocidade, jumpForce);
        }

        // Update is called once per frame
        void Update()
        {
            person.Actions();
        }
    }
}
