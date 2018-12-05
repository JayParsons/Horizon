using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene2ShipMotion : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().AddForce(transform.forward * Time.deltaTime * 2000);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
