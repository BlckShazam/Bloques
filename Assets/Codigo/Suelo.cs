using UnityEngine;
using System.Collections;

public class Suelo : MonoBehaviour
{

    public AudioSource errorSuelo;

    public Vidas vidas;

    private void OnTriggerEnter(Collider other)
    {
        vidas.PerderVida();
    }

    void OnTriggerEnter ()
    {
        if (gameObject.CompareTag("Suelo"))
        {
            errorSuelo.Play();
        }
    }
}
