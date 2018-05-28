﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {


    GameObject Car;
    GameObject flag;
    GameObject distance;

    // Use this for initialization
    void Start () {
        this.Car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }
	
	// Update is called once per frame
	void Update () {
        float length = this.flag.transform.position.x - this.Car.transform.position.x;
        if (length >= 0) { this.distance.GetComponent<Text>().text = "ゴールまで" + length.ToString("F2") + "m"; }
        else
        {
            this.distance.GetComponent<Text>().text = "GAMEOVER";
        }
	}
}
