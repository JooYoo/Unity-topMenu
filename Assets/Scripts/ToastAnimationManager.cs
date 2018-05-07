using UnityEngine;

public class ToastAnimationManager : MonoBehaviour
{
    private Animator toastAnimator;

	// Use this for initialization
	void Start ()
	{
	    toastAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.O))
	    {
	        toastAnimator.SetTrigger("toastsPop");
	    }
	}
}
