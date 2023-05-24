using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleThrower : MonoBehaviour
{
    public GameObject bottle;

    public float throwCooldown = .5f;
    private float throwTimer = 0f;

    void Start() {
        //start the player ready to throw
        throwTimer = throwCooldown;
    }

    void Update()
    {
        if( throwTimer < throwCooldown ) {
            throwTimer += Time.deltaTime;
        }
        else{
            if(Input.GetKeyDown("space")){
              ThrowBottle();
            }
        }

    }

    void ThrowBottle() {
        Instantiate(bottle, transform.position, transform.rotation);
        throwTimer = 0f;
    }
}
