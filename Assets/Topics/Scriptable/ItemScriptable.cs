using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemScriptable", menuName = "ScriptableObjects/ItemScriptable")]
public class ItemScriptable : ScriptableObject
{
    public string ItemName;
    public Sprite ItemSprite;
}
