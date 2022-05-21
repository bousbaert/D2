using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GM : MonoBehaviour
{
    public TalkManager talkManager;
    public QuestManager questManager;
    public Text talkText;
    public Text questText;
    public GameObject scanObject;
    public GameObject talkPanel;
    public GameObject menuSet;
    public GameObject player;
    public bool isAciton;
    public int talkIndex;


    void Start()
    {
        GameLoad();
        questText.text = questManager.CheckQuest();
    }

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if(menuSet.activeSelf)
                menuSet.SetActive(false);
            else
                menuSet.SetActive(true);
        }
        
    }
    public void Action(GameObject scanObj)
    {
        scanObject = scanObj;
        ObjData objData = scanObject.GetComponent<ObjData>();
        Talk(objData.id, objData.isNpc);

        talkPanel.SetActive(isAciton);

    }
    void Talk(int id, bool isNpc)
    {

        int questTalkIndex = questManager.GetQuestTalkIndex(id);
        string talkData = talkManager.GetTalk(id + questTalkIndex, talkIndex);

        if (talkData == null)
        {
            isAciton = false;
            talkIndex = 0;
            Debug.Log(questManager.CheckQuest(id));
            return;
        }
        if (isNpc)
        {
            talkText.text = talkData;
        }
        else
        {
            talkText.text = talkData;
        }
        isAciton = true;
        talkIndex++;
    }
    public void GameSave()
    {
        PlayerPrefs.SetFloat("PlayerX", player.transform.position.x);
        PlayerPrefs.SetFloat("PlayerY", player.transform.position.y);
        PlayerPrefs.SetInt("QustId",questManager.questId);
        PlayerPrefs.SetInt("QustActionIndex",questManager.questActionIndex);

        menuSet.SetActive(false);

    }

    public void GameLoad()
    {
        if (!PlayerPrefs.HasKey("PlayerX"))
            return;

        float x = PlayerPrefs.GetFloat("PlayerX");
        float y = PlayerPrefs.GetFloat("PlayerY");
        int questId = PlayerPrefs.GetInt("QustId");
        int questActionIndex = PlayerPrefs.GetInt("QustActionIndex");

        player.transform.position = new Vector3(x, y, 0);
        questManager.questId = questId;
        questManager.questActionIndex = questActionIndex;
        questManager.ControlObject();
    }
    public void GameExit()
    {
        Application.Quit();
    }
}
