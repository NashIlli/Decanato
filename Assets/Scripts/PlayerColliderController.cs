using UnityEngine;
using System.Collections;

public class PlayerColliderController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnControllerColliderHit(ControllerColliderHit hit) {
		if (hit.gameObject.name.Equals ("CuboColor")) {
			hit.gameObject.GetComponent<Cube> ().ChangeColor ();
		}
	}
}
