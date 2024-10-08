using UnityEngine;
namespace CodeBase.DisignPattersStudy
{
    public interface IAssetProvider
    {
        public GameObject GetPrefabFromPath(string path);
    }
}