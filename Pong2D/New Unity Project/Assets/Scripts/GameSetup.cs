﻿using UnityEngine;
using System.Collections;

public class GameSetup : MonoBehaviour {


    public Camera mainCam;
    public BoxCollider2D topWall, bottomWall, leftWall, rightWall;
    public Transform Player01, Player02;

    public float distanceToWall = 30f;
	// Use this for initialization
	
	
	// Update is called once per frame
	void Start ()

    {
        topWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x,1f);
        topWall.offset = new Vector2(0f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y + 0.5f);

        bottomWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        bottomWall.offset = new Vector2(0f, mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).y - 0.5f);
        
        leftWall.size = new Vector2(1f,mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        leftWall.offset = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f,0f);

        rightWall.size = new Vector2(1f,mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        rightWall.offset = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f,0f);

        //Player01.position = new Vector2(mainCam.ScreenToViewportPoint(new Vector3(75f, 0f, 0f)).x,0f);
        Player01.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(distanceToWall,0f,0f)).x, 0f);
        Player02.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width - distanceToWall, 0f, 0f)).x, 0f);
    }
}
