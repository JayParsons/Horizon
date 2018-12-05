using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene3ShipMotion : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().AddForce(transform.forward * Time.deltaTime * 1000);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
