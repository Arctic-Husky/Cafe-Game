using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostraComida : MonoBehaviour
{
    public Comida comida;

    private void Start()
    {
        Instantiate(comida.modelo, transform.position, Quaternion.identity);
    }

    private void Update()
    {
        
    }
}
