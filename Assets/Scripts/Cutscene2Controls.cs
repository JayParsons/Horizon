using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene2Controls : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //iterate through all of the child objects of our canvas to
        //make them all inactive
        gameObject.SetActive(true);

        for (int i = 0; i < gameObject.transform.childCount; i++)
            gameObject.transform.GetChild(i).gameObject.SetActive(false);

        StartCoroutine(Wait());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(3);
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(10);
        SceneManager.LoadScene("AnnaLeeStation");
    }
}
