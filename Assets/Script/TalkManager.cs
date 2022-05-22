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
        talkData.Add(3000, new string[] { "누군가가 버리고간 책상이다." });
        talkData.Add(4000, new string[] { "평범한 나무상자다." });
        talkData.Add(5000, new string[] { "안녕", "난 곰젤리" });
        talkData.Add(6000, new string[] { "안녕.", "난 초밥젤리" });

        //Quest Talk
        talkData.Add(10 + 1000, new string[] { "환영해! 여기는 하양에 위치한 대구가톨릭대학교라고해.","여기는 가톨릭학교이니만큼 학교 안에 성당이 있어.", "그런의미에서 우리 학교 중심에 있는 성모상을 먼저 보고 오도록해!" });
        talkData.Add(11 + 2000, new string[] { "대구가톨릭대학교는 가톨릭산하 대학교중에서 학생수도 가장많고 규모도 가장 큰 학교야", "(학생증을 건네주며)","이 학생증을 가지고 디쿠에게 돌아가도록 해" });

        talkData.Add(20 + 1000, new string[] { "성녀마리아님은 잘 뵙고왔어?","그 다음 소개할 곳은 B1취창업관이야","여기는 창업에관련된 정보말고도 상담이나 심리검사 등 을 할수있어.", "우선 너는 신입생이니 B7강당에 있는 과대표를 만나고 오도록 해." });
        talkData.Add(21 + 3000, new string[] { "여기는 각종 행사와 전시가 진행되는 곳이야.","학교에대해 좀 더 알고싶으면 B6역사박물관 앞에있는 빨간색 디쿠를 만나보도록 해." });

        talkData.Add(30 + 4000, new string[] { "왜 이렇게 늦게와써? 기다리다가 2학기 시작하겠다 ", "여기는 학교의 전통과역사를 알 수있는 박물관이야", "학교에 대해 더 궁금하다면 C3체육관 앞에있는 노쿠를 만나도록 해" });
        talkData.Add(31 + 5000, new string[] { "여기는 체육관이야.","안에는 트레이닝실과 무용실,체조실이 있어 여기서 체육 동아리 활동 등을 할 수 있어.","옆에 보이는 운동장에서 학교의 체육대회를 참가하거나 구경할수있어.","우리 학교의 천연기념물 제 512호로 지정된 스트로마톨라이트를 알아??","모른다면 C사대건물들 사이의 스트로마톨라이트를 찾아보도록 해" });

        talkData.Add(40 + 6000, new string[] { "만나서 반가워 학교는 좀 둘러봤니?","나는 생물체에 의해서 만들어지는 특이한 형태의 생물 퇴적화석인 스트로마톨라이트라고해","우리학교의 핫 스팟중 한 곳이라고 할수있지","다른 핫 스팟중 한 곳인 체리로드를 구경하는건 어떄?","봄이 오면 벛꽃이 정말 이쁘게 핀다구." });
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
