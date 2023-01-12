using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ObjectPlacement))]
public class ObjectPlacementEditor : Editor
{
    public enum GameObjects
    {
        Arbres, Champignons, Rochers, Buissons, Fleurs, Gomme, PréRendus, Autres
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

            case GameObjects.Fleurs:
                FleursGameObjects();
                break;

            case GameObjects.Gomme:
                EraserHead();
                break;

            case GameObjects.PréRendus:
                PréRendus();
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
    void FleursGameObjects()
    {
        EditorGUILayout.PropertyField(serializedObject.FindProperty("fleur_plaine"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("fleur_marais"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("fleur_désert"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("fleur_montagne"));
    }

    void EraserHead()
    {
        EditorGUILayout.PropertyField(serializedObject.FindProperty("gomme"));
    }
    void PréRendus()
    {
        
        EditorGUILayout.PropertyField(serializedObject.FindProperty("arbre_plaine_prérendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("arbre_marais_prérendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("arbre_désert_prérendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("arbre_montagne_prérendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("champignon_plaine_prérendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("champignon_marais_prérendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("champignon_désert_prérendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("champignon_montagne_prérendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("rocher_plaine_prérendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("rocher_marais_prérendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("rocher_désert_prérendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("rocher_montagne_prérendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("buisson_plaine_prérendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("buisson_marais_prérendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("buisson_désert_prérendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("buisson_montagne_prérendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("fleur_plaine_prérendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("fleur_marais_prérendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("fleur_désert_prérendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("fleur_montagne_prérendu"));
    }

    void AutresInfo()
    {
        EditorGUILayout.PropertyField(serializedObject.FindProperty("objectToDestroy"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("hitLayers"));
    }
}
