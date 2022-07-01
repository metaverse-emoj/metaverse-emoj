using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ChangeEffect : MonoBehaviour
{
    public MainScript script;
    double[] newResults;
    public GameObject Cube;

    private float timer = 0;
    private float delayTime = 1;


    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        newResults = script.results;
        // Debug.Log("anger:" + newResults[6]);

        if (newResults[6] * 100 > 50.0)
        {
            Cube.GetComponent<Renderer>().material.color = Color.red;
            // Debug.Log("RED");
        }
        else
        {
            Cube.GetComponent<Renderer>().material.color = Color.blue;
            // Debug.Log("BLUE");
        }

    }

    }




