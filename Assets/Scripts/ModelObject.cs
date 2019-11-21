using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelObject : MonoBehaviour {

    public GameObject[] models;
    
    private int selected;

    

    float scaleFactor = 1.5f;
	// Use this for initialization
	void Start () {
        
    }

    void DisableAll()
    {
        for(int i=0;i<models.Length;i++)
        {
            models[i].SetActive(false);
        }
    }

    void EnableeAll()
    {
        for (int i = 0; i < models.Length; i++)
        {
            models[i].SetActive(true);
            
        }
    }

    // Update is called once per frame
    void Update () {

        /*if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Zooming");
            // Store both touches.
            //Touch touchZero = Input.GetTouch(0);
            //Touch touchOne = Input.GetTouch(1);

            // Find the position in the previous frame of each touch.
            models[selected].transform.localScale *= scaleFactor;

            
        }*/

    }

    public void EnableModel(int i)
    {


        

        selected = i;
        scaleFactor = 1.5f;
        Debug.Log("eye has been clicked");
        DisableAll();
        if(selected!=-1)
        {
            models[i].SetActive(true);
        }
        else
        {
            EnableeAll();   
        }
        
    }

    public void ZoomModel(int s)
    {
        if (selected != -1)
        {
            if (s == 0)
            {
                models[selected].transform.localScale *= scaleFactor;
            }
            else
                models[selected].transform.localScale /= scaleFactor;
        }
    }
}
