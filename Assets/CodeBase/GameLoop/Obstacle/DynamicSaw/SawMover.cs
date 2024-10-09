using System.Collections;
using UnityEngine;

namespace CodeBase.GameLoop.Obstacle.DynamicSaw
{
    public class SawMover : MonoBehaviour
    {
        [SerializeField] private Transform _leftSide;
        [SerializeField] private Transform _rightSide;
        [SerializeField] private GameObject _saw; 
        public float moveSpeed = 2f; // Скорость движения

        private void Start()
        {
            StartCoroutine(MoveSaw());
        }

        private IEnumerator MoveSaw()
        {
            while (true) 
            {
                yield return MoveToPosition(_rightSide.position);
                yield return MoveToPosition(_leftSide.position);
            }
        }

        private IEnumerator MoveToPosition(Vector3 targetPosition)
        {
            while (Vector3.Distance(_saw.transform.position, targetPosition) > 0.01f)
            {
                _saw.transform.position = Vector3.MoveTowards(_saw.transform.position, targetPosition, moveSpeed * Time.deltaTime);
                yield return null;
            }
            _saw.transform.position = targetPosition;
        }
    }
}