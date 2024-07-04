using UnityEngine;

namespace Units
{
    public class IgnoreCollisions : MonoBehaviour
    {
        [SerializeField] private Collider[] allColliders;

        private void Awake()
        {
            foreach (var collider1 in allColliders)
            {
                foreach (var collider2 in allColliders)
                {
                    Physics.IgnoreCollision(collider1, collider2, true);
                }
            }
        }
    }
}