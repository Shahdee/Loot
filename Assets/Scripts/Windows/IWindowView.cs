using UnityEngine;

    public interface IWindowView
    {
        void SetParent(Transform parent);
    
        void Open();

        void Close();
    }
