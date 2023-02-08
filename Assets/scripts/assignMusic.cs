using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assignMusic: MonoBehaviour
{
    public AudioClip[] tracks;

    public GameObject Audio;
    void Start()
    {
        Audio.GetComponent<AudioSource>().AudioClip = tracks[PlayerPrefs.GetInt("skinNum")];
    }

}
