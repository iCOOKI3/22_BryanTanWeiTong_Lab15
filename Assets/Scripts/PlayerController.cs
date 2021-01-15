using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject JumpText;
    public AudioClip[] AudioClipArr;

    private AudioSource audioSource;
    private float Gravitiy = 5.0f;
    private int JumpCounter;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        rb.AddForce(Vector3.down * Time.deltaTime * Gravitiy);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpCounter += 1;

            JumpText.GetComponent<Text>().text = "Jump: " + JumpCounter;

            rb.AddForce(new Vector3(0, 250, 0));

            //audioSource.Play()
            int rand = Random.Range(0,AudioClipArr.Length);
            audioSource.PlayOneShot(AudioClipArr[rand]);
        }
    }
}
