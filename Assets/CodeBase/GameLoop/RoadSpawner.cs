using CodeBase.DisignPattersStudy;
using UnityEngine;
namespace CodeBase.GameLoop
{
    public class RoadSpawner
    {
        private GameObject roadPrefab;
        private IAssetProvider _assetProvider;
        private IGameFactory _gameFactory;
        public RoadSpawner(IAssetProvider assetProvider, IGameFactory gameFactory) 
        {
            _assetProvider = assetProvider;
            _gameFactory = gameFactory;
            roadPrefab = _assetProvider.GetPrefabFromPath(AssetPaths.ROAD_PATH);
        }
        public void CreateRoad(float offset)
        {
            _gameFactory.CreateOject(roadPrefab, new Vector3(0, 0,offset), Quaternion.identity);
        }
    }
}