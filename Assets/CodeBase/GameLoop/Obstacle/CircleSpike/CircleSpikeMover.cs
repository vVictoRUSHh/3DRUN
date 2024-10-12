using UnityEngine;
namespace CodeBase.GameLoop.Obstacle.CircleSpike
{
    [RequireComponent(typeof(Rigidbody))]
    public class CircleSpikeMover : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private Rigidbody _rigidbody;
        void FixedUpdate()
        {
            Vector3 force = transform.forward * _speed;
            _rigidbody.AddForce(force, ForceMode.Force); // Используйте ForceMode.Force
        }
    }
}