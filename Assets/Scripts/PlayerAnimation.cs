using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    private Animator animator;


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
                print("bitch");
                animator.SetBool("walking", true);
            }
            else
            {
                animator.SetBool("walking", false);
            }


          /*  if (Input.GetKeyDown(KeyCode.W))
            {
                print("“€ —”¿ Õ¿∆¿À Õ¿ Ã≈Õﬂ ¡Àﬂƒ»Õ¿!");
                animator.Play(walk_animation);
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                print("—À¿¬¿ œ”“»Õ»— ŒÃ” –≈∆»Ã” Õ¿’”…");
                animator.Play(idle_animation);
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.Play(legend_animation);

            }else if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                animator.Play(run_animation);
            }*/
           
        }
    }
}
