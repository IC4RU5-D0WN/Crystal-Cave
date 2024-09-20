using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private bool kuopio;
    private float deathTimer;
    private void Start()
    {
        deathTimer = 0.1f;
        kuopio = false;
    }
    private void Update()
    {
        if (kuopio)
        {
            deathTimer -= Time.deltaTime;
        }
        if (deathTimer < 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        kuopio = true;
    }
}
