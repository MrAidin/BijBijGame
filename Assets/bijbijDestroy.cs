using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bijbijDestroy : MonoBehaviour
{
    public GameObject Bij;
    public GameObject Pattern;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag == "Ground")
        {
            Destroy();
        }

    }


    private void Destroy()
    {

        Destroy(Bij);
        Instantiate(Pattern, transform.position, Quaternion.identity);
    }
}
