using System;
using System.Collections.Generic;
using CodeBase.DisignPattersStudy;
using Unity.Mathematics;
using UnityEngine;
namespace CodeBase.GameLoop
{
    public class RoadSpawner : MonoBehaviour
    {
        [SerializeField] private int _countOfRoads;
        [SerializeField] private Vector3 _offset;
        private Vector3 _currentPosition;
        private GameObject roadPrefab;
        private IAssetProvider _assetProvider;
        private IGameFactory _gameFactory;

        private void Awake()
        {
            _assetProvider = new AssetProvider();
            _gameFactory = new GameFactory();
            roadPrefab = _assetProvider.GetPrefabFromPath(AssetPaths.ROAD_PATH);
        }
        private void Start()
        {
            for (int i = 0; i <= _countOfRoads; i++)
            {
                SpawnRoad(i,roadPrefab);
            }
        }
        public void SpawnRoad(int i,GameObject roadPrefab)
        {
            if(i == 0)
            {
                _gameFactory.CreateOject(roadPrefab);
            }
            else
            {
                var spawnPos =_currentPosition + _offset;
                _gameFactory.CreateOject(roadPrefab,spawnPos,quaternion.identity);
                _currentPosition = spawnPos;
            }
        }
    }
}