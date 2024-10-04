using CodeBase.SaveSystemDir;
using UnityEngine;
namespace CodeBase.Player
{
    public class Hero : MonoBehaviour
    {
        [SerializeField] private PlayerData _playerData;

        private void Bind(PlayerData data)
        {
            _playerData = data;
            transform.position = data._position;
            transform.rotation = data._rotation;
        }

        private void Start()
        {
            Bind(SaveSystem._instance._gameData.PlayerData);
        }

        private void Update()
        {
            SaveSystem._instance._gameData.PlayerData._position = transform.position;
            SaveSystem._instance._gameData.PlayerData._rotation = transform.rotation;
        }
    }
}