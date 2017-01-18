using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoFinPartida : MonoBehaviour {

	public AudioSource audioSource;
	public AudioClip completado;
	public AudioClip gameOver;

	public void GameOver(){
	
		audioSource.clip = gameOver;

	}

		

}
