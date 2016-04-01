using UnityEngine;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class Room : MonoBehaviour {


    [SerializeField]
    private List<Light> lights;

    [SerializeField]
    internal Text roomName;

    internal float intensity;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            lightsOn();
        }
        roomName.gameObject.SetActive(true);

    }

    private void lightsOn()
    {
        for (int i = 0; i < lights.Count; i++)
        {
            lights[i].intensity = intensity;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            lightsOff();
        }
        roomName.gameObject.SetActive(false);

    }

    private void lightsOff()
    {
        for (int i = 0; i < lights.Count; i++)
        {
            lights[i].intensity = 0f;
        }
    }



    // Use this for initialization
    void Start () {
        roomName.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
