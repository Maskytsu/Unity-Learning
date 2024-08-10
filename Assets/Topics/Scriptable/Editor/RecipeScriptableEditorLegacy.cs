using UnityEngine;
using UnityEditor;

//[CustomEditor(typeof(RecipieScriptable))]
public class RecipeScriptableEditorLegacy : Editor
{
    public override void OnInspectorGUI()
    {
        RecipieScriptable myScript = (RecipieScriptable)target;

        float labelWidth = 25f;

        GUILayout.Label("Result", EditorStyles.boldLabel);
        myScript.Result = (ItemScriptable)EditorGUILayout.ObjectField(myScript.Result, typeof(ItemScriptable), false, GUILayout.MaxWidth(150f));

        GUILayout.Label("\nRecipie", EditorStyles.boldLabel);
        EditorGUILayout.BeginHorizontal();
        myScript.Item_00 = (ItemScriptable)EditorGUILayout.ObjectField(myScript.Item_00, typeof(ItemScriptable), false, GUILayout.MaxWidth(125f));
        EditorGUILayout.LabelField("", GUILayout.Width(labelWidth));
        myScript.Item_01 = (ItemScriptable)EditorGUILayout.ObjectField(myScript.Item_01, typeof(ItemScriptable), false, GUILayout.MaxWidth(125f));
        EditorGUILayout.LabelField("", GUILayout.Width(labelWidth));
        myScript.Item_02 = (ItemScriptable)EditorGUILayout.ObjectField(myScript.Item_02, typeof(ItemScriptable), false, GUILayout.MaxWidth(125f));
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        myScript.Item_10 = (ItemScriptable)EditorGUILayout.ObjectField(myScript.Item_10, typeof(ItemScriptable), false, GUILayout.MaxWidth(125f));
        EditorGUILayout.LabelField("", GUILayout.Width(labelWidth));
        myScript.Item_11 = (ItemScriptable)EditorGUILayout.ObjectField(myScript.Item_11, typeof(ItemScriptable), false, GUILayout.MaxWidth(125f));
        EditorGUILayout.LabelField("", GUILayout.Width(labelWidth));
        myScript.Item_12 = (ItemScriptable)EditorGUILayout.ObjectField(myScript.Item_12, typeof(ItemScriptable), false, GUILayout.MaxWidth(125f));
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        myScript.Item_20 = (ItemScriptable)EditorGUILayout.ObjectField(myScript.Item_20, typeof(ItemScriptable), false, GUILayout.MaxWidth(125f));
        EditorGUILayout.LabelField("", GUILayout.Width(labelWidth));
        myScript.Item_21 = (ItemScriptable)EditorGUILayout.ObjectField(myScript.Item_21, typeof(ItemScriptable), false, GUILayout.MaxWidth(125f));
        EditorGUILayout.LabelField("", GUILayout.Width(labelWidth));
        myScript.Item_22 = (ItemScriptable)EditorGUILayout.ObjectField(myScript.Item_22, typeof(ItemScriptable), false, GUILayout.MaxWidth(125f));
        EditorGUILayout.EndHorizontal();

        if (GUI.changed)
        {
            EditorUtility.SetDirty(target);
        }
    }
}