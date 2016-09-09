using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class endGameCheck : MonoBehaviour {

    public string sceneName;
	
	// Update is called once per frame
	void Update () {
        GameObject go = GameObject.FindGameObjectWithTag("brick");

        if (go == null)
        {
            SceneManager.LoadScene(sceneName);
        } 
	}
}
