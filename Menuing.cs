using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuing : MonoBehaviour {
    public Canvas canvas1;
    public Canvas canvas2;

	// Use this for initialization
	void Start ()
    {
        canvas1.enabled = true;
        canvas2.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        print("exiting now");
#else
        Application.Quit();
        print ("exiting now!");
#endif
    }
    public void start1()
    {
        SceneManager.LoadScene("CamerasWorkingMoving");
    }
    public void canvasenable()
    {
        canvas1.enabled = false;
        canvas2.enabled = true;
    }

}
