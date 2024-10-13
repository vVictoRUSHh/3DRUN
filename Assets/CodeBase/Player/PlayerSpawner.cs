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
            var playerPosition = SaveSystem._instance._gameData.PlayerData._position;
            var playerRotation = SaveSystem._instance._gameData.PlayerData._rotation;
            _gameFactory.CreateOject(_assetProvider.GetPlayer(),playerPosition,playerRotation);
            _gameFactory.CreateHud(_assetProvider.GetHud());
        }
    }
}