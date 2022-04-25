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
        talkData.Add(1000, new string[] { "안녕", "난 곰젤리" });
        talkData.Add(2000, new string[] { "안녕.", "난 초밥젤리" });
        talkData.Add(3000, new string[] { "책상이다." });
        talkData.Add(4000, new string[] { "나무상자다." });

        //Quest Talk
        talkData.Add(10 + 1000, new string[] { "어서 와", "대가대는 처음이지?", "올라가면 있는 초밥젤리가 안내해줄거야" });
        talkData.Add(11 + 2000, new string[] { "반갑다", "학교 안내를 받고싶다고?", "그럼 와사비좀 찾아줘" });

        talkData.Add(20 + 1000, new string[] { "와사비?", "그게뭐지?" });
        talkData.Add(20 + 2000, new string[] { "아직 못찾았어?", "와사비는 박스안에 있어 잘 찾아봐","꼭 좀 찾아줘" });
        talkData.Add(20 + 5000, new string[] { "와사비를 찾았다." });
        talkData.Add(21 + 2000, new string[] { "찾아줘서 고마워" });

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
