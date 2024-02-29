using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlayer : MonoBehaviour
{
    //Prefab bullet
    public GameObject bullet;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject gameObject = (GameObject)Instantiate(bullet,
                transform.position, Quaternion.identity);

            Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), transform.parent.GetComponent<Collider2D>());
            
        }
    }
}
