using UnityEngine;
using System.Collections;

public class CONSTANTS : MonoBehaviour {

    private static float ballInitial = 400f;
    private static int numAlarms = 4;
    
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public static float getBallInitial()
    {
        return ballInitial;
    }

    public static void setBallInitial(float newBallInitial)
    {
        ballInitial = newBallInitial;
    }

    public static int getNumAlarms()
    {
        return numAlarms;
    }

    public static void setNumAlarms(int newNumAlarms)
    {
        numAlarms = newNumAlarms;
    }
}
