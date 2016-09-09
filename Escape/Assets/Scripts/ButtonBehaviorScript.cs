using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonBehaviorScript : MonoBehaviour {

    // used for loading a new scene
    //use inspector to input name
    public string[] choices = new string[6];

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
        CONSTANTS.setBallInitial(600f);
        SceneManager.LoadScene(choices[0]);
    }

    public void Choice_2()
    {
        CONSTANTS.setNumAlarms(8);
        SceneManager.LoadScene(choices[1]);
    }
    public void Choice_3()
    {
        //TODO: For the next person working, use this area to set things in the CONSTANTS Script. This will be how we modify gameplay to keep it consistent.
        SceneManager.LoadScene(choices[2]);
    }
    public void Choice_4()
    {
        SceneManager.LoadScene(choices[3]);
    }
    public void Choice_5()
    {
        SceneManager.LoadScene(choices[4]);
    }
    public void Choice_6()
    {
        SceneManager.LoadScene(choices[5]);
    }
}
