using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class autoAttach : MonoBehaviour {


    Canvas canvas;
    GridLayoutGroup gridLayout;

	// Use this for initialization
	void Start () {
        canvas = this.GetComponentInParent<Canvas>();
        gridLayout = this.GetComponent<GridLayoutGroup>();
	}
	
	// Update is called once per frame
	void Update () {
       
	}
}
