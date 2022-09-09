using System;
using UnityEngine;

namespace SwaggyScripts.MaterialOverrides.Bindables
{
    [Serializable]
    public class FloatBindable : ShaderParamaterBindable<float>
    {
        public float Value
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
        private  float value;
        protected override bool IsEqual(float rhs) => 
            Value == rhs;

        protected override void Apply(Material material) =>
            material.SetFloat(ParamName, Value);
    }
}