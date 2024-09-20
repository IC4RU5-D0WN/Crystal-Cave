using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TimoChase : MonoBehaviour
{
    public GameObject player;
    public float speed;

    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame 
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
    
     // K��ntymis scripti pois p��lt�   
        
     //   Vector2 direction = player.transform.position - transform.position;
     //   direction.Normalize();
     //   float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
       
        if (distance > 0) 
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            //  transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
    }
    
}
