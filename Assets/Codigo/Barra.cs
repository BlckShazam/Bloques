using UnityEngine;
using System.Collections;

public class Barra : MonoBehaviour {
    public float velocidad = 0.4f;
    Vector3 posicionInicial;

	// Use this for initialization
	void Start () {
        posicionInicial = transform.position;
       
	
	}
   public void Reset()
    {
        transform.position = posicionInicial;
    }

    // Update is called once per frame
    void Update () {
        float tecladoHorizontal = Input.GetAxisRaw ("Horizontal");
        float posX = transform.position.x + (tecladoHorizontal * velocidad * Time.deltaTime); // Time.deltaTime calcula el tiempo en funcion de los fotogramas para ajustar la velocidad
        transform.position = new Vector3(Mathf.Clamp(posX, -8, 8), transform.position.y, transform.position.z); // Clamp define los maximos y minimos que puede tener un vector, 1� el valor actual, minimo y maximo.
        
	
	}
}
