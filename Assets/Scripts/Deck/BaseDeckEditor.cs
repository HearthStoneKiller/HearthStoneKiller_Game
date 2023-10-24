using UnityEditor;

[CustomEditor(typeof(BaseDeck))]
public class BaseDeckEditor : Editor 
{
    private BaseDeck baseDeck;
    private void OnEnable()
    {
        baseDeck = (BaseDeck)target;
    }
    public override void OnInspectorGUI() 
    {
        for (int i = 0; i < baseDeck.GetCount(); i++)
        {
            EditorGUILayout.BeginVertical("box");
            if (typeof(CreatureCard) == baseDeck.GetCard(i).GetType())
            {
                EditorGUILayout.LabelField("Creature Card");
                EditorGUILayout.IntField("id", CardCollection.GetIdWithName(baseDeck.GetCard(i).GetName()));
                EditorGUILayout.TextField("Название", baseDeck.GetCard(i).GetName());
            }
            else if (typeof(SpellCard) == baseDeck.GetCard(i).GetType())
            {
                EditorGUILayout.LabelField("Spell Card");
                EditorGUILayout.IntField("id", CardCollection.GetIdWithName(baseDeck.GetCard(i).GetName()));
                EditorGUILayout.TextField("Название", baseDeck.GetCard(i).GetName());
            }
            EditorGUILayout.EndVertical();
        }
    }
}
