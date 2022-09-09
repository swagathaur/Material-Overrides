using System;
using UnityEngine;

namespace SwaggyScripts.MaterialOverrides.Bindables
{
    [Serializable]
    public class TextureBindable : ShaderParamaterBindable<Texture>
    {
        public Texture Value
        {
            get => value;
            set
            {
                if (this.IsEqual(value)) return;
                this.value = value;
                Dirty = true;
            }
        }
        [SerializeField]
        private Texture value;
        protected override bool IsEqual(Texture rhs) => 
            Value == rhs;

        protected override void Apply(Material material) => 
            material.SetTexture(ParamName, Value);
        
    }
}