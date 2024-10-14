using CodeBase.DisignPattersStudy;
using CodeBase.SaveSystemDir;
using UnityEngine;
namespace CodeBase.Player
{
    public class PlayerSpawner : MonoBehaviour
    {
        private IGameFactory _gameFactory;
        private IAssetProvider _assetProvider;
        private void Awake()
        {
            _gameFactory = new GameFactory();
            _assetProvider = new AssetProvider();
        }
        private void Start()
        {
            _gameFactory.CreateOject(_assetProvider.GetPlayer(),new Vector3(0.4f,2,3.4f),Quaternion.identity);
        }
    }
}