using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TypeEffect : MonoBehaviour
{
    public int CharPerSeconds;
    Text msgText;
    AudioSource audioSource;
    string targetMsg;
    int index;
    float interval;
   


    private void Awake()
    {
        msgText = GetComponent<Text>();
        audioSource = GetComponent<AudioSource>();
    }

    public void SetMsg(string msg)
    {
        targetMsg = msg;
        EffectStart();
    }

    void EffectStart()
    {
        msgText.text = "";
        index = 0;

        //speed
        interval = 1.0f / CharPerSeconds;
        Debug.Log(interval);
        Invoke("Effecting", interval);
    }

    void Effecting()
    {
        if (msgText.text == targetMsg) {
            EffectEnd();
            return;

        }
        msgText.text += targetMsg[index];
       
        //sound
        if(targetMsg[index]!=' ' || targetMsg[index]!='.')
            audioSource.Play();
        
        index++;

        Invoke("Effecting", interval);
    }

    void EffectEnd()
    {
        //end
    }

}
