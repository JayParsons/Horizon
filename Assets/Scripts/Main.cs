using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {
    public GameObject star;

	// Use this for initialization
	void Start () {
        CreateStarfield();
	}
	
	// Update is called once per frame
	void Update () {
       
    }

    void CreateStarfield()
    {
        for (int i = 0; i < 80000; i++)
        {
            //set position of new star randomly
            float x = Random.Range(-999, 999);
            float y = Random.Range(-999, 999);
            float z = Random.Range(-999, 999);

            //place star in scene
            Instantiate(star);
            Vector3 pos;
            pos.x = x;
            pos.y = y;
            pos.z = z;
            star.transform.position = pos;
        }
    }
}
