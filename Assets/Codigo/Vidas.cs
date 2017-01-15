using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Vidas : MonoBehaviour {

    public static int vidas = 3;
    public Text textoVidas;
    public Pelota pelota;
    public Barra barra;

    public GameObject gameOver;
    public SiguienteNivel siguienteNivel;

	// Use this for initialization
	void Start () {

        ActualizarMarcadorVidas();
	}

    void ActualizarMarcadorVidas() {

        textoVidas.text = "Vidas: " + Vidas.vidas;
    }

    public void PerderVida() {

        if (vidas <= 0) return;

        Vidas.vidas--;
        ActualizarMarcadorVidas();

        if(vidas <= 0){
            //Mostramos GameOver
            gameOver.SetActive(true);
            pelota.DetenerMovimiento();
            barra.enabled = false;
            siguienteNivel.nivelACargar = "Portada";
            siguienteNivel.ActivarCarga();

        }else{

            barra.Reset();
            pelota.Reset();
        }
    }
}
