using UnityEngine;
namespace CodeBase.DisignPattersStudy
{
    public class AssetProvider : IAssetProvider
    {
        public GameObject GetPlayer()
        {
            return Resources.Load<GameObject>(AssetPaths.PLAYER_PATH);
        }
        public GameObject GetHud()
        {
            return Resources.Load<GameObject>(AssetPaths.HUD_PATH);
        }
        public GameObject GetPrefabFromPath(string path)
        {
            return Resources.Load<GameObject>(path);
        }
    }
}