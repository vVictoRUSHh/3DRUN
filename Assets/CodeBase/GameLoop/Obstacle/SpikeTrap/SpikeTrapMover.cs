using System.Collections;
using CodeBase.Player;
using UnityEngine;
namespace CodeBase.GameLoop.Obstacle.SpikeTrap
{
    public class SpikeTrapMover : MonoBehaviour
    {
        [SerializeField] private Transform _lowPoint;
        [SerializeField] private Transform _hightPoint;
        [SerializeField] private GameObject _spikes; 
        public float moveSpeed = 2f;
        private void Start()
        {
            _spikes.transform.position = _lowPoint.transform.position;
        }

        private void OnTriggerStay(Collider other)
        {
            if (other.TryGetComponent(out PlayerMove playerMove))
            {
                StartCoroutine(SpikeOpenning(1f));
                print($" I ditect something!");
            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.TryGetComponent(out PlayerMove playerMove))
            {
                StartCoroutine(SpikeClosing(1f));
                print($" I exit!");
            }
        } 
        [ContextMenu("Open SpykeTrap")]
        private IEnumerator SpikeOpenning(float spykeDuration)
        {
             _spikes.transform.position = Vector3.MoveTowards(_spikes.transform.position, _hightPoint.position,moveSpeed * Time.deltaTime); 
            yield break;
        }
        [ContextMenu("Open SpykeTrap")]
        private IEnumerator SpikeClosing(float spykeDuration)
        {
            _spikes.transform.position = Vector3.MoveTowards(_spikes.transform.position,_lowPoint.position,moveSpeed);
            yield break;
        }
    }
}