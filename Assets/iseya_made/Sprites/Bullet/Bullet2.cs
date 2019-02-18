using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed = 2;

    public float lifetime = 5;

    public int power = 1;
    // Update is called once per frame
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;

        Destroy(gameObject, lifetime);
    }
}
