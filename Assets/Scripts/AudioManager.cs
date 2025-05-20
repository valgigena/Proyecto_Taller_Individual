using System.Data.Common;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Sources")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;
    [SerializeField] AudioSource decClipSource;

    [Header("Audio Clips")]
    public AudioClip musicClip;
    public AudioClip jumpClip;
    public AudioClip deciClip;
    public AudioClip parcheClip;

    public static AudioManager instance;


  
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

        void Start()
        {
           // PlayMusic(inGameMusic);
        }

public void PlayDecClip()
    {
        if (decClipSource != null && deciClip != null)
        {
            decClipSource.clip = deciClip;
            decClipSource.loop = true; // Si quieres que el sonido se repita
            decClipSource.Play();
        }
    }

     public void StopDecClip()
    {
        if (decClipSource != null && decClipSource.isPlaying)
        {
            decClipSource.Stop();
        }
    }

    public void PlayMusic(AudioClip musicClip)
    {
        if (musicSource != null && musicClip != null)
        {
            musicSource.clip = musicClip;
            musicSource.loop = true;
            musicSource.Play();
        }
    }
    
        public void PlaySFX(AudioClip sfxClip)
    {
        if (sfxSource != null && sfxClip != null)
        {
            sfxSource.PlayOneShot(sfxClip);
        }
    }
    public void StopMusic()
    {
        if (musicSource != null)
        {
            musicSource.Stop();
        }
    }
}
