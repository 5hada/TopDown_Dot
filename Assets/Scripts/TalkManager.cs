using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    Dictionary<int, Sprite> profileData;

    public Sprite[] profileArr;

    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        profileData = new Dictionary<int, Sprite>();
        GenerateData();
    }
    
    void GenerateData()
    {
        talkData.Add(1000, new string[] { "안녕?:0", "이 곳에 처음 왔구나?:1" });
        talkData.Add(2000, new string[] { "여어.:1", "이 호수는 정말 아름답지?:0", "사실 이 호수에는 무언가의 비밀이 숨겨져있다고 해.:1"});
        talkData.Add(100, new string[] { "평범한 나무상자다." });
        talkData.Add(200, new string[] { "평범한 나무상자다." });
        talkData.Add(300, new string[] { "평범한 나무상자다." });
        talkData.Add(400, new string[] { "누군가 사용했던 흔적이 있는 책상이다." });
        talkData.Add(500, new string[] { "돌." });

        talkData.Add(10 + 1000, new string[] { "dkssud?:0", "hjkl;:1", "lllllll.:0" });
        talkData.Add(11 + 2000, new string[] { ":1", " :0", ":1" });

        profileData.Add(1000 + 0, profileArr[0]);
        profileData.Add(1000 + 1, profileArr[1]);
        profileData.Add(1000 + 2, profileArr[2]);
        profileData.Add(1000 + 3, profileArr[3]);
        profileData.Add(2000 + 0, profileArr[4]);
        profileData.Add(2000 + 1, profileArr[5]);
        profileData.Add(2000 + 2, profileArr[6]);
        profileData.Add(2000 + 3, profileArr[7]);
    }

    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex];
    }

    public Sprite GetProfile(int id, int profileIndex)
        {
        return profileData[id + profileIndex];
    }
}
