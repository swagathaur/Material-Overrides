using System.Collections.Generic;
using System.Linq;
using SwaggyScripts.MaterialOverrides.Bindables;
using UnityEngine;

namespace SwaggyScripts.MaterialOverrides
{
    public class RendererOverrider : MonoBehaviour
    {
        List<RendererOverrideTarget> _targets = new List<RendererOverrideTarget>();
        List<iBindable> _bindables = new List<iBindable>();

        public void AddBinder(RendererOverrideTarget binder) =>
            _targets.Add(binder);

        public void RemoveBinder(RendererOverrideTarget rendererOverrideBinder) =>
            _targets.Remove(rendererOverrideBinder);

        public void AddBindable(iBindable bindable) =>
            _bindables.Add(bindable);
    
        public void RemoveBindable(iBindable bindable) =>
            _bindables.Remove(bindable);
    
        public void Update()
        {
            foreach (var bindable in _bindables.Where(bindable => bindable.IsDirty))
            {
                if (!bindable.IsDirty) continue;
            
                foreach (var binder in _targets)
                    bindable.Bind(binder.Renderer);
                bindable.SetClean();
            }
        }
    }
}