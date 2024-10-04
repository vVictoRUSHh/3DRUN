using UnityEngine;

public interface IGameFactory
{
    void CreatePlayer(GameObject playerPrefab);
    void CreateHud(GameObject hudPrefab);
}