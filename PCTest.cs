using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PCTest : MonoBehaviour {

    public Button button1;
    public GameObject box;
    public static bool isOpen = false;
    // Use this for initialization
    void Start ()
    {
        //GetComponent<Button>().onClick.Invoke();
	}
	
	// Update is called once per frame
	void Update ()
    {
        /*if (button1.onClick())
        {
            isOpen = !isOpen;
        }*/

        if (isOpen)
        {
            box.SetActive(true);
            Time.timeScale = 0;
        }
        else if (!isOpen)
        {
            box.SetActive(false);
            Time.timeScale = 1;
        }
        
    }

    public void UnOpen()
    {
        isOpen = !isOpen;
    }

    public void UnOpen1()
    {
        isOpen = !isOpen;
    }
}
