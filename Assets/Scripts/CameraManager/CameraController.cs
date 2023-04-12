using Assets.Scripts.Players;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.Cameras
{
    public class CameraController : MonoBehaviour
    {
        public float rotationX { get; set; } = 0;
        public float rotationY { get; set; } = 0;
        public float sens { get; set; } = 102f;        
        public GameObject Player { get; set; }

        // Update is called once per frame
        void Update()
        {
            var mousecliked = false;

            if (Input.GetMouseButton(1))
            {
                mousecliked = true;
                Player = GameObject.Find("Warrior");
                rotationX += Input.GetAxis("Mouse X") * sens * Time.deltaTime;
                rotationY += Input.GetAxis("Mouse Y") * sens * Time.deltaTime;
                transform.localRotation = Quaternion.Euler(-rotationY, rotationX, 0).normalized;
            }

            if (mousecliked) 
            {
                var CharacterRotation = Camera.main.transform.rotation;
                CharacterRotation.x = 0;
                CharacterRotation.z = 0;

                Player.transform.rotation = Quaternion.LookRotation(Camera.main.transform.forward, Camera.main.transform.up);
                mousecliked = false;
            }
        }
    }
}

