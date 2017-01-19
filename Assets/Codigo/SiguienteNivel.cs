using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SiguienteNivel : MonoBehaviour {

    public string nivelACargar;
    public float retraso;

    [ContextMenu("Activar Carga")]
    public void ActivarCarga()
    {
        Invoke("CargarNivel", retraso);
    }

    void CargarNivel()
    {
        if (!EsUltimoNivel() && Vidas.vidas<= 2) {
            Vidas.vidas++;
        }
        SceneManager.LoadScene(nivelACargar);
    }

    public bool EsUltimoNivel() {

        return nivelACargar == "Portada";
    }
}
