using UnityEngine;

namespace Units
{
    public class PhysicalUnit : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private ConfigurableJoint joint;

        private Transform _pelvisTransform;

        private void Awake()
        {
            _pelvisTransform = transform;
        }

        private void FixedUpdate()
        {
            var toTarget = target.position - _pelvisTransform.position;
            var toTargetXZ = new Vector3(toTarget.x, 0f, toTarget.z);
            var rotation = Quaternion.LookRotation(toTargetXZ);

            joint.targetRotation = Quaternion.Inverse(rotation);
        }
    }
}