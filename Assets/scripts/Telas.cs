using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Telas : MonoBehaviour {
	public AudioSource som;

	public AudioClip botaoIniciar;
	public AudioClip botaoCredito;
	public AudioClip botaoVoltar;

	void Update () {
	
	}
	public void iniciar(){
		SceneManager.LoadSceneAsync ("Jogo");
		som.PlayOneShot (botaoIniciar);
		
	}
	public void creditos(){
		SceneManager.LoadSceneAsync ("Credito");
		som.PlayOneShot (botaoCredito);

	}
	public void voltar(){
		SceneManager.LoadSceneAsync ("TelaPrincipal");
		som.PlayOneShot (botaoVoltar);

	}
}