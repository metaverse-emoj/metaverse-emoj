using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShader : MonoBehaviour
{
    private Material material;

    
    void Start()
    {
        material= GetComponent<Renderer>().material;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){

            //Debug.Log(material.name);

            material.SetColor("_Color",Color.blue);

            //material.color=Color.blue;
            //material.SetVector("_EdgeColor",new Vector4(1,1,1,1));
            //material.SetFloat("_Dissolve",0.9f);

            GetComponent<Renderer>().material = material;
            
        }
       
    }
}
