using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostraComida : MonoBehaviour
{
    [SerializeField]
    private Transform comidaOffset;

    public Comida comida;

    public GameObject comidaAMostra;

    private void Start()
    {
        //Instantiate(comida.modelo == null ? comidaAMostra : comida.modelo, comidaOffset.transform.position, comidaOffset.transform.rotation);
    }

    private void Update()
    {
        
    }

    public void EscolherComida(Comida com)
    {
        comida = com;
    }
}
