using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    private Animator animator;
    private bool isRec;

	void Start ()
	{
	    animator = GetComponent<Animator>();
	}
	
	void Update () {

	    if (Input.GetKeyDown(KeyCode.Space))
	    {
	        isRec = !isRec;

	        if (isRec) // Space: Start Rec
	        {
	            animator.SetBool("StartRec", true);
	            animator.SetBool("StopRec", false);
	        }

	        if (!isRec) // Space: Stop Rec 
	        {
	            animator.SetBool("StopRec", true);
	            animator.SetBool("StartRec", false);
	        }
        }
	}
}
