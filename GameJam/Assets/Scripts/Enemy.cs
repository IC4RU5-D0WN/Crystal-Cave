using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    public float speed;
    private float distance;
    public int maxHits = 3;
    private int currentHits = 0;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            TakeDamage();
        }
    }
    public void TakeDamage()
    {
        currentHits++;  
        if (currentHits >= maxHits)
        {
            Die();
        }
    }
    private void Die()
    {
        Destroy(this.gameObject);
        Debug.Log("Enemy died!");
    }
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);

        // Kääntymis scripti pois päältä   

        //   Vector2 direction = player.transform.position - transform.position;
        //   direction.Normalize();
        //   float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        if (distance > 3)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            //  transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }

       
    }
}
