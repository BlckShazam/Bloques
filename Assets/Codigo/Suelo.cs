using UnityEngine;
using System.Collections;

public class Suelo : MonoBehaviour {

    public Vidas vidas;

    private void OnTriggerEnter(Collider other)
    {
        vidas.PerderVida();
    }
}
