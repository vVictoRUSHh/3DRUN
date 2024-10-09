using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

namespace CodeBase.GameLoop.Obstacle.SpikeTrap
{
    public class SpikeTrapMover : MonoBehaviour
    {
        
        [SerializeField] private Transform _lowPoint;
        [SerializeField] private Transform _hightPoint;
        [SerializeField] private GameObject _spikes; 
        public float moveSpeed = 2f; // Скорость движения

        private void Start()
        {
            StartCoroutine(MoveSpikes());
        }

        private IEnumerator MoveSpikes()
        {
            while (true) 
            {
                yield return MoveToPosition(_hightPoint.position);
                yield return MoveToPosition(_lowPoint.position);
            }
        }

        private IEnumerator MoveToPosition(Vector3 targetPosition)
        {
            while (Vector3.Distance(_spikes.transform.position, targetPosition) > 0.01f)
            {
                _spikes.transform.position = Vector3.MoveTowards(_spikes.transform.position, targetPosition, moveSpeed * Time.deltaTime);
                yield return null;
            }
            _spikes.transform.position = targetPosition;
        }
        
        
    }
}