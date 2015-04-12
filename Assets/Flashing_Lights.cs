using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Flashing_Lights : MonoBehaviour {

	public virtual float timeFlashing { 
		get {
			return 0.1F;
		} 
	}

	// Use this for initialization
	IEnumerator Start () {
		const int NUM_BOLTS = 15;
		Light lightning = GetComponent<Light>();
		lightning.enabled = false;
		for (int i = 0; i < NUM_BOLTS; i++) {
			yield return new WaitForSeconds(Random.Range (1, 2));
			lightning.enabled = true;
			yield return new WaitForSeconds(timeFlashing);
			lightning.enabled = false;
			if (GetComponent<AudioClip>() != null){
				AudioClip thunder = GetComponent<AudioClip>();
				GetComponent<AudioSource>().Play();
			}
			yield return new WaitForSeconds(5);
			lightning.enabled = true;
			yield return new WaitForSeconds(timeFlashing);
			lightning.enabled = false;
		}
	}
}
