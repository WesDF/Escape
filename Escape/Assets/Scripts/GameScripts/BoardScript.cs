﻿using UnityEngine;
using System.Collections;

public class BoardScript : MonoBehaviour {

    Vector3 mousePosition;
    float moveSpeed = 0.1f;
    Vector3 boardPosition;
    Rect boardRect;
    Vector3 playerPos;

    // Use this for initialization
    void Start () {

        // get rect attached to game componant
        boardRect = GetComponent<SpriteRenderer>().sprite.rect;
	}
	
	// Update is called once per frame
	void Update () {




        // have board follow mouse x position
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        boardPosition = new Vector3(mousePosition.x, transform.position.y, 0);
        transform.position = Vector2.Lerp(transform.position, boardPosition, moveSpeed);

        // keep board in screen
        /*if (boardPosition.x <= 0 + (boardRect.width))
        {
            boardPosition = new Vector3(boardRect.width, transform.position.y, 0);
        }
        if (boardPosition.x >= Camera.main.pixelRect.width - (boardRect.width))
        {
            boardPosition = new Vector3(Camera.main.pixelRect.width - (boardRect.width), transform.position.y, 0);
        }*/

        //clamp paddle in playing field
        float xPos = transform.position.x + (Input.GetAxis("Horizontal") * moveSpeed);
        playerPos = new Vector3(Mathf.Clamp (xPos, -7.75f, 7.75f), -4.5f, 0);
        transform.position = playerPos;
    }
    /// <summary>
    /// returns the Vector3 boardPosition
    /// </summary>
    /// <returns></returns>
    public Vector3 getBoardPosition()
    {
        return this.boardPosition;
    }
}
