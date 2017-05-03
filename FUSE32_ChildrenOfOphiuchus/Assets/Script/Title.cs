using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour {


    public string nextSceneName;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.Return))//Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel("Main");
        }

    }
}
