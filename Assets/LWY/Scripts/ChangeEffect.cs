using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.VFX;


public class ChangeEffect : MonoBehaviour
{
    
    //Receive MainScript
    //public MainScript script; 不用拖，直接获取即可
    double[] newResults;
    

    //Set Objects
    public GameObject VFXElement;
    private VisualEffect visualEffect;
    



    //Set time delay, not detect so fast
    private float timer = 0;
    private float delayTime = 1;


    // Start is called before the first frame update
    void Start()
    {
        visualEffect=VFXElement.GetComponent<VisualEffect>();
    }

    void Update()
    {
        if(MainScript.results!=null)
        {
            newResults = MainScript.results;


            if(newResults[6]>0.5f)
            {
                Function_VFX_Meeting.ChangeColor(visualEffect);
                Debug.Log(newResults[6]);
            }


        }
        

        //Debug.Log("Fuckanger:" + newResults[6]);



    }

    }




