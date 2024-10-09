using CodeBase.Player;
using UnityEngine;
namespace CodeBase.GameLoop.Obstacle
{
    public class StationaryTrain : MonoBehaviour,IObstacle
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _duration;
        [SerializeField] private Transform _start;
        [SerializeField] private Transform _finish;
        
        public void Move()
        {
            transform.position -= Vector3.Slerp(_start.position, _finish.position, _duration) * Time.deltaTime * _speed;
        }
        private void Update()
        {
            Move();
        }
        public void Collision()
        {
            bool playerCollision = TryGetComponent(out PlayerMove playerMove);
            if (playerCollision)
            {
                print($"I KNOCK PLAYER!");
            }
        }
    }
}