using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleCanvas1 : MonoBehaviour
{
    
    public GameObject PuzzleCanvas;
    bool pressE;
    bool isInside;

    void Start()
    {
        pressE = true;
        isInside = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            isInside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            isInside = false;
        }
    }

    void Update()
    {
        if(isInside)
        {
            Debug.Log("Inside");
            //PuzzleCanvas.SetActive(true);
            if(Input.GetKeyDown(KeyCode.Space))
            {
                PuzzleCanvas.SetActive(true);
                if(pressE)
                {
                    pressE = !pressE;
                    PuzzleCanvas.SetActive(true);
                }
                else
                {
                    pressE = !pressE;
                    PuzzleCanvas.SetActive(false);
                }
            }
        }
    }
    
}
