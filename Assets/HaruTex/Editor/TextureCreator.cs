using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine;
using UnityEditor;
using UnityEditor.AssetImporters;

namespace HaruTex
{
    [ScriptedImporter(1, "HaruTex")]
    public class TextureCreator : ScriptedImporter
    {
        [SerializeField] Color color = Color.white;
        [SerializeField] int width = 16;
        [SerializeField] int height = 16;

        [SerializeField] TextureWrapMode wrapMode = TextureWrapMode.Repeat;
        [SerializeField] FilterMode filterMode = FilterMode.Trilinear;
        [SerializeField, Range(0, 16)] int anisoLevel = 4;

        public override void OnImportAsset(AssetImportContext ctx)
        {
            Texture2D texture = Generate();
            ctx.AddObjectToAsset("texture", texture);
            ctx.SetMainObject(texture);
        }

        Texture2D Generate()
        {
            Texture2D texture = new Texture2D(width, height);
            Color[] colors = Enumerable.Repeat(color, width * height).ToArray();

            texture.wrapMode = wrapMode;
            texture.filterMode = filterMode;
            texture.anisoLevel = anisoLevel;

            texture.SetPixels(colors);
            texture.Compress(true);
            texture.Apply(true, true);

            return texture;
        }
    }
}