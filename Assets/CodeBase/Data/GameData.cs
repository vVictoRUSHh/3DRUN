using System;

namespace CodeBase.Data
{
    [Serializable]public  class GameData
    {
        public string Name;
        public string LvlName;
        public PlayerData PlayerData;
        public ResourcesData ResourcesData;
    }
}