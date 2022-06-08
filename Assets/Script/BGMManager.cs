using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour { 


    static public BGMManager instance;

   

    public AudioClip[] clips;

    private AudioSource source;

    private WaitForSeconds waitTime = new WaitForSeconds(0.01f);
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        
    }

    public void Play(int _playMusicTrack)
    {
        source.volume = 0.1f;
        source.clip = clips[_playMusicTrack];
        source.Play();
    }

    public void SetVolumn(float _volumn)
    {
        source.volume = _volumn;
    }

    public void Pause()
    {
        source.Pause();
    }

    public void UnPause()
    {
        source.UnPause();
    }

    public void Stop()
    {
        source.Stop();
    }

    public void FadeOutMusic()
    {
        StopAllCoroutines();
        StartCoroutine(FadeOutMusicCoroutline());
    }


    IEnumerator FadeOutMusicCoroutline()
    {
        for(float i =1.0f; i>=0f; i-=0.01f)
        {
            source.volume = i;
            yield return waitTime;
        }
    }
    public void FadeinMusic()
    {
        StopAllCoroutines();
        StartCoroutine(FadeInMusicCoroutline());
    }
    IEnumerator FadeInMusicCoroutline()
    {
        for (float i = 0f; i <= 1f; i += 0.01f)
        {
            source.volume = i;
            yield return waitTime;
        }
    }

}

