using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIBehaviour : MonoBehaviour
{
    /*All buildings menu*/
    public GameObject buildAll;
    //Use this file to handle all UI functions
    void Start()
    {
        buildAll.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleBuildAll()
    {
        if (buildAll.activeSelf)
        {
            buildAll.SetActive(false);
            CamTouchMove.interactUI = false;
        }
        else
        {
            buildAll.SetActive(true);
            CamTouchMove.interactUI = true;
        }
    }
    public void ResetLevel()
    {
        SceneManager.LoadScene("EcoCities");
    }
}
