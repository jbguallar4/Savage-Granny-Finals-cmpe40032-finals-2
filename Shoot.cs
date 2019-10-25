using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public Animator anim;
    Rigidbody playerRigidbody;
    


    // Start is called before the first frame update
    void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }


    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            anim.SetTrigger("PlayerShoot");
            
        }
    }
    public void playerDie()
    {
        anim.SetTrigger("PlayerDie");
    }

    
}

