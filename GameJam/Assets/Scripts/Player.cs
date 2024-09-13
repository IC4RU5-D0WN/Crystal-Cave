using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{ 
    float horizontal;
    float vertical;
   // float moveLimiter = 0.7f;

   // public CoinManager cm;
    public float moveSpeed = 20.0f;
    public Camera cam;
    public Weapon weapon;
    public Rigidbody2D rb;

    Vector2 moveDirection;
    Vector2 mousePosition;

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        if(Input.GetMouseButtonDown(0))
        {
            weapon.Fire();
        }

        moveDirection = new Vector2(moveX, moveY).normalized;
        mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
    }   
        
    void FixedUpdate()
    {
        //Liikkuminen
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

        //Pelaajan k‰‰ntyminen
        Vector2 aimDirection = mousePosition - rb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg -90f;
        rb.rotation = aimAngle;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);      
         //   cm.CoinCount++;
        }
    }
}

