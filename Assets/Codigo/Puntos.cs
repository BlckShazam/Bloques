using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Puntos : MonoBehaviour {

    public static int puntos = 0;
    public Text textoPuntos;

	// Use this for initialization
	void Start () {
	
	}
	
    void ActualizarMarcadorPuntos()
    {
        textoPuntos.text = "Puntos: " + Puntos.puntos;

    }

    public void GanarPunto()
    {
        Puntos.puntos++;
        ActualizarMarcadorPuntos();
    }
}
