using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eyeclick : MonoBehaviour {

    public GameObject manager;
    public Text message;

    bool state;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void eyeClick()
    {
        int p = 4;
        message.text = "Eyes are organs of the visual system. They provide organisms with vision, the ability to receive and process visual detail, as well as enabling several photo response functions that are independent of vision. Eyes detect light and convert it into electro-chemical impulses in neurons.";
        manager.SendMessage("EnableModel", p);
        Debug.Log("eye has been clicked");
    }

    public void skelClick()
    {
        message.text = "";
        int p = 2;
        manager.SendMessage("EnableModel", p);
        Debug.Log("eye has been clicked");
    }

    public void BrainClick()
    {
        message.text = "The brain is one of the largest and most complex organs in the human body. It is made up of more than 100 billion nerves that communicate in trillions of connections called synapses.";
        int p = 3;
        manager.SendMessage("EnableModel", p);
        Debug.Log("Nose has been clicked");
    }
    public void HeartClick()
    {
        int p = 1;
        message.text = "The heart is a muscular organ in most animals, which pumps blood through the blood vessels of the circulatory system. Blood provides the body with oxygen and nutrients, as well as assisting in the removal of metabolic wastes.In humans, the heart is located between the lungs, in the middle compartment of the chest.";
        manager.SendMessage("EnableModel", p);
        Debug.Log("heart has been clicked");
    }
    public void LiverClick()
    {
        int p = 0;
        message.text = "The liver is a large, meaty organ that sits on the right side of the belly. ... The liver also detoxifies chemicals and metabolizes drugs.";
        manager.SendMessage("EnableModel", p);
        Debug.Log("liver has been clicked");
    }
    public void StomachClick()
    {
        message.text = "Stomach";
        Debug.Log("stomach has been clicked");
    }

    public void All()
    {
        int p = -1;
        message.text = "";
        manager.SendMessage("EnableModel", p);
    }
    public void ZoomIn()
    {
        
            int p = 0;
            manager.SendMessage("ZoomModel", p);
        
    }

    public void ZoomOut()
    {
        
            int p = 1;
            manager.SendMessage("ZoomModel", p);
        
    }
}
