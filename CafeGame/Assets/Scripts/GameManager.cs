using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instancia { get; private set; }

    public List<Comida> Comidas;
    public EstadoDoJogo EstadoAtualDoJogo;

    public static event Action<EstadoDoJogo> onEstadoDoJogoChanged;

    private void Awake()
    {
        Instancia = this;
    }

    private void Start()
    {
        UpdateEstadoDoJogo(EstadoDoJogo.rodando);
    }

    public void UpdateEstadoDoJogo(EstadoDoJogo novoEstado)
    {
        EstadoAtualDoJogo = novoEstado;

        switch(novoEstado)
        {
            case EstadoDoJogo.pausado:
                HandlePausado();
                break;
        }

        onEstadoDoJogoChanged?.Invoke(novoEstado);
    }

    private void HandlePausado()
    {

    }

    /// <summary>
    /// Chamar uma vez-> Pausa o jogo
    /// Chamar outra vez -> Resume o jogo
    /// </summary>
    public void PausarResumirJogo()
    {
        Time.timeScale = Time.timeScale == 0 ? 1 : 0;
    }

    void Update()
    {
        
    }
}
