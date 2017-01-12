using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Vidas : MonoBehaviour {

    public static int vidas = 3;
    public Text textoVidas;
    public Pelota pelota;
    public Barra barra;

	// Use this for initialization
	void Start () {

        ActualizarMarcadorVidas();
	}

    void ActualizarMarcadorVidas() {

        textoVidas.text = "Vidas: " + Vidas.vidas;
    }

    public void PerderVida()
    {
        Vidas.vidas--;
        ActualizarMarcadorVidas();

        barra.Reset();
        pelota.Reset();

    }
}
