using UnityEngine;

namespace SwaggyScripts.MaterialOverrides
{
    [RequireComponent(typeof(Renderer))]
    public class RendererOverrideTarget : MonoBehaviour
    {
        public Renderer Renderer => GetComponent<Renderer>();

        public void OnEnable() =>
            GetComponentInParent<RendererOverrider>().AddBinder(this);
    
        public void OnDisable() =>
            GetComponentInParent<RendererOverrider>().RemoveBinder(this);
    }
}