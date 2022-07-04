using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using System;

    //1.Prevalent Emotion
    //2.Neutral

    //Use the biggest data to set color saturation
    //3.Happiness
    //4.Surprise
    //5.Sadness
    //6.Anger
    //7.Disgust
    //8.Fear

    //Size of the VFX
    //9.Engagement       


    //10.Valence


public class Function_VFX_Meeting : MonoBehaviour
{

    float intensity=0.5f;


    public static void ChangeColor(VisualEffect visualEffect,float emotionData)
    {
        visualEffect.SetVector4("Color",new Vector4(emotionData/100*255,30,30,0));
        
        
        //visualEffect.SetFloat("_Intensity",0f);
        //_Intensity ("Intensity",Float) = 0


        Debug.Log(emotionData);

    }


}
