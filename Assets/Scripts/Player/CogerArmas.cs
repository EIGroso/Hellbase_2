using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogerArmas : MonoBehaviour
{
    public GameObject[] armas;
    public int armaActual = 0;
    public void ActivarArmar(int numero)
    {
        for(int i = 0; i < armas.Length; i++)
        {
            armas[i].SetActive(false);
        }

        armas[numero].SetActive(true);
    }

    public void CambiarArmaYActivarDesactivar(int numero)
    {
        // Desactivar todas las armas
        foreach (var arma in armas)
        {
            arma.SetActive(false);
        }

        // Activar el nuevo arma en el jugador
        armas[numero].SetActive(true);

        // Cambiar el número de arma actual en el jugador
        armaActual = numero;
    }
}
