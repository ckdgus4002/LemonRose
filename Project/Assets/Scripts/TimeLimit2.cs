using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class TimeLimit2 : MonoBehaviour { 
    float timeRemaining = 1800;


    void Update() {
        timeRemaining -= Time.deltaTime;
    }
    void OnGUI() {
        if(timeRemaining > 1) {
            GUI.Label(new Rect(100, 100, 200, 100), "허기 : " + (int)timeRemaining);
        }
        else {
			SceneManager.LoadScene (2);
        }
    }
}