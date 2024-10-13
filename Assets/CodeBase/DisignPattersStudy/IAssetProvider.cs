using UnityEngine;
namespace CodeBase.DisignPattersStudy
{
    public interface IAssetProvider
    {
        public GameObject GetHud();
        public GameObject GetPlayer();
        public GameObject GetPrefabFromPath(string path);
    }
}