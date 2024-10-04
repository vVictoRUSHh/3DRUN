using CodeBase.Data;
using CodeBase.SaveSystemDir;
using UnityEngine;
namespace CodeBase.Player
{
    public class Hero : MonoBehaviour
    {
        private PlayerData Bind(GameData data)
        {
            return data.PlayerData;
        }
        private void Update()
        {
            Bind(SaveSystem._instance._gameData)._position = transform.position;
            Bind(SaveSystem._instance._gameData)._rotation = transform.rotation;
        }
    }
}