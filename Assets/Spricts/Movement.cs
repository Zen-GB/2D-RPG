using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;


    // get input from player
    //apply in sprites

    private void Update()
    {
        //get input from player
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical"); 

        //set vector with variable
        Vector3 direction = new Vector3(horizontal, vertical);

        //set vector to tranform position
        transform.position += direction * speed * Time.deltaTime;
        
    }
}
