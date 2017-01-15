using UnityEngine;
using System.Collections;

public class Pelota : MonoBehaviour {

    public float velocidadInicial = 600f;

    public Rigidbody rig;

    bool enJuego;

    Vector3 posicionInicial;

    Transform barra;


    private void Awake()
    {
        barra = transform.parent; 
        //para obtener otro Transform de otro padre: barra = transform.parent.GetComponent<NombreDelComponenteAObtenerSuReferencia>();

    }
    // Use this for initialization

    void Start () {
        posicionInicial = transform.position;
	
	}
    public void Reset()
    {
        transform.position = posicionInicial;
        transform.SetParent(barra);
        enJuego = false;
        DetenerMovimiento();
    }
    public void DetenerMovimiento() {

        rig.isKinematic = true;
        rig.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update () {
        if (!enJuego && Input.GetButtonDown("Fire1")) {
            enJuego = true;
            transform.SetParent(null);
            rig.isKinematic = false;
            rig.AddForce(new Vector3(velocidadInicial, velocidadInicial, 0));
        }
	
	}
}
