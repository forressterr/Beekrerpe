using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxSguffle : MonoBehaviour
{
    [SerializeField] public AudioClip[] audioClips;
    [SerializeField] public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayPop()
    {
        int num = Random.RandomRange(0, 5);
        source.clip = audioClips[num];
        source.Play();
    }
}
