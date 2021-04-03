namespace Zinnia.Utility
{
    using UnityEditor;
    using UnityEngine;

    public abstract class BasePrefabCreator : ScriptableObject
    {
        protected const string topLevelMenuLocation = "Window/";
        protected const string subLevelMenuLocation = "Prefabs/";
        protected const string packageRoot = "Packages";

        protected static void CreatePrefab(string assetPath)
        {
            Object toInstantiate = AssetDatabase.LoadAssetAtPath(assetPath, typeof(Object));
            if (toInstantiate == null)
            {
                Debug.LogError(string.Format("Asset {0} cannot be loaded", assetPath));
                return;
            }

            Selection.activeObject = PrefabUtility.InstantiatePrefab(toInstantiate);
        }
    }
}