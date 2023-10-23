using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

[CustomEditor(typeof(CardCollection))]
public class CardCollectionEditor : Editor 
{
    Dictionary<int, Card> cards;
    public override void OnInspectorGUI() 
    {
        cards = new Dictionary<int, Card>();
        CardCollection cardCollection = (CardCollection)target;
        cards = cardCollection.GetAllCards();
        if (cards!=null)
        {
            foreach(KeyValuePair<int, Card> pair in cards)
            {
                EditorGUILayout.LabelField(pair.Key.ToString(), pair.Value.GetName());
            }
        }
        base.OnInspectorGUI();
    }
}
