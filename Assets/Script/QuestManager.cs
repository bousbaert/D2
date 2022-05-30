using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public int questId;
    public int questActionIndex;
    public GameObject[] questObject;
    Dictionary<int, QuestData> questList;
    void Awake()
    {
        questList = new Dictionary<int, QuestData>();
        GenerateData();
        
    }


    void GenerateData()
    {
        questList.Add(10, new QuestData("�����", new int[] { 1000, 2000}));
        questList.Add(20, new QuestData("����ǥ", new int[] { 1000, 3000,3000 }));
        questList.Add(30, new QuestData("ü����", new int[] { 4000,5000}));
        questList.Add(40, new QuestData("�Ȱ���û����", new int[] { 6000,7000,7000}));
        questList.Add(50, new QuestData("A2û����", new int[] { 8000, 9000}));
        questList.Add(60, new QuestData("A6û����", new int[] { 10000 ,11000}));
        questList.Add(70, new QuestData("A6û����", new int[] { 12000, 13000 }));
        questList.Add(80, new QuestData("A6û����", new int[] { 14000, 15000 }));
        questList.Add(90, new QuestData("A6û����", new int[] { 16000 }));
        questList.Add(100, new QuestData("����Ʈ ��", new int[] { 0 }));
    }

    public int GetQuestTalkIndex(int id)
    {
        return questId + questActionIndex;
    }
    public string CheckQuest(int id)
    {
        

        if (id == questList[questId].npcId[questActionIndex])
            questActionIndex++;

        ControlObject();


        if (questActionIndex == questList[questId].npcId.Length)
            NextQuest();

        return questList[questId].questName;

    }
    public string CheckQuest()
    {
        return questList[questId].questName;
    }
    void NextQuest()
    {
        questId += 10;
        questActionIndex = 0;
    }
    public void ControlObject()
    {
        switch (questId)
        {
            
            case 40:
                if (questActionIndex == 2)
                    questObject[0].SetActive(true);
                break;
            case 50:
                if (questActionIndex == 1)
                    questObject[1].SetActive(false);
                    questObject[2].SetActive(true);
                if(questActionIndex == 2)
                    questObject[2].SetActive(false);
                    questObject[3].SetActive(true);
                break;
            case 60:
                if (questActionIndex == 1)
                    questObject[3].SetActive(false);
                    questObject[4].SetActive(true);
                break;
            case 70:
                if (questActionIndex == 1)
                    questObject[5].SetActive(false);
                    questObject[6].SetActive(true);
                if (questActionIndex == 2)
                    questObject[6].SetActive(false);
                    questObject[7].SetActive(true);
                break;
            case 80:
                if (questActionIndex == 2)
                    questObject[8].SetActive(false);
                    questObject[9].SetActive(true);
                break;

        }
    }
}
