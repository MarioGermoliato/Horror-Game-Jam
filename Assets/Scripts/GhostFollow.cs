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


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
    }


    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > distance){
            transform.position = Vector2.MoveTowards(transform.position, target.position, vel * Time.deltaTime);
        }
    }
}
