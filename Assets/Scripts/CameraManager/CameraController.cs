using Assets.Scripts.Players;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.Cameras
{
    public class CameraController : MonoBehaviour
    {
        public float rotationX { get; set; } = 0;
        public float rotationY { get; set; } = 0;
        public float sens { get; set; } = 2f;        
        public GameObject Player { get; set; }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButton(1))
            {
                Player = GameObject.Find("Warrior");
                rotationX += Input.GetAxis("Mouse X") * sens;
                rotationY += Input.GetAxis("Mouse Y") * sens;
                transform.localRotation = Quaternion.Euler(-rotationY, rotationX, 0).normalized;
                Player.transform.rotation = Quaternion.Euler(0, 0, Camera.main.transform.forward.z);
            }
        }
    }
}

