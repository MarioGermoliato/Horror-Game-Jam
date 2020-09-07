using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostFollow : MonoBehaviour
{
    public float vel;
    // Velocidade do movimento
    public float distance;
    // Distancia ate o player

    private Transform target;

    private Animator ghostAnimator;

    private Vector2 ghostMovement;


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        ghostAnimator = FindObjectOfType<Animator>();
        
    }


    void Update()
    {
        ghostMovement.x = Input.GetAxisRaw("Horizontal");
        ghostMovement.y = Input.GetAxisRaw("Vertical");

        if (Vector2.Distance(transform.position, target.position) > distance){
            transform.position = Vector2.MoveTowards(transform.position, target.position, vel * Time.deltaTime);

            ghostAnimator.SetBool("Distance", true);
            ghostAnimator.SetInteger("Ghost_Horizontal", (int)ghostMovement.x);
            ghostAnimator.SetInteger("Ghost_Vertical", (int)ghostMovement.y);
        }

        
    }
}
