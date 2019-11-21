using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modelManager : MonoBehaviour {


    public GameObject[] model;

	// Use this for initialization
	void Start () {
        DisableAll();
	}
	
    void DisableAll()
    {
        foreach(var item in model)
        {
            item.SetActive(false);
        }
    }


    void setModel(int p)
    {
        DisableAll();
        model[p].SetActive(true);   
    }

	// Update is called once per frame
	void Update () {
		
	}
}
