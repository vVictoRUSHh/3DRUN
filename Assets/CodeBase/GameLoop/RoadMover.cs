using UnityEngine;
namespace CodeBase.GameLoop
{
    public class RoadMover : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private GameObject road;
        private void Update()
        {
            road.transform.position += new Vector3(0, 0, -2) * Time.deltaTime * _speed;
        }
    }
}