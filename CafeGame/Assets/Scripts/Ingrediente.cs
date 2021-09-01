using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Novo Ingrediente", menuName = "Ingrediente")]
public class Ingrediente : ScriptableObject
{
    public GameObject modelo;

    public float preco;

    public string nome;
}
