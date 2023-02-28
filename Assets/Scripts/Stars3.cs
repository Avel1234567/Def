using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars3 : MonoBehaviour
{
    public static int Star3;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            Star3 += 1;
            Destroy(gameObject);
        }
    }
}
