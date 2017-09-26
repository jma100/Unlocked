using UnityEngine;
using System.Collections;

public class doorController : MonoBehaviour {

    private bool openStatus;
	
	// Update is called once per frame
	public void OpenDoor()
    {
        GetComponent<Animation>().Play("Door_Open");
        //openStatus = !openStatus;
        //GetComponent<Animator>().SetBool("open", openStatus);	
	}
}
