using UnityEngine;

namespace SwaggyScripts.MaterialOverrides.Bindables
{
    public interface iBindable
    {
        public bool IsDirty { get; }
        public void SetClean();
        public void SetDirty();
        public void Bind(Renderer renderer);
    }
}
