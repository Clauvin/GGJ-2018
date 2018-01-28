using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuActions : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayButtonAction()
    {
        Closed_Basics_3.LoadScene.Load(1);
    }

    public void SettingsButtonAction()
    {

    }

    public void CreditsButtonAction()
    {

    }

    public void CloseButtonAction()
    {
        Closed_Basics_3.LoadScene.CloseGame();
    }
}
