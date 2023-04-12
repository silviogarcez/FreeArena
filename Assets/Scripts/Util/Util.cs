using Assets.Scripts.Players;
using UnityEngine;

namespace Assets.Scripts.Util
{
    public static class Util
    {
        public static bool IsGrounded(this Player player)
        {            
            return Physics.Raycast(player.Transform.position, Vector3.down, 0.5f);
        }
    }
}
