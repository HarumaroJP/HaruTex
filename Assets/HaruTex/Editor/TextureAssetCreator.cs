using UnityEditor;

namespace HaruTex
{
    public class TextureAssetCreator
    {
        [MenuItem("Assets/Create/HaruTex")]
        public static void CreateNewAsset()
            => ProjectWindowUtil.CreateAssetWithContent("New Harutex.harutex", "");
    }
}