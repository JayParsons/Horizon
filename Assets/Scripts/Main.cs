using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {
    public GameObject star;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;

    //used for object pooling the three enemy types
    public List<GameObject> enemy1Pool;
    public List<GameObject> enemy2Pool;
    public List<GameObject> enemy3Pool;

    // Use this for initialization
    void Start () {
        CreateStarfield();

        //Since I don't have object pooling fully working, and am out of time,
        //I am going to spawn 50 of each enemy in the scene so the player can 
        //see what my enemy models look like. The enemies can't be destroyed yet.
        //This will all be fixed in the next iteration and the following loops removed
        for (int i = 0; i < 50; i++)
        {
            //set position of new star randomly
            float x = Random.Range(-100, 100);
            float y = Random.Range(-100, 100);
            float z = Random.Range(-100, 100);

            //place star in scene
            Instantiate(enemy1);
            Vector3 pos;
            pos.x = x;
            pos.y = y;
            pos.z = z;
            enemy1.transform.position = pos;
        }

        for (int i = 0; i < 50; i++)
        {
            //set position of new star randomly
            float x = Random.Range(-100, 100);
            float y = Random.Range(-100, 100);
            float z = Random.Range(-100, 100);

            //place star in scene
            Instantiate(enemy2);
            Vector3 pos;
            pos.x = x;
            pos.y = y;
            pos.z = z;
            enemy2.transform.position = pos;
        }

        for (int i = 0; i < 50; i++)
        {
            //set position of new star randomly
            float x = Random.Range(-100, 100);
            float y = Random.Range(-100, 100);
            float z = Random.Range(-100, 100);

            //place star in scene
            Instantiate(enemy3);
            Vector3 pos;
            pos.x = x;
            pos.y = y;
            pos.z = z;
            enemy3.transform.position = pos;
        }

        //CreateEnemyObjectPools();

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

    void CreateEnemyObjectPools()
    {
        //create a pool of 50 objects of each enemy type and store them in the appropriate arrays
        for (int i = 0; i < 50; i++)
        {
            //make sure each object is set to inactive to start.
            Instantiate(enemy1);
            enemy1.SetActive(false);
            enemy1Pool.Add(enemy1);

            Instantiate(enemy2);
            enemy2.SetActive(false);
            enemy2Pool.Add(enemy2);

            Instantiate(enemy3);
            enemy3.SetActive(false);
            enemy3Pool.Add(enemy3);
        }
    }

    void SpawnEnemy(GameObject g)
    {
        //to be used to spawn an enemy of whatever type is passed to the method
    }
}
