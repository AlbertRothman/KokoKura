using UnityEngine;
using System.Collections;

public class MusicControl : MonoBehaviour {


	public AudioSource[] audios;

	void Awake(){
		InvokeRepeating ("PlayBeat", 1, 0.6f);

	}
	void PlayBeat(){
		audios[1].Play();
	}

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			//if(!audios[0].isPlaying){
				audios[0].Play();
			//}
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			//if(!audios[2].isPlaying){
				audios[2].Play();
			//}
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			//if(!audios[4].isPlaying){
				audios[4].Play();
			//}
		
		}
		if (Input.GetKeyDown (KeyCode.F)) {
			//if(!audios[6].isPlaying){
				audios[6].Play();
			//}
		}
		if (Input.GetKeyDown (KeyCode.L)) {
			//if(!audios[1].isPlaying){
				audios[1].Play();
			//}
		}
		if (Input.GetKeyDown (KeyCode.K)) {
			if(!audios[3].isPlaying){
				audios[3].Play();
			}
		}
		if (Input.GetKeyDown (KeyCode.J)) {
			//if(!audios[5].isPlaying){
				audios[5].Play();
			//}
		}
		if (Input.GetKeyDown (KeyCode.H)) {
			//if(!audios[7].isPlaying){
				audios[7].Play();
			//}
		}
	}

}
