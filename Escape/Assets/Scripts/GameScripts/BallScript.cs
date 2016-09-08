using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour
{
    public float ballInitial = 600f;
    private Rigidbody2D rb;
    private bool ballgo;
    //Use this for initialization
    void Awake ()
    {
        rb = GetComponent<Rigidbody2D>();
    }	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetButtonDown("Fire1") && ballgo == false)
        {
            transform.parent = null;
            ballgo = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(ballInitial, ballInitial, 0));
        }
	}

}
