using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterFlame : MonoBehaviour
{
    AudioSource myAudio;
    bool musicStart = false;


    private void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!musicStart){
			Debug.Log("hungry veeehungryeeeeery hungry");
			Debug.Log("veeeeeeeery hungry");
			Debug.Log("veeeeeeeery hungry");

            if (collision.CompareTag("Note"))
            {
                myAudio.Play();
                musicStart = true;
            }
        }
    }

    void Update()
    {

    }
}
