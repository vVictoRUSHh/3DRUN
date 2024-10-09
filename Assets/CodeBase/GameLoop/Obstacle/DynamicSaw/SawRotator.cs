using UnityEngine;
namespace CodeBase.GameLoop.Obstacle.DynamicSaw
{
    public class SawRotator : MonoBehaviour
    {
        [SerializeField] private Transform sawTransform;
        [SerializeField] private float _speed;
        private void Rotate(float speed)
        {
            sawTransform.rotation *= Quaternion.Euler(1f * Time.deltaTime * speed, 0f, 0f);
        }

        private void Update()
        {
            Rotate(_speed);
        }
    }
}