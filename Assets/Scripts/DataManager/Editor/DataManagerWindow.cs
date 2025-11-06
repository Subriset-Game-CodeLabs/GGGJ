using Sirenix.OdinInspector.Editor;
using System;
using System.Linq;
using Audio;
using Player;
using UnityEditor;
public class DataManagerWindow : OdinMenuEditorWindow
    {
        private static Type[] _audioData = TypeCache.GetTypesDerivedFrom(typeof(AudioData))
            .OrderBy(d => d.Name)
            .ToArray();
        // private static Type[] _buildingArea = TypeCache.GetTypesDerivedFrom(typeof(BuildableTile))
        //     .OrderBy(d => d.Name)
        //     .ToArray();
        
        [MenuItem("GGGJ/DataEditor")]
        public static void OpenWindow()
        {
            GetWindow<DataManagerWindow>().Show();
        }
        protected override OdinMenuTree BuildMenuTree()
        {
            var menu = new OdinMenuTree();
            menu.Add("Player Setting", AssetDatabase.LoadAssetAtPath<PlayerSetting>("Assets/Resources/Manager/PlayerSetting.asset"));

            foreach(var data in _audioData)
            {
                menu.AddAllAssetsAtPath(data.Name, "Assets/", data, true, true);
            }
            


            // foreach(var data in _buildingArea)
            // {
            //     menu.AddAllAssetsAtPath(data.Name, "Assets/", data, true, true);
            // }
            return menu;
        }
    }
