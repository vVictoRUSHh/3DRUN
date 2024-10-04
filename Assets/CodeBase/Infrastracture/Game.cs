using CodeBase.MyPlugins;
using CodeBase.Services;
using UnityEngine;
namespace CodeBase.Infrastracture
{
    public class Game
    {
        public static IInputService _inputService;
        public Game()
        {
            InputRegistration();
        }
        private void InputRegistration()
        {
            if (Application.isEditor)
            {
                _inputService = new EditorInputService();
                DebugExtantion.SuccesLog("PC input Registration was Succesfull!");
            }
            else
            {
                _inputService = new MobileInputService();
                Debug.Log($"Mobile input Registration was Succesfull!");
            }
        }

    }
}