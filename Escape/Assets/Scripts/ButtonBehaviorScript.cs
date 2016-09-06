using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonBehaviorScript : MonoBehaviour {

    // used for loading a new scene
    //use inspector to input name
    public string choice1;
    public string choice2;

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

    public void BackButton()
    {
        SceneManager.LoadScene("Main");
    }

    public void Choice_1()
    {
        SceneManager.LoadScene(choice1);
    }

    public void Choice_2()
    {
        SceneManager.LoadScene(choice2);
    }
}
