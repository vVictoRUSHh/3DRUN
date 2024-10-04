using UnityEngine;

public interface IGameFactory
{
    void CreatePlayer(GameObject playerPrefab,Vector3 position,Quaternion rotation);
    void CreateHud(GameObject hudPrefab);
}