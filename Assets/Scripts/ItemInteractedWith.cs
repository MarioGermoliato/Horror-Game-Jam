using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteractedWith : MonoBehaviour
{
    public bool isClicked;
    public GameObject dialogue;
    //public Animator anim;

    // Start is called before the first frame update
    public void Interact()
    {
        if(!isClicked){
            isClicked = true;
            Debug.Log("Open");
            //animator.SetBool("isActive", isClicked);

            if(this.tag == "Npc"){
                dialogue.SetActive(true);
            }

            else{

            }

        }
    }

     void OnTriggerEnter2D(Collider2D col){
         if(this.tag == "AutoEvent"){
             dialogue.SetActive(true);
         }
     }

}
