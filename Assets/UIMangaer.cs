using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMangaer : MonoBehaviour {

    public GameObject modelManager;
    public Sprite[] SelectedSprite;
    public Sprite[] NormalSprite;
    public Image[] SliderImages;

    public GameObject information;
    int selectedItem = -1;
	// Use this for initialization
	void Start () {
        DeselectAll();


	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SelectModel(int p)
    {
        modelManager.SendMessage("setModel",p);
        DeselectAll();
        SliderImages[p].sprite = SelectedSprite[p];

    }

    void DeselectAll()
    {
        for(int i=0;i<SliderImages.Length;i++)
        {
            SliderImages[i].sprite = NormalSprite[i];
        }
    }

    void ToggleInformation(bool state)
    {
        information.SetActive(state);
    }
}
