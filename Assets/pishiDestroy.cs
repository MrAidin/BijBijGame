using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pishiDestroy : MonoBehaviour
{

    public GameObject pishi;
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

        Destroy(pishi);
        Instantiate(Pattern, transform.position, Quaternion.identity);
    }
}
