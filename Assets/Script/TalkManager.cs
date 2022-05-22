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
        talkData.Add(5000, new string[] { "�ȳ�", "�� ������" });
        talkData.Add(6000, new string[] { "�ȳ�.", "�� �ʹ�����" });

        //Quest Talk
        talkData.Add(10 + 1000, new string[] { "ȯ����! ����� �Ͼ翡 ��ġ�� �뱸���縯���б������.","����� ���縯�б��̴ϸ�ŭ �б� �ȿ� ������ �־�.", "�׷��ǹ̿��� �츮 �б� �߽ɿ� �ִ� ������� ���� ���� ��������!" });
        talkData.Add(11 + 2000, new string[] { "�뱸���縯���б��� ���縯���� ���б��߿��� �л����� ���帹�� �Ը� ���� ū �б���", "(�л����� �ǳ��ָ�)","�� �л����� ������ ������ ���ư����� ��" });

        talkData.Add(20 + 1000, new string[] { "���ึ���ƴ��� �� �˰�Ծ�?","�� ���� �Ұ��� ���� B1��â�����̾�","����� â�������õ� �������� ����̳� �ɸ��˻� �� �� �Ҽ��־�.", "�켱 �ʴ� ���Ի��̴� B7���翡 �ִ� ����ǥ�� ������ ������ ��." });
        talkData.Add(21 + 3000, new string[] { "����� ���� ���� ���ð� ����Ǵ� ���̾�.","�б������� �� �� �˰������ B6����ڹ��� �տ��ִ� ������ ���� ���������� ��." });

        talkData.Add(30 + 4000, new string[] { "�� �̷��� �ʰԿͽ�? ��ٸ��ٰ� 2�б� �����ϰڴ� ", "����� �б��� ��������縦 �� ���ִ� �ڹ����̾�", "�б��� ���� �� �ñ��ϴٸ� C3ü���� �տ��ִ� ���� �������� ��" });
        talkData.Add(31 + 5000, new string[] { "����� ü�����̾�.","�ȿ��� Ʈ���̴׽ǰ� �����,ü������ �־� ���⼭ ü�� ���Ƹ� Ȱ�� ���� �� �� �־�.","���� ���̴� ��忡�� �б��� ü����ȸ�� �����ϰų� �����Ҽ��־�.","�츮 �б��� õ����买 �� 512ȣ�� ������ ��Ʈ�θ������Ʈ�� �˾�??","�𸥴ٸ� C���ǹ��� ������ ��Ʈ�θ������Ʈ�� ã�ƺ����� ��" });

        talkData.Add(40 + 6000, new string[] { "������ �ݰ��� �б��� �� �ѷ��ô�?","���� ����ü�� ���ؼ� ��������� Ư���� ������ ���� ����ȭ���� ��Ʈ�θ������Ʈ�����","�츮�б��� �� ������ �� ���̶�� �Ҽ�����","�ٸ� �� ������ �� ���� ü���ε带 �����ϴ°� �?","���� ���� ������ ���� �̻ڰ� �ɴٱ�." });
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
