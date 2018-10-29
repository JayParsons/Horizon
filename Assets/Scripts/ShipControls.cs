using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControls : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //ship moves forward a little by default
        GetComponent<Rigidbody>().AddForce(transform.forward * Time.deltaTime * 300);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Pressing up arrow");
            GetComponent<Rigidbody>().AddForce(transform.forward * Time.deltaTime * 600);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Pressing down arrow");
            GetComponent<Rigidbody>().AddForce(-transform.forward * Time.deltaTime * 600);
        }

        //Pressing 'A' or 'D' allows the player and the camera to be roated side to side
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

    }
}
