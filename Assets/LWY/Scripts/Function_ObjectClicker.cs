using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Function_ObjectClicker : MonoBehaviour
{
    public Camera _mainCamera;

    private Ray _ray;
    private RaycastHit _hit;

    
    private void Start() {
        _mainCamera = Camera.main;
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _ray = new Ray(
                _mainCamera.ScreenToWorldPoint(Input.mousePosition),
                _mainCamera.transform.forward);


            if (Physics.Raycast(_ray, out _hit,1000f))
            {
                //Select stage    
                if (_hit.transform == transform)
                    {
                        Debug.Log("Sitdown");
                    }
            }
        }
    }
}
