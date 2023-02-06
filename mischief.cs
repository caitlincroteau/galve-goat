using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mischief : MonoBehaviour

{

    public GameObject nextMischief;

    private void OnTriggerEnter2D(Collider2D other) {
       if(other.gameObject.tag == "Player"){
            if(this.gameObject.tag == "Rubbish Bin") {
                transform.Rotate(0,0,-90);
                Destroy(this.gameObject.GetComponent<BoxCollider2D>());
                //add script for creating old lady
                // Instantiate(nextMischief, transform.position, transform.rotation);      
            } else if (this.gameObject.tag == "Old Lady") {
                transform.Rotate(0,0,90);
                Destroy(this.gameObject.GetComponent<BoxCollider2D>());
                Destroy(this.gameObject.GetComponent<OldLady>());
            }
        }
    }


}