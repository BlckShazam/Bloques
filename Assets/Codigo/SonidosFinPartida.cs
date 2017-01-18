using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosFinPartida : MonoBehaviour {

	public AudioSource audioSource;
	public AudioClip completado;
	public AudioClip gameOver;


    void Start(){


    }

    public void GameOver(){

        ReproduceSonido(gameOver);

	}
    public void NivelCompletado ()
    {

        ReproduceSonido(completado);

    }
    void ReproduceSonido(AudioClip sonido) {

        audioSource.clip = sonido;    //cambia el clip de audio al asignado.
        audioSource.loop = false;       //Desactiva el Loop del audio.
        audioSource.Play();             //Reproduce el clip de audio.
    }


}
