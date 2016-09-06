using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextBoxManager : MonoBehaviour {

    public GameObject textBox;
    public Text fileText;
    public TextAsset textFile;
    public GameObject background;
    string[] textLines;
    int currentLine;
    int endLine;
    string sceneName;

    //Button locations
    Vector3 location_1 = new Vector3(-167.5f, 15,0);
    Vector3 location_2 = new Vector3(151.5f, 15,0);

    //button variables for creating new choices
    public Button choice_1;
    public Button choice_2;

    // Use this for initialization
    void Start()
    {
        if (textFile != null)
        {
            textLines = textFile.text.Split('\n');
        }

        if (endLine == 0)
        {
            endLine = textLines.Length - 1;
        }
    }
	
	// Update is called once per frame
	void Update () 
    {
	    fileText.text = textLines[currentLine];

        if (Input.GetKeyDown(KeyCode.Space) &&
            currentLine < endLine)
        {
            currentLine += 1;
        }

        if (fileText.text.Contains("+"))
        {
            background.SetActive(false);
            currentLine += 1;
        }

        if (currentLine == endLine)
        {
            //activate choice buttons in scene
            choice_1.gameObject.SetActive(true);
            choice_2.gameObject.SetActive(true);
        }
	}
}
