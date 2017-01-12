using UnityEngine;
using System.Collections;

public class Bloque : MonoBehaviour {

    public GameObject efectoParticulas;
    public Puntos puntos;
    //Is Trigger DESACTIVADO
    private void OnCollisionEnter()
    {
        Instantiate(efectoParticulas, transform.position, Quaternion.identity);
        Destroy(gameObject);
        puntos.GanarPunto();
    }
}
