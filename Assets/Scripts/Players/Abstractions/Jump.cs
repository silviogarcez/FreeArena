using Assets.Scripts.Players.Abstractions.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Players.Abstractions
{ 
    public class Jump : IJump
    {        
        public float jumpForce { get; set; } = 3f;        
        public float Jumping(float jumpForce, float gravityValue)
        {            
                return Mathf.Sqrt(jumpForce * -2f * gravityValue);            
        }
    }
}
