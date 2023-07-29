using UnityEditor;

namespace Editor
{
    public class TextureAssetCreator
    {
        [MenuItem("Assets/Create/HaruTex")]
        public static void CreateNewAsset()
            => ProjectWindowUtil.CreateAssetWithContent("New Harutex.harutex", "");
    }
}