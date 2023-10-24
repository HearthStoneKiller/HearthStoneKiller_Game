using UnityEditor;

[CustomEditor(typeof(ModDeck))]
public class ModDeckEditor : Editor 
{
    private ModDeck modDeck;
    private void OnEnable()
    {
        modDeck = (ModDeck)target;
    }
    public override void OnInspectorGUI() 
    {
        for (int i = 0; i < modDeck.GetCount(); i++)
        {
            EditorGUILayout.BeginVertical("box");
            if (typeof(ParametersCard) == modDeck.GetCard(i).GetType())
            {
                EditorGUILayout.LabelField("Parameters Card");
                EditorGUILayout.IntField("id", CardCollection.GetIdWithName(modDeck.GetCard(i).GetName()));
                EditorGUILayout.TextField("Название", modDeck.GetCard(i).GetName());
            }
            else if (typeof(PropertyCard) == modDeck.GetCard(i).GetType())
            {
                EditorGUILayout.LabelField("Property Card");
                EditorGUILayout.IntField("id", CardCollection.GetIdWithName(modDeck.GetCard(i).GetName()));
                EditorGUILayout.TextField("Название", modDeck.GetCard(i).GetName());
            }
            EditorGUILayout.EndVertical();
        }
    }
}