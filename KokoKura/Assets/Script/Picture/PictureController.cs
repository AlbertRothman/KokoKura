using UnityEngine;
using System.Collections;

public class PictureController : MonoBehaviour {
	public GameObject[] pictures;
	// Use this for initialization
	void Start () {
		for (int i=0; i < pictures.Length; i++) {
			pictures [i].GetComponent<Renderer> ().enabled = false;
		}
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.J)) {
			pictures[1].GetComponent<Renderer>().enabled = true;
			StartCoroutine(DisablePicture(1, .5f));
		}
		if (Input.GetKeyDown (KeyCode.H)) {
			pictures[0].GetComponent<Renderer>().enabled = true;
			StartCoroutine(DisablePicture(0, .5f));
		}

	}

	IEnumerator DisablePicture(int i, float delay){
		yield return new WaitForSeconds(delay);
		pictures[i].GetComponent<Renderer>().enabled = false;
	}
}
