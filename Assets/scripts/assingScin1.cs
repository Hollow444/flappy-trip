using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assingScin1 : MonoBehaviour
{
    public AudioClip[] audioClips;
    AudioSource mySource;
    public GameObject Player;

    void Start()
    {
        mySource = GetComponent<AudioSource>();
        
        mySource.clip = audioClips[PlayerPrefs.GetInt("skinNum")];
        mySource.Play();
    }

}
