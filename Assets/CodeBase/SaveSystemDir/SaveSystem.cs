using UnityEngine;

namespace CodeBase.SaveSystemDir
{
    public class SaveSystem : MonoBehaviour
    {
        [SerializeField] public GameData _gameData;
        public static SaveSystem _instance;
        private IDataService _dataService;


        private void Start()
        {
            _dataService = new DataService(new JsonSerializer());
        }

        public void NewGame()
        {
            _gameData = new GameData
            {
                Name = "New Game!",
                LvlName = "Zalupa"
            };
        }

        public void SaveGame()
        {
            _dataService.SaveGame(_gameData);
        }

        public void LoadGame(string gameName)
        {
            _gameData = _dataService.LoadGame(gameName);
        }

        public void DeleteGame(string gameName)
        { 
            _dataService.DeleteGame(gameName);
        }

        private void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(gameObject);
            }
            else
            {
                _instance = this;
                DontDestroyOnLoad(gameObject); 
            }
        }
    }
}