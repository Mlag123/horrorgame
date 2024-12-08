using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    private Animator animator;
    private Vector3 can_Animation = Vector3.zero;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    private static string idle_animation = "idle";
    private static string run_animation = "run";
    private static string walk_animation = "walk";
    private static string legend_animation = "legend";

    // Update is called once per frame
    void Update()
    {
        if (animator != null)
        {

            if (Input.GetKey(KeyCode.W))
            {
      
                animator.SetBool("walking", true);
            }
            else
            {
                animator.SetBool("walking", false);
            }

            if (Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("walking", false);

                animator.SetBool("run", true);
            }
            else
            {
                animator.SetBool("run", false);

            }

        }
    }
    void camWalkinkAnimate()
    {
        while (Input.GetKey(KeyCode.W)) { 
        
        
        }
    }
}
