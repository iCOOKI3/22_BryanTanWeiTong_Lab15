using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{

    public AudioClip[] AudioClipArr;

    private AudioSource audioSource;
    private float volume;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        int rand = Random.Range(0, AudioClipArr.Length);
        audioSource.PlayOneShot(AudioClipArr[rand]);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            audioSource.volume = volume+=0.2f * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            audioSource.volume = volume-=0.2f * Time.deltaTime;
        }
    }
}
