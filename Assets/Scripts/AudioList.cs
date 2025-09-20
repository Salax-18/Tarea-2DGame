using UnityEngine;
using System.Collections.Generic;   

public class AudioList : MonoBehaviour
{
    public List<AudioClip> listClips = new List<AudioClip>();
    public AudioSource audioSource;


    [SerializeField] private bool loopPlayList = true;
    private int currentIndex = -1;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayNextClip() //Se usa para controlar por medio de un indice las posiciones de la lista
    {
        if (listClips==null || listClips.Count == 0 || audioSource == null)
            return;

            currentIndex++;
            if(currentIndex >= listClips.Count)
            {
                if (loopPlayList==true)
                {
                    currentIndex = 0;
                }
                else
                {
                    currentIndex = listClips.Count - 1;
                    return;
                }
            }
        
        audioSource.Stop();
        audioSource.clip = listClips[currentIndex];
        audioSource.Play();
    }
}
