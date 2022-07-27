using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classscript : MonoBehaviour
{
    private Animator an;
    private float xSpeed;
    private Transform spriteTra;
    // Start is called before the first frame update
    void Start()
    {
        an = GetComponent<Animator>();
        spriteTra = transform.GetChild(0).transform;
    }

    // Update is called once per frame
    void Update()
    {
        xSpeed = Input.GetAxis("Horizontal");

        if(xSpeed != 0)
        {
            an.SetBool("isWalking", true);
        }
        else
        {
            an.SetBool("isWalking", false);
        }
        if(xSpeed < 0)
        {
            spriteTra.localScale = new Vector3(-1, 1, 1);
        }
        else if (xSpeed > 0)
        {
            spriteTra.localScale = new Vector3(1, 1, 1);
        }
        transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);
    }
}
