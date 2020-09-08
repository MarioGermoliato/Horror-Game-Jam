using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteractedWith : MonoBehaviour
{
    public bool isClicked;
    public string scene;
    //public Animator anim;

    // Start is called before the first frame update
    public void Interact()
    {
        if(!isClicked){
            isClicked = true;
            Debug.Log("Open");
            //animator.SetBool("isActive", isClicked);

            if(this.tag == "Door"){
                 SceneManager.LoadScene(scene);
            }
            else{

            }

        }
    }
}
