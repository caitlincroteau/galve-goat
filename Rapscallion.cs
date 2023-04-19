using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rapscallion : MonoBehaviour
{
    public float playerSpeed = 3f;
    public GameObject bottle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal"); 

        Vector3 change = new Vector3(deltaX, 0, 0) *playerSpeed* Time.deltaTime;;

        transform.position += change;

        if(Input.GetKeyDown("space")){
            ThrowBottle();
        }
    }

    void ThrowBottle() {
        Instantiate(bottle, transform.position, transform.rotation);
    }
}
