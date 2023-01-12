using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ObjectPlacement))]
public class ObjectPlacementEditor : Editor
{
    public enum GameObjects
    {
        Arbres, Champignons, Rochers, Buissons, Fleurs, Gomme, Pr�Rendus, Autres
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

            case GameObjects.Pr�Rendus:
                Pr�Rendus();
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
        EditorGUILayout.PropertyField(serializedObject.FindProperty("arbre_d�sert"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("arbre_montagne"));
    }

    void ChampignonsGameObjects()
    {
        EditorGUILayout.PropertyField(serializedObject.FindProperty("champignon_plaine"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("champignon_marais"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("champignon_d�sert"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("champignon_montagne"));
    }

    void RochersGameObjects()
    {
        EditorGUILayout.PropertyField(serializedObject.FindProperty("rocher_plaine"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("rocher_marais"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("rocher_d�sert"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("rocher_montagne"));
    }

    void BuissonsGameObjects()
    {
        EditorGUILayout.PropertyField(serializedObject.FindProperty("buisson_plaine"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("buisson_marais"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("buisson_d�sert"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("buisson_montagne"));
    }
    void FleursGameObjects()
    {
        EditorGUILayout.PropertyField(serializedObject.FindProperty("fleur_plaine"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("fleur_marais"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("fleur_d�sert"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("fleur_montagne"));
    }

    void EraserHead()
    {
        EditorGUILayout.PropertyField(serializedObject.FindProperty("gomme"));
    }
    void Pr�Rendus()
    {
        
        EditorGUILayout.PropertyField(serializedObject.FindProperty("arbre_plaine_pr�rendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("arbre_marais_pr�rendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("arbre_d�sert_pr�rendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("arbre_montagne_pr�rendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("champignon_plaine_pr�rendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("champignon_marais_pr�rendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("champignon_d�sert_pr�rendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("champignon_montagne_pr�rendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("rocher_plaine_pr�rendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("rocher_marais_pr�rendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("rocher_d�sert_pr�rendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("rocher_montagne_pr�rendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("buisson_plaine_pr�rendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("buisson_marais_pr�rendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("buisson_d�sert_pr�rendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("buisson_montagne_pr�rendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("fleur_plaine_pr�rendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("fleur_marais_pr�rendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("fleur_d�sert_pr�rendu"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("fleur_montagne_pr�rendu"));
    }

    void AutresInfo()
    {
        EditorGUILayout.PropertyField(serializedObject.FindProperty("objectToDestroy"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("hitLayers"));
    }
}
