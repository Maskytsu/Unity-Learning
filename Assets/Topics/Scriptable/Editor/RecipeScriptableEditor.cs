using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(RecipieScriptable))]
public class RecipeScriptableEditor : Editor {

    public override void OnInspectorGUI() {
        serializedObject.Update();

        RecipieScriptable recipeScriptableObject = (RecipieScriptable)target;

        EditorGUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();

        EditorGUILayout.BeginVertical();

        Texture texture = null;
        if (recipeScriptableObject.Result != null) {
            texture = recipeScriptableObject.Result.ItemSprite.texture;
        }
        GUILayout.Box(texture, GUILayout.Width(125), GUILayout.Height(125));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("Result"), GUIContent.none, true, GUILayout.Width(150));
        EditorGUILayout.EndVertical();

        GUILayout.FlexibleSpace();
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.Space();

        //first row
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.BeginVertical();
        texture = null;
        if (recipeScriptableObject.Item_00 != null) {
            texture = recipeScriptableObject.Item_00.ItemSprite.texture;
        }
        GUILayout.Box(texture, GUILayout.Width(125), GUILayout.Height(125));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("Item_00"), GUIContent.none, true, GUILayout.Width(150));
        EditorGUILayout.EndVertical();

        EditorGUILayout.BeginVertical();
        texture = null;
        if (recipeScriptableObject.Item_01 != null) {
            texture = recipeScriptableObject.Item_01.ItemSprite.texture;
        }
        GUILayout.Box(texture, GUILayout.Width(125), GUILayout.Height(125));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("Item_01"), GUIContent.none, true, GUILayout.Width(150));
        EditorGUILayout.EndVertical();

        EditorGUILayout.BeginVertical();
        texture = null;
        if (recipeScriptableObject.Item_02 != null) {
            texture = recipeScriptableObject.Item_02.ItemSprite.texture;
        }
        GUILayout.Box(texture, GUILayout.Width(125), GUILayout.Height(125));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("Item_02"), GUIContent.none, true, GUILayout.Width(150));
        EditorGUILayout.EndVertical();

        EditorGUILayout.EndHorizontal();


        //second row
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.BeginVertical();
        texture = null;
        if (recipeScriptableObject.Item_10 != null) {
            texture = recipeScriptableObject.Item_10.ItemSprite.texture;
        }
        GUILayout.Box(texture, GUILayout.Width(125), GUILayout.Height(125));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("Item_10"), GUIContent.none, true, GUILayout.Width(150));
        EditorGUILayout.EndVertical();

        EditorGUILayout.BeginVertical();
        texture = null;
        if (recipeScriptableObject.Item_11 != null) {
            texture = recipeScriptableObject.Item_11.ItemSprite.texture;
        }
        GUILayout.Box(texture, GUILayout.Width(125), GUILayout.Height(125));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("Item_11"), GUIContent.none, true, GUILayout.Width(150));
        EditorGUILayout.EndVertical();

        EditorGUILayout.BeginVertical();
        texture = null;
        if (recipeScriptableObject.Item_12 != null) {
            texture = recipeScriptableObject.Item_12.ItemSprite.texture;
        }
        GUILayout.Box(texture, GUILayout.Width(125), GUILayout.Height(125));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("Item_12"), GUIContent.none, true, GUILayout.Width(150));
        EditorGUILayout.EndVertical();

        EditorGUILayout.EndHorizontal();



        //third row
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.BeginVertical();
        texture = null;
        if (recipeScriptableObject.Item_20 != null) {
            texture = recipeScriptableObject.Item_20.ItemSprite.texture;
        }
        GUILayout.Box(texture, GUILayout.Width(125), GUILayout.Height(125));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("Item_20"), GUIContent.none, true, GUILayout.Width(150));
        EditorGUILayout.EndVertical();

        EditorGUILayout.BeginVertical();
        texture = null;
        if (recipeScriptableObject.Item_21 != null) {
            texture = recipeScriptableObject.Item_21.ItemSprite.texture;
        }
        GUILayout.Box(texture, GUILayout.Width(125), GUILayout.Height(125));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("Item_21"), GUIContent.none, true, GUILayout.Width(150));
        EditorGUILayout.EndVertical();

        EditorGUILayout.BeginVertical();
        texture = null;
        if (recipeScriptableObject.Item_22 != null) {
            texture = recipeScriptableObject.Item_22.ItemSprite.texture;
        }
        GUILayout.Box(texture, GUILayout.Width(125), GUILayout.Height(125));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("Item_22"), GUIContent.none, true, GUILayout.Width(150));
        EditorGUILayout.EndVertical();

        EditorGUILayout.EndHorizontal();


        serializedObject.ApplyModifiedProperties();
    }


}