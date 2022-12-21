using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ObjectPlacement))]
public class ObjectPlacementEditor : Editor
{
    public enum GameObjects
    {
        Arbres, Champignons, Rochers, Buissons, Buttons, PréRendus, Autres
    }

    public GameObjects dropdown;

    public override void OnInspectorGUI()
    {
        dropdown = (GameObjects)EditorGUILayout.EnumPopup("GameObjects", dropdown);

        EditorGUILayout.Space();

        switch (dropdown)
        {
            case GameObjects.Arbres:
                ArbresGameObjects();
                break;

            case GameObjects.Champignons:
                ChampignonsGameObjects();
                break;

            case GameObjects.Rochers:
                RochersGameObjects();
                break;

            case GameObjects.Buissons:
                BuissonsGameObjects();
                break;

            case GameObjects.Buttons:
                Button();
                break;
                
            case GameObjects.PréRendus:
                PréRendu();
                break;

            case GameObjects.Autres:
                AutresInfo();
                break;
        }

        serializedObject.ApplyModifiedProperties();
    }

    void ArbresGameObjects()
    {
        EditorGUILayout.PropertyField(serializedObject.FindProperty("arbre_plaine"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("arbre_marais"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("arbre_désert"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("arbre_montagne"));
    }

    void ChampignonsGameObjects()
    {
        EditorGUILayout.PropertyField(serializedObject.FindProperty("champignon_plaine"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("champignon_marais"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("champignon_désert"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("champignon_montagne"));
    }

    void RochersGameObjects()
    {
        EditorGUILayout.PropertyField(serializedObject.FindProperty("rocher_plaine"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("rocher_marais"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("rocher_désert"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("rocher_montagne"));
    }

    void BuissonsGameObjects()
    {
        EditorGUILayout.PropertyField(serializedObject.FindProperty("buisson_plaine"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("buisson_marais"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("buisson_désert"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("buisson_montagne"));
    }

    void Button()
    {
        EditorGUILayout.PropertyField(serializedObject.FindProperty("buttonArbres"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("buttonChampignons"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("buttonRochers"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("buttonBuissons"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("buttonPlaceHolder"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("buttonPlaceHolder1"));
    }
    void PréRendu()
    {
        
        EditorGUILayout.PropertyField(serializedObject.FindProperty("prérendu_arbre_plaine"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("prérendu_arbre_marais"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("prérendu_arbre_désert"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("prérendu_arbre_montagne"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("prérendu_champignon_plaine"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("prérendu_champignon_marais"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("prérendu_champignon_désert"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("prérendu_champignon_montagne"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("prérendu_rocher_plaine"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("prérendu_rocher_marais"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("prérendu_rocher_désert"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("prérendu_rocher_montagne"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("prérendu_buisson_plaine"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("prérendu_buisson_marais"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("prérendu_buisson_désert"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("prérendu_buisson_montagne"));
    }

    void AutresInfo()
    {
        EditorGUILayout.PropertyField(serializedObject.FindProperty("objectToDestroy"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("moveThis"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("hitLayers"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("tak"));
    }
}
