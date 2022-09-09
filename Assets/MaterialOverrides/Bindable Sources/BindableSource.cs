using System.Collections.Generic;
using SwaggyScripts.MaterialOverrides.Bindables;
using UnityEngine;

namespace SwaggyScripts.MaterialOverrides.Bindable_Sources
{
    public abstract class BindableSource<T> : MonoBehaviour where T : iBindable
    {
        public List<T> bindables = new List<T>();
        
        public void OnEnable()
        {
            var source = GetComponentInParent<RendererOverrider>();
            foreach (T bindable in bindables)
                source.AddBindable(bindable);
        }
    
        public void OnDisable() 
        {
            var source = GetComponentInParent<RendererOverrider>();
            foreach (T bindable in bindables)
                source.RemoveBindable(bindable);
        }

        public void OnValidate()
        {
            foreach (var bindable in bindables)
                bindable.SetDirty();
        }
    }
    
}