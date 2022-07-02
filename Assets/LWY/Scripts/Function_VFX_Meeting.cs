using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;


public class Function_VFX_Meeting : MonoBehaviour
{
    //Set Objects, not here!
    //public GameObject VFXElement;


    public static void ChangeColor(VisualEffect visualEffect)
    {
        visualEffect.SetVector4("Color",new Vector4(255,0,0,0));
        Debug.Log("VFX works");

    }
}
