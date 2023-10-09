using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f;
    public float fuerzaSalto = 10.0f;
    private bool enSuelo;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Obtener la posición del mouse en el mundo
        Vector3 posicionMouse = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.y));
        posicionMouse.y = transform.position.y; // Mantener la misma altura que el jugador

        // Rotar el jugador para que mire hacia la posición del mouse
        transform.LookAt(posicionMouse);

        // Mover el jugador en la dirección hacia la que apunta
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical);
        movimiento = transform.TransformDirection(movimiento.normalized * velocidadMovimiento * Time.deltaTime);

        // Saltar
        if (Input.GetButtonDown("Jump") && enSuelo)
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
            enSuelo = false;
        }

        // Aplicar movimiento
        rb.velocity = new Vector3(movimiento.x, rb.velocity.y, movimiento.z);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            enSuelo = true;
        }
    }
}
