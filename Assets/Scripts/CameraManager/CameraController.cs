using UnityEngine;

namespace Assets.Scripts.Cameras
{
    public class CameraController : MonoBehaviour
    {
        public float rotationX { get; set; } = 0f;
        public float rotationY { get; set; } = 0f;
        public float sens { get; set; } = 2f;        

        

        // Start is called before the first frame update
        void Start()
        {

            Debug.Log("X:" + transform.position.x);
            Debug.Log("Y:" + transform.position.y);
            rotationX = transform.position.x;
            rotationY = transform.position.y;
            //transform.localRotation = = Vector3()
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButton(1))
            {                
                rotationX += Input.GetAxis("Mouse X") * sens;
                rotationY += Input.GetAxis("Mouse Y") * sens;
                transform.localRotation = Quaternion.Euler(-rotationY, rotationX, 0);
                //Debug.Log("X:" + transform.position.x);
                //Debug.Log("Y:" + transform.position.x);
            }
        }
    }
}

