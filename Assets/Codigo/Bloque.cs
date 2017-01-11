using UnityEngine;
using System.Collections;

public class Bloque : MonoBehaviour {

    public GameObject efectoParticulas;

    //Is Trigger DESACTIVADO
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(efectoParticulas, transform.position, Quaternion.identity);
        Destroy(gameObject);

    }
}
