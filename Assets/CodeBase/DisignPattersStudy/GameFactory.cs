using UnityEngine;
namespace CodeBase.DisignPattersStudy
{
    public class GameFactory : IGameFactory
    {
        public void CreatePlayer(GameObject playerPrefab, Vector3 position, Quaternion rotation)
        {
            Object.Instantiate(playerPrefab,position,rotation);
        }

        public void CreateHud(GameObject hudPrefab) 
        {
           Object.Instantiate(hudPrefab);
        }
    }
}