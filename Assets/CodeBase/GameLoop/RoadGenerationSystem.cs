using System;
using System.Collections.Generic;
using CodeBase.DisignPattersStudy;
using Unity.Mathematics;
using UnityEngine;
namespace CodeBase.GameLoop
{
    public class RoadGenerationSystem : MonoBehaviour
    {
        [SerializeField] private int _countOfRoads;
        [SerializeField] private float _speed;
        [SerializeField]private List<Road>_roads;
        private IAssetProvider _assetProvider;
        private IGameFactory _gameFactory;

        private void Awake()
        {
            _assetProvider = new AssetProvider();
            _gameFactory = new GameFactory();
        }
        private void Start()
        {
            for (int i = 0; i <= _countOfRoads; i++)
            {
                SpawnRoad(i);
            }
        }

        public void SpawnRoad(int i )
        {
            GameObject roadPrefabFromPath = _assetProvider.GetPrefabFromPath(AssetPaths.ROAD_PATH);
            var road = roadPrefabFromPath.GetComponent<Road>();
            _roads.Add(road);
            if(i==0)_gameFactory.CreateOject(roadPrefabFromPath,_roads[i]._startPoint.position,quaternion.identity);
            else _gameFactory.CreateOject(roadPrefabFromPath,_roads[i - 1]._endPoint.position,quaternion.identity);
        }
    }
}