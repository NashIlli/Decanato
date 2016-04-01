using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
    private bool canToggle;
    private bool isOpen;
	private bool isOpening;
	private bool isClosing;
	private float rotation;


    [SerializeField]
    private GameObject axis;

    [SerializeField]
    private GameObject door;
	// Use this for initialization
	void Start () {
        canToggle = false;
        isOpen = false;
		rotation = 90f;
	}
	
	// Update is called once per frame
    void Update() {
        if(canToggle && Input.GetKeyDown(KeyCode.E)){
            if(isOpen){
                closeDoor();
            }
            else {
                openDoor();
            }
        }


        
    }

	void FixedUpdate(){
		if (isOpening && rotation > 0) {
			float timeElapsed = Time.deltaTime;
			Vector3 axisPosition = axis.transform.position;
			door.transform.RotateAround (axisPosition, Vector3.up, 90 * timeElapsed);
			rotation-= 90 * timeElapsed;
		} else if (isOpening) {
			rotation = 90;
			isOpening = false;
		} 

		if (isClosing && rotation > 0) {
			float timeElapsed = Time.deltaTime;
			Vector3 axisPosition = axis.transform.position;
			door.transform.RotateAround (axisPosition, Vector3.up, - 90 * timeElapsed);
			rotation-= 90 * timeElapsed;
		} else if (isClosing) {
			rotation = 90;
			isClosing = false;
		} 
	}

private void openDoor()
{
    isOpen = true;
		isClosing = false;
	
	isOpening = true;

    //door.transform.RotateAround(axisPosition, Vector3.up, 90);
}

private void closeDoor()
{
    isOpen = false;
	isOpening = false;
	isClosing = true;
 	//Vector3 axisPosition = axis.transform.position;
    //door.transform.RotateAround(axisPosition, Vector3.up, -90);
}

    void OnTriggerEnter(Collider collider){
        if(collider.gameObject.tag == "Player"){
            canToggle = true;
        }
    }
    
    void OnTriggerExit(Collider collider){
        if(collider.gameObject.tag == "Player"){
            canToggle = false;
        }
    }
  
 
}
