using UnityEngine;
using UnityEngine.UI;

public class ItemParamsView : MonoBehaviour
{
    [SerializeField] private Text _level;
    [SerializeField] private Image _icon;
    
    // TODO add params 


    public void SetItem(Sprite icon, int level)
    {
        _icon.sprite = icon;
        _level.text = level.ToString();
        
    }
    
}
