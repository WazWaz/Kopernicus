// Material wrapper generated by shader translator tool
using System;
using System.Reflection;
using UnityEngine;

using Kopernicus.MaterialWrapper;

namespace Kopernicus
{
    namespace Configuration
    {
        public class DiffuseWrapLoader : DiffuseWrap
        {
            // Texture, default = "white" { }
            [ParserTarget("mainTex", optional = true)]
            public Texture2DParser mainTexSetter
            {
                get { return mainTex; }
                set { mainTex = value; }
            }

            [ParserTarget("mainTexScale", optional = true)]
            private Vector2Parser mainTexScaleSetter
            {
                get { return mainTexScale; }
                set { mainTexScale = value; }
            }

            [ParserTarget("mainTexOffset", optional = true)]
            private Vector2Parser mainTexOffsetSetter
            {
                get { return mainTexOffset; }
                set { mainTexOffset = value; }
            }

            // Main Color, default = (1,1,1,1)
            [ParserTarget("color", optional = true)]
            public ColorParser colorSetter
            {
                get { return color; }
                set { color = value; }
            }

            // Diffuse, default = 2
            [ParserTarget("diff", optional = true)]
            public NumericParser<float> diffSetter
            {
                get { return diff; }
                set { diff = value; }
            }

            // Constructors
            public DiffuseWrapLoader () : base() { }
            public DiffuseWrapLoader (string contents) : base (contents) { }
            public DiffuseWrapLoader (Material material) : base(material) { }
        }
    }
}
