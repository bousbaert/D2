using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniGameManager : MonoBehaviour {

    private static MiniGameManager _instance;
    public static MiniGameManager Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<MiniGameManager>();
            }
            return _instance;
        }
    }

    [SerializeField]
    private GameObject poop;

    private int score;

    [SerializeField]
    private Text scoreTxt;
    [SerializeField]
    private Transform objbox;

    [SerializeField]
    private Text bestScore;
    [SerializeField]
    private GameObject panel;

    private Rigidbody2D pooprb;
   
    
    
	// Use this for initialization
	void Start () {
        Screen.SetResolution(768, 1024, false);
        pooprb = poop.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool stopTrigger = true;
    public void GameOver()
    {
        stopTrigger = false;

        StopCoroutine(CreatepoopRoutine());
     
        if(score >= PlayerPrefs.GetInt("BestScore", 0))
        PlayerPrefs.SetInt("BestScore",score);

        bestScore.text = PlayerPrefs.GetInt("BestScore",0).ToString();
                
        panel.SetActive(true);
    }

    public void GameStart()
    {
        score = 0;
        scoreTxt.text = "Score : " + score;
        stopTrigger = true;
        StartCoroutine(CreatepoopRoutine());
        panel.SetActive(false);
        pooprb.gravityScale = 1;
    }

    public void Score()
    {
        if(stopTrigger)
        score++;
        scoreTxt.text = "Score : " + score;
       if (score == 50)
        {
            pooprb.gravityScale = 2;
        }
        else if (score == 100)
        {
            pooprb.gravityScale = 3;
        }
        else if (score == 150)
        {
            pooprb.gravityScale = 4;
        }
        else if (score == 200)
        {
            pooprb.gravityScale = 5;
        }
    }

    IEnumerator CreatepoopRoutine()
    {
        while (stopTrigger)
        {
            CreatePoop();
            yield return new WaitForSeconds(0.3f);
        }        
    }

    private void CreatePoop()
    {
        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(UnityEngine.Random.Range(0.0f, 1.0f), 1.1f, 5.0f));
        //pos.z = 0.0f;
        GameObject obj = Instantiate(poop,pos,Quaternion.identity);
        obj.transform.parent = objbox.transform;
    }
}
