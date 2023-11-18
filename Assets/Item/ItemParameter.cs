using UnityEngine;

[CreateAssetMenu(fileName = "ItemParameter", menuName = "ScriptableObjects/CreateItemParameter")]

public class ItemParameter : ScriptableObject
{
    [SerializeField] private string _itemName;
    [SerializeField] private int _sellCost;
}
