using CodeBase.DisignPattersStudy;
using CodeBase.Player;
using UnityEngine;
namespace CodeBase.GameLoop
{
    public class RoadTrigger : MonoBehaviour
    {
        [SerializeField] private float _offset;
        private RoadSpawner _roadSpawner;
        private void Start()
        {
            _roadSpawner = new RoadSpawner(new AssetProvider(),new GameFactory());
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out PlayerMove playerMove))
            {
             _roadSpawner.CreateRoad(_offset);  
            }
        }
    }
}