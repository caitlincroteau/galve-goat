using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float force = 1f;
    [SerializeField] private GameObject fire;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        rb2d.AddForce(new Vector2(force, force));
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -5f){
            Destroy(this.gameObject);
        }
        
    }

    void OnTriggerEnter2D(Collider2D other) {
       
        Instantiate(fire, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}
