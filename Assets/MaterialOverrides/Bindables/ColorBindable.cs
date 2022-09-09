using System;
using UnityEngine;

namespace SwaggyScripts.MaterialOverrides.Bindables
{
    [Serializable]
    public class ColorBindable : ShaderParamaterBindable<Color>
    {
        public Color Value
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
        private  Color value;
        protected override bool IsEqual(Color rhs) => 
            Value == rhs;

        protected override void Apply(Material material) => 
            material.SetColor(ParamName, Value);
    }
}