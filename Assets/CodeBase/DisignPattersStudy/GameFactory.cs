using UnityEngine;
namespace CodeBase.DisignPattersStudy
{
    public class GameFactory : IGameFactory
    {
        private IAssetProvider _assetProvider;
        public void CreateOject(GameObject playerPrefab, Vector3 position, Quaternion rotation)
        {
            Object.Instantiate(playerPrefab,position,rotation);
        }
        public void CreateOject(GameObject playerPrefab)
        {
            Object.Instantiate(playerPrefab);
        }
        public void CreateHud(GameObject hudPrefab) 
        {
           Object.Instantiate(hudPrefab);
        }
    }
}