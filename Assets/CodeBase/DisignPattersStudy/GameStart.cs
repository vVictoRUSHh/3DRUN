using CodeBase.DisignPattersStudy;
using CodeBase.SaveSystemDir;
using UnityEngine;

public class GameStart : MonoBehaviour
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
        _gameFactory.CreatePlayer(_assetProvider.GetPrefabFromPath(AssetPaths.PLAYER_PATH),playerPosition,playerRotation);
        _gameFactory.CreateHud(_assetProvider.GetPrefabFromPath(AssetPaths.HUD_PATH));
    }
}