using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct Line{
    public CharacterTalk character;

    [TextArea(2, 5)]
    public string text;
}

[CreateAssetMenu(fileName = "New Conversation", menuName = "Conversation")]
public class Conversation : ScriptableObject
{
    public CharacterTalk speakerLeft;
    public CharacterTalk speakerRight;
    public Line[] lines;
}
