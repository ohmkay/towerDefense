﻿using UnityEngine;

public class Waypoints : MonoBehaviour {

    public static Transform[] waypoints;

    void Awake ()
    {
        waypoints = new Transform[transform.childCount];

        for (int i = 0; i < waypoints.Length; i++)
        {
            transform.GetChild(i);
        }
    }

	void Start () {
		
	}
	
	void Update () {
		
	}
}
