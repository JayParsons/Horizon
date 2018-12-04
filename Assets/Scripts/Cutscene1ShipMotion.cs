using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene1ShipMotion : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().AddForce(transform.forward * Time.deltaTime * 3000);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
