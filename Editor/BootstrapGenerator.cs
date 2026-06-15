using System.Linq;
using UnityEditor;
using UnityEngine;

namespace LLib.Editor
{
    [InitializeOnLoad]
    public static class BootstrapGenerator
    {
        static BootstrapGenerator()
        {
            if (BootstrapSetting.Instance != null)
                return;
            
            var assetPath = $"Assets/{nameof(BootstrapSetting)}.asset";

            var setting = AssetDatabase.LoadAssetAtPath<BootstrapSetting>(assetPath);
            if (setting == null)
            {
                setting = ScriptableObject.CreateInstance<BootstrapSetting>();
                AssetDatabase.CreateAsset(setting, assetPath);
                AssetDatabase.SaveAssets();
            }


            var preloadedAssets = PlayerSettings.GetPreloadedAssets().ToList();
            preloadedAssets.RemoveAll(a => a == null);

            if (!preloadedAssets.Contains(setting))
            {
                preloadedAssets.Add(setting);
                PlayerSettings.SetPreloadedAssets(preloadedAssets.ToArray());
            }
        }
    }
}

