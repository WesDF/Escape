using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextBoxManager : MonoBehaviour {

    public GameObject textBox;
    public Text fileText;
    public TextAsset textFile;
    public string[] textLines;
    public int currentLine;
    public int endLine;
    public string sceneName;

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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentLine += 1;
        }

        if (currentLine > endLine)
        {
            textBox.SetActive(false);
            SceneManager.LoadScene(sceneName);
        }
	}
}
