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
        talkData.Add(1000, new string[] { "학교는 좀 어때?" });
        talkData.Add(2000, new string[] { "(말이 없는 성모상....)" });
        talkData.Add(3000, new string[] { "바쁘다 바뻐~" });
        talkData.Add(4000, new string[] { "박물관은 잘 구경 했니?" });
        talkData.Add(5000, new string[] { "학교 생활은 좀 어때" });
        talkData.Add(6000, new string[] { "......" });
        talkData.Add(7000, new string[] { "봄이 그렇게도 좋냐~" });
        talkData.Add(8000, new string[] { "" });
        talkData.Add(9000, new string[] { "" });
        talkData.Add(10000, new string[] { "" });


        //Quest Talk
        talkData.Add(10 + 1000, new string[] { "환영해! 여기는 하양에 위치한 대구가톨릭대학교라고해.","여기는 가톨릭학교이니만큼 학교 안에 성당이 있어.", "그런의미에서 우리 학교 중심에 있는 성모상을 먼저 보고 오도록해!" });
        talkData.Add(11 + 1000, new string[] { "아직 못 만난거야?", "성모상은 이길로 쭉 올라가면 있어." });
        talkData.Add(11 + 2000, new string[] { "안녕? 니가 디쿠가 말한 신입생이구나","대구가톨릭대학교는 가톨릭산하 대학교중에서 학생수도 가장많고 규모도 가장 큰 학교야", "(학생증을 건네주며)","이 학생증을 가지고 디쿠에게 돌아가도록 해" });
        




        talkData.Add(20 + 1000, new string[] { "성녀마리아님은 잘 뵙고왔어?","그 다음 소개할 곳은 B1취창업관이야","여기는 창업에관련된 정보말고도 상담이나 심리검사 등 을 할수있어.", "우선 너는 신입생이니 B7강당에 있는 과대표를 만나고 오도록 해." });
        talkData.Add(21 + 1000, new string[] { "길을 못찾겠다고?","오른쪽 대각선 위로 쭉올라가봐" });
        talkData.Add(21 + 3000, new string[] { "반갑다 신입생!","여기는 각종 행사와 전시가 진행되는 곳이야.","학교에 대해 좀 더 알고싶으면 B6역사박물관 앞에있는 빨간색 디쿠를 만나보도록." });
        talkData.Add(22 + 3000, new string[] { "길을 못찾겠다고?","한번 혼자 찾아보는게 어때?","난 바쁜 몸이라"});


        talkData.Add(30 + 4000, new string[] { "왜 이렇게 늦게와써? 기다리다가 2학기 시작하겠다 ", "여기는 학교의 전통과역사를 알 수있는 박물관이야", "학교에 대해 더 궁금하다면 C3체육관 앞에있는 노쿠를 만나도록 해" });
        talkData.Add(31 + 4000, new string[] { "C건물은 도로의 오른쪽으로 쭉가다보면 나올꺼야", "한번 잘 찾아봐" });
        talkData.Add(31 + 5000, new string[] { "오느라 고생이 많았지?","여기는 체육관이야.","안에는 트레이닝실과 무용실,체조실이 있어 여기서 체육 동아리 활동 등을 할 수 있어.","옆에 보이는 운동장에서 학교의 체육대회를 참가하거나 구경할수있어.","우리 학교의 천연기념물 제 512호로 지정된 스트로마톨라이트를 알아??","모른다면 C사대건물들 사이의 스트로마톨라이트를 찾아보도록 해" });

        talkData.Add(40 + 6000, new string[] { "만나서 반가워 학교는 좀 둘러봤니?","나는 생물체에 의해서 만들어지는 특이한 형태의 생물 퇴적화석인 스트로마톨라이트라고해","우리학교의 핫 스팟중 한 곳이라고 할수있지","다른 핫 스팟중 한 곳인 체리로드를 구경하는건 어떄?","봄이 오면 벛꽃이 정말 이쁘게 핀다구." });
        talkData.Add(41 + 7000, new string[] { "여기는 벚꽃의 청결한 아름다움으로 새 학기를 시작하는 모든 구성원들에게 기쁨을 주는 체리로드야"," 봄철에 는벚꽃이 만개하니 사진찍기도 좋은곳이지 너도 봄날의 체리로드를 느껴보도록 해" });
        talkData.Add(42 + 7000, new string[] { "봄날의 체리로드를 잘 느끼고 왔어?","이제 학교에 흥미가 생겼니?","아직 더 소개해주고 싶은 장소가 남아있어.","나는 자유롭게 돌아다닐 수 없지만 청설모는 우리 학교를 자유롭게 돌아다닐수 있지.","우리 학교에 대해 잘 알고있는 청설모를 팔각정에서 찾아보도록해." });

        talkData.Add(50 + 8000, new string[] { "내가 여기있는건 어떻게 알았어?","학교에 대해서 알고싶다고?","그렇다면 날 찾아와봐~" });
        talkData.Add(51 + 9000, new string[] { "여기는 신입생들이 가장 많이 수업을 듣는 교양관이야","교양관 1층에는 졸업필수요건인 봉사활동을 관리하시는 사회나눔봉사활동인 줄여서 사나봉이라 불리는 사무실이 있는곳이야.","또 교양관에서는 졸업필수요건중 하나인 실용영와 독서와토론 수업을 듣기도 해.","다음으로는 저스티스로드를 따라 A6제1학생회관으로 오도록 해" });

        talkData.Add(60 + 10000, new string[] { "여기는 학생회관이기도 하지만 1층에 편의시설인 편의점과 복사실이 있고 수업을 듣는데 필요한 교재를 파는 서점이 있어. 그리고 A6맞은편에는 새학기를 시작하면 동아리모집을 위한 홍보를 하는 곳이야 뭐라고? 쉬고싶다고? 그렇다면 쉬게해줄테니 나를 따라와" });

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
