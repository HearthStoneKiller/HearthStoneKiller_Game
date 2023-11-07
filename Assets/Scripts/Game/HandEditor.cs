using UnityEditor;

[CustomEditor(typeof(Hand))]
public class HandEditor : Editor 
{
    private Hand hand;
    private void OnEnable()
    {
        hand = (Hand)target;
    }
    public override void OnInspectorGUI() 
    {
        for (int i = 0; i < hand.GetCount(); i++)
        {
            EditorGUILayout.BeginVertical("box");
            if (typeof(CreatureCard) == hand.GetCard(i).GetType())
            {
                EditorGUILayout.LabelField("Creature Card");
                EditorGUILayout.IntField("id", CardCollection.GetIdWithName(hand.GetCard(i).GetName()));
                EditorGUILayout.TextField("Название", hand.GetCard(i).GetName());
            }
            else if (typeof(SpellCard) == hand.GetCard(i).GetType())
            {
                EditorGUILayout.LabelField("Spell Card");
                EditorGUILayout.IntField("id", CardCollection.GetIdWithName(hand.GetCard(i).GetName()));
                EditorGUILayout.TextField("Название", hand.GetCard(i).GetName());
            }
            else if (typeof(ParametersCard) == hand.GetCard(i).GetType())
            {
                EditorGUILayout.LabelField("Parameters Card");
                EditorGUILayout.IntField("id", CardCollection.GetIdWithName(hand.GetCard(i).GetName()));
                EditorGUILayout.TextField("Название", hand.GetCard(i).GetName());
            }
            else if (typeof(PropertyCard) == hand.GetCard(i).GetType())
            {
                EditorGUILayout.LabelField("Property Card");
                EditorGUILayout.IntField("id", CardCollection.GetIdWithName(hand.GetCard(i).GetName()));
                EditorGUILayout.TextField("Название", hand.GetCard(i).GetName());
            }
            EditorGUILayout.EndVertical();
        }
    }
}
