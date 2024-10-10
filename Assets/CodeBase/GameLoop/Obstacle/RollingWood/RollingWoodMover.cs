using UnityEngine;
namespace CodeBase.GameLoop.Obstacle.RollingWood
{
    [RequireComponent(typeof(Rigidbody))]
    public class RollingWoodMover : MonoBehaviour
    {
        [SerializeField] private Transform _targetPosition;
        [SerializeField] private float _speed;
        [SerializeField] private Rigidbody _rigidbody;

        void FixedUpdate()
        {
            Vector3 force = transform.forward * _speed;
            _rigidbody.AddForce(force, ForceMode.Acceleration);
        }
    }
}