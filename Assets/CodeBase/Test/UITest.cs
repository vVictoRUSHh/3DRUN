using CodeBase.MyPlugins;
using CodeBase.SaveSystemDir;
using TMPro;
using UnityEngine;

namespace CodeBase.Test
{
    public class UITest : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;
        string jsonName = SaveSystem._instance._gameData.Name;
        private void Start()
        {
            _text.text = SaveSystem._instance._gameData.Name;
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                SaveSystem._instance.LoadGame(jsonName);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                SaveSystem._instance.SaveGame();
            }
        }
    }
}