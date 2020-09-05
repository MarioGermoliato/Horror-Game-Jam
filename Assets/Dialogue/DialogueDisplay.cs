using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueDisplay : MonoBehaviour
{
    public Conversation conversation;

    public GameObject speakerLeft;
    public GameObject speakerRight;

    private SpeakerUI speakerUILeft;
    private SpeakerUI speakerUIRight;

    private int activeLineIndex = 0;

    void Start()
    {
        speakerUILeft = speakerLeft.GetComponent<SpeakerUI>();
        speakerUIRight = speakerRight.GetComponent<SpeakerUI>();

        speakerUILeft.Speaker = conversation.speakerLeft;
        speakerUIRight.Speaker = conversation.speakerRight;
        AdvanceConversation();
    }

    void Update()
    {
        if(Input.GetKeyDown("space")){
            AdvanceConversation();
        }
    }

    void AdvanceConversation(){
        if(activeLineIndex < conversation.lines.Length){
            Time.timeScale = 0.0f;
            DisplayLine();
            activeLineIndex += 1;
        } 
        else {
            speakerUILeft.Hide();
            speakerUIRight.Hide();
            Time.timeScale = 1.0f;
            
            //activeLineIndex = 0;
        }
    }

    void DisplayLine(){
        Line line = conversation.lines[activeLineIndex];
        CharacterTalk character = line.character;

        if(speakerUILeft.SpeakerIs(character)){
            SetDialog(speakerUILeft, speakerUIRight, line.text);
        } 
        else {
            SetDialog(speakerUIRight, speakerUILeft, line.text);
        }
    }

    void SetDialog(
        SpeakerUI activeSpeakerUI,
        SpeakerUI inactiveSpeakerUI,
        string text){
       activeSpeakerUI.Dialog = text;
       activeSpeakerUI.Show();
       inactiveSpeakerUI.Hide();
    }
}
