using CodeBase.MyPlugins;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace CodeBase.Infrastracture
{
    public class Bootstrapper : MonoBehaviour
    {
        private Game _game;
        private void Awake()
        {
            _game = new Game();
            DontDestroyOnLoad(this);
            DebugExtantion.SuccesLog($"Loading Game loop scene!");
            LoadNewScene();
        }

        private void LoadNewScene()
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}