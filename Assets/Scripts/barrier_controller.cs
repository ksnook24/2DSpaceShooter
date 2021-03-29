using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier_controller : MonoBehaviour
{
    // Start is called before the first frame update
    private int health = 0;

    public Sprite[] sprites;

    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = sprites[health];
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 3)
        {
            Destroy(this.gameObject);
            return;
        }

        GetComponent<SpriteRenderer>().sprite = sprites[health];
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        health++;
    }
}
