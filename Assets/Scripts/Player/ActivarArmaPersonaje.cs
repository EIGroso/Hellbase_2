using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarArmaPersonaje : MonoBehaviour
{
    public CogerArmas cogerArmas;
    public int numeroArma;

    private void Start()
    {
        cogerArmas = GameObject.FindGameObjectWithTag("Player").GetComponent<CogerArmas>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // Llamar al método para cambiar el arma en el jugador y activar/desactivar las armas
            cogerArmas.CambiarArmaYActivarDesactivar(numeroArma);
        }
    }
}

