using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Puntos : MonoBehaviour {

    public static int puntos = 0;
    public Text textoPuntos;

	public GameObject nivelCompletado;
	public GameObject juegoCompletado;

	public SiguienteNivel siguienteNivel;

	public Pelota pelota;

	public Barra barra;

	public Transform contenedorBloques;


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

		if (contenedorBloques.childCount <= 0) {
			pelota.DetenerMovimiento();
			barra.enabled = false;
		}
	} 

}
