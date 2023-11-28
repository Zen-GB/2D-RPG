using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public Animator animator;

    // get input from player
    //apply in sprites

    private void Update()
    {
        //get input from player
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical"); 

        //set vector with variable
        Vector3 direction = new Vector3(horizontal, vertical);

        //set up animation
        AnimateMovement(direction);

        //set vector to tranform position
        transform.position += direction * speed * Time.deltaTime;
        
    }

    void AnimateMovement(Vector3 direction)
    {
        if (animator != null)
        {
            if (direction.magnitude > 0)
            {
                //isMoving in Anmatior true
                animator.SetBool("isMoving", true);
                //set animation with up, down, left, right
                animator.SetFloat("Horizontal", direction.x);
                animator.SetFloat("Verticla", direction.y);
            }
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
    }
}
