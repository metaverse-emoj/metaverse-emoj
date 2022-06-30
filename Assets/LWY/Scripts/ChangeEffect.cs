using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ChangeEffect : MonoBehaviour
{   
    public MainScript script;
    double[] newResults;
    public GameObject Cube;
    public GameObject HeartEffect;
    private ParticleSystem ps;

    private float timer=0;
    private float delayTime=1;




    // Start is called before the first frame update
    void Start()
    {   
        // newResults = new double[10];
        // GameObject go = GameObject.Find("Script");
        // newResults = go.GetComponent<MainScript>().results;
        //Effect1 = GameObject.FindGameObjectWithTag("Fire");

        ps=HeartEffect.GetComponent<ParticleSystem>();
        
        /*Transform[] HeartEffect = GetComponentsInChildren<Transform>();

        foreach (var child in HeartEffect){
        } 
        */

    }    


    void Update()
    {   
        newResults = script.results;
        Debug.Log("anger:"+newResults[6]);

        /*if(newResults[6]*100>50.0)
		{
			Cube.GetComponent<Renderer>().material.color = Color.red;
		}
        else
        {   
            Cube.GetComponent<Renderer>().material.color = Color.blue;
        }*/
        timer+= Time.deltaTime;
        if(timer>=delayTime){
            ChangeHeartColor();
            timer=0;
        }
        

    }


    private void ChangeHeartColor(){
        var col = ps.colorOverLifetime;
        col.enabled = true;
        Gradient grad = new Gradient();
        

        /*
        if(newResults[3]*100<25.0){

            grad.SetKeys( new GradientColorKey[] { new GradientColorKey(Color.blue, 0.0f), new GradientColorKey(Color.blue, 1.0f)}, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) } );

            col.color = grad;

             }

        else{
            
            grad.SetKeys( new GradientColorKey[] { new GradientColorKey(Color.red, 0.0f), new GradientColorKey(Color.red, 1.0f)}, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) } );

            col.color = grad;
            
        }
        */

        (double max, int sequence)=GetMax(newResults);
        switch(sequence){
            case 3:
            grad.SetKeys( new GradientColorKey[] { new GradientColorKey(Color.yellow, 0.0f), new GradientColorKey(Color.yellow, 1.0f)}, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) } );
            col.color = grad;
                break;

            case 4:
            
            grad.SetKeys( new GradientColorKey[] { new GradientColorKey(Color.red, 0.0f), new GradientColorKey(Color.red, 1.0f)}, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) } );
            col.color = grad;

                break;

            case 5:
            grad.SetKeys( new GradientColorKey[] { new GradientColorKey(Color.blue, 0.0f), new GradientColorKey(Color.blue, 1.0f)}, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) } );
            col.color = grad;
                break;

        }


    }


    private static (double,int) GetMax (double[]array){

        double max=array[2];
        int sequence=2;
        for(int i=3;i<7;i++){
            if(max<array[i]){
                max=array[i];
                sequence=i;
            }
        }
        return(max,sequence);
    }
}



