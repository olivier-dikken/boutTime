using UnityEngine;
using System.Collections;

[RequireComponent (typeof (AudioSource))]

public class Video : MonoBehaviour {
    public bool operate;
	public MovieTexture movie;

	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().material.mainTexture = movie as MovieTexture;
        if (operate)
        {
            movie.Play();
            movie.loop = true;
        } else
        {
            movie.Stop();
        }       
	}
	
	
}