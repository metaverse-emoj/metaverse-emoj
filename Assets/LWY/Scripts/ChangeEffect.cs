using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.VFX;


public class ChangeEffect : MonoBehaviour
{
    
    //Receive MainScript
    double[] newResults;
    
    //Receive biggest emotionData
    float emotionData;
    

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

            emotionData=Function_DoubletoFloat.emoMath(newResults[6]);

            if(emotionData>50.0f)
            {
                Function_VFX_Meeting.ChangeColor(visualEffect,emotionData);
                //Debug.Log(xxx);

            }


        }


    }

    }




