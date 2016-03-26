using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
    private GameObject axis;
	// Use this for initialization
	void Start () {
        axis = GameObject.Find("Eje");
	}
	
	// Update is called once per frame
    void Update() {
        Vector3 axisPosition = axis.transform.position;
        this.transform.RotateAround(axisPosition, Vector3.up, 20 * Time.deltaTime);
    }
}
