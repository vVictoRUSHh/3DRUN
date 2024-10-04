using UnityEngine;
namespace CodeBase.MyPlugins
{
    public static class DebugExtantion
    {
        public static void SuccesLog(string log )
        {
            Debug.Log($"<size=20><color=green>{log}</color></size>");
        }
        public static void FailedLog(string log )
        {
            Debug.Log($"<size=20><color=red>{log}</color></size>");
        }
        public static void WrongLog(string log )
        {
            Debug.Log($"<size=20><color=orange>{log}</color></size>");
        }
    }
}