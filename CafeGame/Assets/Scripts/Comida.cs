using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Nova Comida", menuName = "Comida")]
public class Comida : ScriptableObject
{
    public GameObject modelo;

    public float tempoDeCozimento;

    public Ingrediente[] ingredientes;

    public string nome;
}
