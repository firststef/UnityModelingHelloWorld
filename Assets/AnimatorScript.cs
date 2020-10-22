using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimatorScript : MonoBehaviour
{
    private Animator animator;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w")){
            animator.ResetTrigger("Wave");
            animator.ResetTrigger("Grab");
            animator.ResetTrigger("Point");
            animator.SetTrigger("Wave");
            text.text = "Showing animation Wave. Press W, A, D to change animations";
        }
        else if (Input.GetKeyDown("a")){
            animator.ResetTrigger("Wave");
            animator.ResetTrigger("Grab");
            animator.ResetTrigger("Point");
            animator.SetTrigger("Grab");
            text.text = "Showing animation Grab. Press W, A, D to change animations";
        }
        else if (Input.GetKeyDown("d")){
            animator.ResetTrigger("Wave");
            animator.ResetTrigger("Grab");
            animator.ResetTrigger("Point");
            animator.SetTrigger("Point");
            text.text = "Showing animation Point. Press W, A, D to change animations";
        }
    }
}
