using UnityEngine;

public interface IGameFactory
{
    void CreateOject(GameObject playerPrefab,Vector3 position,Quaternion rotation);
    void CreateOject(GameObject playerPrefab);
    void CreateHud(GameObject hudPrefab);
}