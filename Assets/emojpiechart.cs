using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class emojpiechart : MonoBehaviour
{
    public GameObject PieChart;
    float emotionData;
    double[] newResults;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        emotionData=Function_DoubletoFloat.emoMath(newResults[6]);
        newResults = MainScript.results;
        Debug.Log(newResults[1]);
        
       // newResults = script.results;
        //Debug.Log(PieChart);
        //Debug.Log("anger:" + newResults[3]);
    }
}
