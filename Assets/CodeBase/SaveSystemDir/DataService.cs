using System;
using System.IO;
using CodeBase.Data;
using CodeBase.MyPlugins;
using UnityEngine;
namespace CodeBase.SaveSystemDir
{
    public class DataService : IDataService
    {
        private string _filePath;
        private GameData _gameData;
        private JsonSerializer _serializer;
        private AESCrypto _encrypter;
        private string _fileExtension;
        public DataService(JsonSerializer serializer)
        {
            _filePath = Application.persistentDataPath;
            _serializer = serializer;
            //_encrypter = new AESCrypto("%@&)##_<%\"'=}|^)|&{|]--['(,@!>=:");
            _fileExtension = "json";
        }

        public string EncryptedJson(string json)
        {
            return _encrypter.Encrypt(json);
        }

        public string DecryptedJson(string json)
        {
            return _encrypter.Decrypt(json);
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
            return Path.Combine(_filePath,string.Concat(fileName, ".", _fileExtension));
        }
        public GameData LoadGame(string json)
        {
            string fileLocation = GetPathToFile(json);
            if (!File.Exists(fileLocation))
            {
                throw new Exception($"File is not exist!");
            } 
            //string encryptedJson = File.ReadAllText(fileLocation);
            DebugExtantion.SuccesLog($"Loading was successful!");
            return _serializer.Deserialize<GameData>(File.ReadAllText(fileLocation));
        }
        public void DeleteGame(string name){
            if (File.Exists(name))File.Delete(name);
        }
    }
}