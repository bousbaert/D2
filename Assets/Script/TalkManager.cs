using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;

    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();

    }

    void GenerateData()
    {
        talkData.Add(1000, new string[] { "�ȳ�", "�� ������" });
        talkData.Add(2000, new string[] { "�ȳ�.", "�� �ʹ�����" });
        talkData.Add(3000, new string[] { "�������� ������ å���̴�." });
        talkData.Add(4000, new string[] { "����� �������ڴ�." });

        //Quest Talk
        talkData.Add(10 + 1000, new string[] { "� ��", "�밡��� ó������?", "���������� ���� �ִ� �ʹ������� �ȳ����ٰž�" });
        talkData.Add(11 + 2000, new string[] { "�ݰ���", "�б� �ȳ��� �ް�ʹٰ�?", "�׷� �ͻ���� ã����" });

        talkData.Add(20 + 1000, new string[] { "�ͻ��?", "�װԹ���?" });
        talkData.Add(20 + 2000, new string[] { "���� ��ã�Ҿ�?", "�ͻ��� �ڽ��ȿ� �־� �� ã�ƺ�","�� �� ã����" });
        talkData.Add(20 + 5000, new string[] { "�ͻ�� ã�Ҵ�." });
        talkData.Add(21 + 2000, new string[] { "ã���༭ ����" });

    }
    public string GetTalk(int id, int talkIndex)
    {
        if (!talkData.ContainsKey(id))
        {
            if (!talkData.ContainsKey(id - id % 10))
                return GetTalk(id - id % 100, talkIndex);
            else
                return GetTalk(id - id % 10, talkIndex);
        }
        if (talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex];
    }
}
