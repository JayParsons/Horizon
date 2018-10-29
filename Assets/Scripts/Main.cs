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
        for (int i = 0; i < 20000; i++)
        {
            //set position of new star randomly
            float x = Random.Range(-200, 200);
            float y = Random.Range(-200, 200);
            float z = Random.Range(-200, 200);

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
