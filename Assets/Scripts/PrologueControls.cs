using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrologueControls : MonoBehaviour {

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
        yield return new WaitForSecondsRealtime(3);
        gameObject.transform.GetChild(1).gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
        gameObject.transform.GetChild(2).gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
        gameObject.transform.GetChild(3).gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
        gameObject.transform.GetChild(4).gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
        gameObject.transform.GetChild(5).gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
        gameObject.transform.GetChild(6).gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
        SceneManager.LoadScene("Level1");
    }
}
