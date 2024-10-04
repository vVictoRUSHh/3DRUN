namespace CodeBase.SaveSystemDir
{
    public interface IDataService
    {
        public void SaveGame(GameData gameData);
        public GameData LoadGame(string json);
        public void DeleteGame(string name);
    }
}