using UnityEngine;
namespace CodeBase.DisignPattersStudy
{
    public class GameFactory : IGameFactory
    {
        public void CreatePlayer(GameObject playerPrefab) 
        {
            Object.Instantiate(playerPrefab);
        }
        public void CreateHud(GameObject hudPrefab) 
        {
           Object.Instantiate(hudPrefab);
        }
    }
}