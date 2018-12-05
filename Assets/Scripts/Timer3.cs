using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer3 : MonoBehaviour {
    public GUIStyle style = new GUIStyle();
    public int firstDigit = 0, secondDigit = 9, thirdDigit = 9;
    bool timerFinished = false;
    private int timeUsed = 0;

    // Use this for initialization
    void Start()
    {
        //iterate through all of the child objects of our canvas to
        //make them all inactive
        gameObject.SetActive(true);

        for (int i = 0; i < gameObject.transform.childCount - 1; i++)
            gameObject.transform.GetChild(i).gameObject.SetActive(false);

        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {
        if (timeUsed == 5)
        {
            gameObject.transform.GetChild(30).gameObject.SetActive(true);
            gameObject.transform.GetChild(31).gameObject.SetActive(true);
        }

        if (timeUsed == 12)
        {
            gameObject.transform.GetChild(30).gameObject.SetActive(false);
            gameObject.transform.GetChild(31).gameObject.SetActive(false);
        }

        if (timeUsed == 40)
        {
            gameObject.transform.GetChild(30).gameObject.SetActive(true);
            gameObject.transform.GetChild(32).gameObject.SetActive(true);
        }

        if (timeUsed == 47)
        {
            gameObject.transform.GetChild(30).gameObject.SetActive(false);
            gameObject.transform.GetChild(32).gameObject.SetActive(false);
        }

        if (timeUsed == 70)
        {
            gameObject.transform.GetChild(30).gameObject.SetActive(true);
            gameObject.transform.GetChild(33).gameObject.SetActive(true);
        }

        if (timeUsed == 77)
        {
            gameObject.transform.GetChild(30).gameObject.SetActive(false);
            gameObject.transform.GetChild(33).gameObject.SetActive(false);
        }

        if (timeUsed == 90)
        {
            gameObject.transform.GetChild(30).gameObject.SetActive(true);
            gameObject.transform.GetChild(34).gameObject.SetActive(true);
        }

        if (timeUsed == 97)
        {
            gameObject.transform.GetChild(30).gameObject.SetActive(false);
            gameObject.transform.GetChild(34).gameObject.SetActive(false);
        }
    }

    private void OnGUI()
    {
        if (timerFinished == true)
        {
            style.fontSize = 20;
            style.fontStyle = FontStyle.BoldAndItalic;
            style.normal.textColor = Color.white;
            GUI.Label(new Rect(250, 0, 500, 50), "Jump Drive Activated!", style);
        }
    }

    private IEnumerator Wait()
    {
        for (int i = firstDigit; i >= 0; i--)
        {
            gameObject.transform.GetChild(i).gameObject.SetActive(true);
            for (int j = secondDigit; j >= 0; j--)
            {
                gameObject.transform.GetChild(10 + j).gameObject.SetActive(true);
                for (int k = thirdDigit; k >= 0; k--)
                {
                    gameObject.transform.GetChild(20 + k).gameObject.SetActive(true);
                    yield return new WaitForSecondsRealtime(1);
                    gameObject.transform.GetChild(20 + k).gameObject.SetActive(false);
                    timeUsed++;
                }
                gameObject.transform.GetChild(10 + j).gameObject.SetActive(false);
            }
            gameObject.transform.GetChild(i).gameObject.SetActive(false);
        }

        timerFinished = true;

        yield return new WaitForSecondsRealtime(3);
        SceneManager.LoadScene("CutScene3");
    }

}
