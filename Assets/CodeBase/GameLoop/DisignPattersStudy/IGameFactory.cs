using UnityEngine;

public interface IGameFactory
{
    void CreateOject(GameObject playerPrefab,Vector3 position,Quaternion rotation);
    void CreateHud(GameObject hudPrefab);
}