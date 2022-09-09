using System;
using UnityEngine;

namespace SwaggyScripts.MaterialOverrides.Bindables
{
    [Serializable]
    public class MaterialBindable : iBindable
    {
        public Material[] Materials;
        private bool _dirty;
        
        public bool IsDirty => _dirty;
        public void SetClean() => _dirty = false;
        public void SetDirty() => _dirty = true;

        public void Bind(Renderer renderer) =>
            renderer.sharedMaterials = Materials;
    }
}