using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{

    public AudioClip[] AudioClipArr;

    private AudioSource audioSource;
    private int AudioCounter;
    private int rand;
    private float volume;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rand = Random.Range(0, AudioClipArr.Length);
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
        if(Input.GetKey(KeyCode.Tab))
        {
            PlayRandomSong();
        }
    }

    private void PlayRandomSong()
    {
        if(Input.GetKey(KeyCode.Tab) && rand == 0)
        {
            audioSource.Stop();
            rand = Random.Range(0, AudioClipArr.Length);
            audioSource.PlayOneShot(AudioClipArr[rand]);
        }
        else if(Input.GetKey(KeyCode.Tab) && rand == 1)
        {
            audioSource.Stop();
            rand = Random.Range(0, AudioClipArr.Length);
            audioSource.PlayOneShot(AudioClipArr[rand]);
        }
        else if(Input.GetKey(KeyCode.Tab) && rand ==2)
        {
            audioSource.Stop();
            rand = Random.Range(0, AudioClipArr.Length);
            audioSource.PlayOneShot(AudioClipArr[rand]);
        }
    }
}
