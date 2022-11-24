using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioGame : MonoBehaviour
{
    public AudioClip clipsatu;
    public AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = clipsatu;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
