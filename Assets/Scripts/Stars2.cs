using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars2 : MonoBehaviour
{
    public static int Star2;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            Star2 += 1;
            Destroy(gameObject);
        }
    }
}
