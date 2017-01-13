using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class EmpezarPartida : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1")) {

            SceneManager.LoadScene("Nivel01");
      }


	}
}
