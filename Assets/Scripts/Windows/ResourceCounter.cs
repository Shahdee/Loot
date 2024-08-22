using UnityEngine;
using UnityEngine.UI;

public class ResourceCounter : MonoBehaviour
{
    [SerializeField] private Text _amount;

    public void SetAmount(int amount)
    {
        _amount.text = amount.ToString();
    }
}
