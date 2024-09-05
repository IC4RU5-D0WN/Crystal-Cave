using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextOnHit : MonoBehaviour
{
    public GameObject teksti;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        teksti.SetActive(true);
    }


}

