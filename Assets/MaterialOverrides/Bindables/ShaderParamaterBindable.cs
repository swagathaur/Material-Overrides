using UnityEngine;

namespace SwaggyScripts.MaterialOverrides.Bindables
{
    public abstract class ShaderParamaterBindable<T> : iBindable
    {
        public string ParamName = "Parameter Name";
        protected bool Dirty = true;
        
        public bool IsDirty => Dirty;
        
        public void SetClean() => Dirty = false;
        public void SetDirty() => Dirty = true;

        protected abstract bool IsEqual(T rhs);

        protected abstract void Apply(Material material);
        
        public void Bind(Renderer renderer)
        {
            if (renderer == null) return;
            var materials = renderer.materials;
            foreach (var material in materials)
            {
                if (material == null || !material.HasProperty(ParamName)) continue;
                Apply(material);
            }
        }

    }
}