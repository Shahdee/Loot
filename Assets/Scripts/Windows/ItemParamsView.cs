using UnityEngine;
using UnityEngine.UI;

public class ItemParamsView : MonoBehaviour
{
    [SerializeField] private Text _level;
    [SerializeField] private Image _icon;
    [SerializeField] private Text[] _stats;

    public void SetItem(Sprite icon, int level, string[] stats)
    {
        _icon.sprite = icon;
        _level.text = level.ToString();
        
        if (_stats.Length != stats.Length)
            return;

        for (int i = 0; i < _stats.Length; i++)
        {
            _stats[i].text = stats[i];
        }
    }
}
