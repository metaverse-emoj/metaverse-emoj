using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class speedeffect : MonoBehaviour
{
    public MainScript script;
    double[] newResults;
    public GameObject Sphere;
    public Material Shader_2_1;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    //set emoj parameters to 0-100
    /*
    float emomath(double x)
    {   
        return (float)Math.Round(x * 100, 2);
    }
    */



    // Update is called once per frame
    void Update()
    
    
    {
       /* 
        newResults = MainScript.results;
        Debug.Log("anger!!:" + emomath(newResults[6]));
     
        if(Shader_2_1 != null){
            // time speed 
           
            Shader_2_1.SetFloat("_TimeSpeed",emomath(newResults[6]));
            // timeSpeedSliderLabel.text = $"Time Speed: {timeSpeedSlider.value}";
            // Shader_2_1.SetColor
            // noise scale
            // Shader_2_1.SetFloat("_NoiseScale", noiseScaleSlider.value);
            // noiseScaleSliderLabel.text = $"Noise Scale: {noiseScaleSlider.value}";
        }        
      */

    }
    
}
