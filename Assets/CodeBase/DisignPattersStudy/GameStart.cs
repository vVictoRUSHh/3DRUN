using CodeBase.DisignPattersStudy;
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
        _gameFactory.CreatePlayer(_assetProvider.GetPrefabFromPath(AssetPaths.PLAYER_PATH));
        _gameFactory.CreateHud(_assetProvider.GetPrefabFromPath(AssetPaths.HUD_PATH));
    }
}