using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShader : MonoBehaviour
{
    public GameObject Ch03;
    public Material dissolveMat;
    public float health;
    public float maxHealth;
    
    void Start()
    {
        dissolveMat.SetFloat("", health / maxHealth);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("@##$#$");
            health -= 5;
            dissolveMat.SetFloat("", health / maxHealth);
            
            //Ch03.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
            //Debug.Log(material.name);

            //material.SetColor("_Color",Color.blue);

            //material.color=Color.blue;
            //material.SetVector("_EdgeColor",new Vector4(1,1,1,1));
            //material.SetFloat("_Dissolve",0.9f);

            //GetComponent<Renderer>().material = material;

        }
       
    }
}
