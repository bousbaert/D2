using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GM : MonoBehaviour
{
    public Text talkText;
    public GameObject scanObject;
    public GameObject talkPanel;
    public bool isAciton;
   

    
    public void Action(GameObject scanObj)
    {
        if (isAciton)
        {
            isAciton = false;
        }
        else
        {
            isAciton = true;
            scanObject = scanObj;
            talkText.text = "이것의 이름은" + scanObject.name + "이라고 한다";
        }
        talkPanel.SetActive(isAciton);



    }
}
