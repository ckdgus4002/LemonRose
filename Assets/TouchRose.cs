using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class TouchRose : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnTriggerEnter(Collider col)
    {
        if(col.transform.tag == "Player")
			SceneManager.LoadScene (3);
        if(col.transform.tag == "Zombie")
			SceneManager.LoadScene (3);
    }
}
