using UnityEngine;
using UnityEngine.UIElements;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Sources")]
    [SerializeField] AudioSource sfxSource; // reproductor efectos de sonido
    [SerializeField] AudioSource musicSource; // reproductor efectos de musica

    [Header("Audio Clips")] // Clips de audio
    public AudioClip background; 
    public AudioClip jumpClip; 
   
    public static AudioManager instance; // para acceder desde otros scrips


    #region noDestruir 
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
    #endregion


    //Aca llegan las llamadas de audios a reproducirse
    public void PlaySFX(AudioClip sfxClip)
    {
        if (sfxSource != null && sfxClip != null)
        {
            sfxSource.PlayOneShot(sfxClip);
        }
    }

    //este es para la musica constante y al inicio
    public void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }




}


