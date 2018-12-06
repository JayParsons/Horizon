using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControls : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //ship moves forward a little by default
        GetComponent<Rigidbody>().AddForce(transform.forward * Time.deltaTime * 6000);

        //set ship's weapon to inactive at the start of the scene
        gameObject.transform.GetChild(2).gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        //Pressing 'A' or 'D' allows the player and the camera to be rotated side to side
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Pressing A key");
            transform.RotateAround(GetComponent<Rigidbody>().position, Vector3.up, -1);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Pressing D key");
            transform.RotateAround(GetComponent<Rigidbody>().position, Vector3.up, 1);
        }

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Pressing W key");
            transform.RotateAround(GetComponent<Rigidbody>().position, Vector3.right, -1);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Pressing S key");
            transform.RotateAround(GetComponent<Rigidbody>().position, Vector3.left, -1);
        }

        if (Input.GetKey(KeyCode.Space)) {
            Debug.Log("Pressing space key");
            gameObject.transform.GetChild(2).gameObject.SetActive(true);
            gameObject.transform.GetChild(2).gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * Time.deltaTime * 8000);
        }

    }
}
