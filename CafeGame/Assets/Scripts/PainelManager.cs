using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PainelManager : MonoBehaviour
{
    public List<Comida> comidas;

    private int paginaAtual = 0;
    private int paginaAnterior;
    private TMP_Text textoNomeComida;
    private TMP_Text textoIngredientes;
    private Comida comidaAtual;

    void Start()
    {
        comidaAtual = null;
        textoNomeComida = GameObject.Find("Comida").GetComponent<TMP_Text>();
        textoIngredientes = GameObject.Find("Ingredientes").GetComponent<TMP_Text>();

        MostrarProximaComida();
    }

    void Update()
    {
        if (textoNomeComida == null && textoIngredientes == null)
            return;


        if(paginaAtual != paginaAnterior)
            MostrarProximaComida();

        paginaAnterior = paginaAtual;
    }

    private void MostrarProximaComida()
    {
        comidaAtual = comidas[paginaAtual];

        textoNomeComida.text = comidaAtual.nome;

        textoIngredientes.text = "";

        foreach (var ingrediente in comidaAtual.ingredientes)
        {
            textoIngredientes.text += $" {ingrediente.name}";
        }
    }

    public void PassarPagina(int direcao)
    {
        paginaAtual = paginaAtual + direcao;

        if(paginaAtual > comidas.Count-1)
        {
            paginaAtual = 0;
        }
        else if(paginaAtual < 0)
        {
            paginaAtual = comidas.Count - 1;
        }
    }
}
