using System.Collections.Generic;
using CodeBase.DisignPattersStudy;
using UnityEngine;
namespace CodeBase.GameLoop
{
    public class RoadSpawner
    {
        private GameObject _roadPrefab;
        public List<GameObject> _roadList;
        private IAssetProvider _assetProvider;
        private IGameFactory _gameFactory;
        public RoadSpawner(IAssetProvider assetProvider, IGameFactory gameFactory) 
        {
            _assetProvider = assetProvider;
            _gameFactory = gameFactory;
            _roadList = new List<GameObject>
            {
                _assetProvider.GetPrefabFromPath(AssetPaths.ROAD_PATH),
                _assetProvider.GetPrefabFromPath(AssetPaths.ROAD_SECOND_PATH),
                _assetProvider.GetPrefabFromPath(AssetPaths.ROAD_THIRD_PATH)
            };
        }
        public void CreateRoad(float offset)
        {
            var _randomIndex = Random.Range(0, _roadList.Count);
            _roadPrefab = _roadList[_randomIndex];
            _gameFactory.CreateOject(_roadPrefab, new Vector3(0, 0,offset), Quaternion.identity);
        }
    }
}