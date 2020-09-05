using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movSpeed;
    public Rigidbody2D playerRb;
    private Vector2 movement;
    private Animator playerAnimator;
    public GameObject lightPlayer;
    public GameObject cigarrete;
    private bool lightOn = true;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        OnOffLight();
        
    }

    private void FixedUpdate()
    {
        MovementAction();
        
    }   
    
    void MovementAction()
    {        
        playerRb.velocity = new Vector2(movement.x * movSpeed, movement.y * movSpeed);
    }

    void PlayerMovement()
    {
        movement.x = Input.GetAxisRaw("Horizontal");

        movement.y = Input.GetAxisRaw("Vertical");
               
        

            if (movement.x > 0.05f)
            {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            
            }
        else if (movement.x < -0.05f)
            {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            
            }

        playerAnimator.SetInteger("HorizontalMov", (int)movement.x);
        playerAnimator.SetInteger("VerticalMov", (int)movement.y);
    }

    void OnOffLight()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            lightOn = !lightOn;
            lightPlayer.SetActive(lightOn);
            cigarrete.SetActive(!lightOn);
        }
    }

}
