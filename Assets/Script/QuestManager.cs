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
        questList.Add(10, new QuestData("�����", new int[] { 1000, 2000 ,2000}));
        questList.Add(20, new QuestData("����ǥ", new int[] { 1000, 3000 }));
        questList.Add(30, new QuestData("ü����", new int[] { 4000,5000 }));
        questList.Add(40, new QuestData("��Ʈ�θ������Ʈ", new int[] { 6000,7000 }));
        questList.Add(50, new QuestData("����Ʈ ��", new int[] { 0 }));
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
           
        }
    }
}
