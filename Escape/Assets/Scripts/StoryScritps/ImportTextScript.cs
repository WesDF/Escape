﻿using UnityEngine;
using System.Collections;

public class ImportTextScript : MonoBehaviour 
{
    public TextAsset textFile;
    public string[] textLines;

    // Use this for initialization
	void Start () 
    {
	    if (textFile != null)
        {
            textLines = textFile.text.Split('\n');
        }
	}
}
