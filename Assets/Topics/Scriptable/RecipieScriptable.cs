using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RecipieScriptable", menuName = "ScriptableObjects/RecipieScriptable")]
public class RecipieScriptable : ScriptableObject
{
    //it's something like minecraft crafting table 3x3
    [Header("Result")]
    public ItemScriptable Result;

    //[Header("First column")]
    public ItemScriptable Item_00;
    public ItemScriptable Item_10;
    public ItemScriptable Item_20;

    //[Header("Second column")]
    public ItemScriptable Item_01;
    public ItemScriptable Item_11;
    public ItemScriptable Item_21;

    //[Header("Third column")]
    public ItemScriptable Item_02;
    public ItemScriptable Item_12;
    public ItemScriptable Item_22;

    public ItemScriptable GetItemInSlot(int x, int y)
    {
        if (x == 0 && y == 0) return Item_00;
        if (x == 1 && y == 0) return Item_10;
        if (x == 2 && y == 0) return Item_20;

        if (x == 0 && y == 1) return Item_01;
        if (x == 1 && y == 1) return Item_11;
        if (x == 2 && y == 1) return Item_21;

        if (x == 0 && y == 2) return Item_02;
        if (x == 1 && y == 2) return Item_12;
        if (x == 2 && y == 2) return Item_22;

        return null;
    }
}
