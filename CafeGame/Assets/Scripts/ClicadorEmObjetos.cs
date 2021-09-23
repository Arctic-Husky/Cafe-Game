using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicadorEmObjetos : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
                if(hit.collider.name == "Fogao")
                {
                    GameObject objeto = hit.transform.gameObject;
                    print(hit.collider.name);
                    //var fogao = hit.transform.gameObject;//GetComponentInChildren<Canvas>();
                    var canvas = objeto.transform.Find("Canvas Fogao");
                    canvas.gameObject.SetActive(!canvas.gameObject.activeInHierarchy);
                }
        }
    }
}
