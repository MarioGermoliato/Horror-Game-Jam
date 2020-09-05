using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjectInteract : MonoBehaviour
{
   public bool isInRange;
   public KeyCode interactKey;
   public UnityEvent interactAction;

   void Update(){
       if(isInRange){
           if(Input.GetKeyDown(interactKey)){
               interactAction.Invoke();
           }
       }
   }

   private void OnTriggerEnter2D(Collider2D collision){
       if(collision.gameObject.CompareTag("Player")){
           Debug.Log("meme");
           isInRange = true;
       }
   }

   private void OnTriggerExit2D(Collider2D collision){
       if(collision.gameObject.CompareTag("Player")){
           isInRange = false;
       }
   }
}
