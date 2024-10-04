// using CodeBase.SaveSystemDir;
// using UnityEditor;
// using UnityEngine;
// namespace CodeBase.Test
// {
//     [CustomEditor(typeof(SaveSystem))]
//     public class SaveManagerEditor : UnityEditor.Editor
//     {
//         
//         public override void OnInspectorGUI()
//         {
//             SaveSystem saveSystem = (SaveSystem)target;
//
//             DrawDefaultInspector();
//             if (GUILayout.Button("Save Game"))
//             {
//                 SaveSystem._instance.SaveGame();
//             }
//             if (GUILayout.Button("Load Game"))
//             {
//                 SaveSystem._instance.LoadGame(jsonName);
//             } 
//             if (GUILayout.Button("Delete Game"))
//             {
//                 SaveSystem._instance.SaveGame();
//             }
//         }
//     }
// }