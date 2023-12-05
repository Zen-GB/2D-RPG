using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSorter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            //player's sorting on trigger object -> object's sorting - 1
            transform.parent.GetComponent<SpriteRenderer>().sortingOrder = collision.GetComponent<SpriteRenderer>().sortingOrder - 1;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //exit object trigger, player's sorting = 4
        transform.parent.GetComponent<SpriteRenderer>().sortingOrder = 4;
    }
}
