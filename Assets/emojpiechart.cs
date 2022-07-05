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
        newResults = MainScript.results;
        emotionData=Function_DoubletoFloat.emoMath(newResults[1]);
        Debug.Log("PIECHART"+emotionData);
        Debug.Log(PieChart);
       
       // newResults = script.results;
        //Debug.Log(PieChart);
        //Debug.Log("anger:" + newResults[3]);
    }
}
