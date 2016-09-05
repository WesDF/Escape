using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonBehaviorScript : MonoBehaviour {

	public void StartGame()
    {
        SceneManager.LoadScene("Story_0");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void instructionsPage()
    {
        SceneManager.LoadScene("InstructionsScene");
    }
}
