using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpeakerUI : MonoBehaviour
{
    public Image portrait;
    public /*Text*/TMP_Text fullName;
    public /*Text*/TMP_Text dialog;

    private CharacterTalk speaker;
    public CharacterTalk Speaker{
        get{return speaker;}
        set{
            speaker = value;
            portrait.sprite = speaker.portrait;
            fullName.text = speaker.fullName;
        }
    }

    public string Dialog{
        set{dialog.text = value;}
    }
    
    public bool HasSpeaker(){
        return speaker != null;
    }

    public bool SpeakerIs(CharacterTalk character){
        return speaker == character;
    }

    public void Show(){
        gameObject.SetActive(true);
    }

    public void Hide(){
        gameObject.SetActive(false);
    }
}
