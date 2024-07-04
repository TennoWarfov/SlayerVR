using UnityEngine;

namespace Units
{
    public class AnimatedUnit : MonoBehaviour
    {
        [SerializeField] private PhysicMaterial defaultFriction;
        [SerializeField] private PhysicMaterial zeroFriction;

        [SerializeField] private Collider leftCollider;
        [SerializeField] private Collider rightCollider;

        public void SetLeftFriction()
        {
            leftCollider.material = defaultFriction;
            rightCollider.material = zeroFriction;
        }

        public void SetRightFriction()
        {
            leftCollider.material = zeroFriction;
            rightCollider.material = defaultFriction;
        }
    }
}