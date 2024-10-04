using System;
using System.IO;
using CodeBase.MyPlugins;
using UnityEngine;
namespace CodeBase.SaveSystemDir
{
    public class DataService : IDataService
    {
        private string _filePath;
        private GameData _gameData;
        private JsonSerializer _serializer;
        private string _fileExtension;
        public DataService(JsonSerializer serializer)
        {
            _filePath = Application.persistentDataPath;
            _serializer = serializer;
            _fileExtension = "json";
        }
        public void SaveGame(GameData data)
        {
            string fileLocation = GetPathToFile(data.Name);
            string currentData = _serializer.Serialize(data);
            File.WriteAllText(fileLocation,currentData);
            DebugExtantion.SuccesLog($"Game was succes saved!");
        }

        private string GetPathToFile(string fileName)
        {
            return Path.Combine(_filePath, string.Concat(fileName, ".", _fileExtension));
        }

        public GameData LoadGame(string json)
        {
            string fileLocation = GetPathToFile(json);
            if (!File.Exists(fileLocation))
            {
                throw new Exception($"File is not exist!");
            } 
            DebugExtantion.SuccesLog($"Loading was succed!");
            return _serializer.Deserialize<GameData>(File.ReadAllText(fileLocation));
        }
        public void DeleteGame(string name){
            if (File.Exists(name))File.Delete(name);
        }
    }
}