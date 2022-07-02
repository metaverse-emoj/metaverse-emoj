using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ChangeEffect : MonoBehaviour
{
    
    //Receive MainScript
    //public MainScript script; 不用拖，直接获取即可
    double[] newResults;
    

    //Set Objects
    public GameObject VFXElement;
    private ParticleSystem ps;



    //Set time delay, not detect so fast
    private float timer = 0;
    private float delayTime = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        newResults = MainScript.results;
        Debug.Log("Fuckanger:" + newResults[6]);





    }

    }




