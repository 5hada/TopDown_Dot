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
        talkData.Add(1000, new string[] { "�ȳ�?:0", "�� ���� ó�� �Ա���?:1" });
        talkData.Add(2000, new string[] { "����.:1", "�� ȣ���� ���� �Ƹ�����?:0", "��� �� ȣ������ ������ ����� �������ִٰ� ��.:1"});
        talkData.Add(100, new string[] { "����� �������ڴ�." });
        talkData.Add(200, new string[] { "����� �������ڴ�." });
        talkData.Add(300, new string[] { "����� �������ڴ�." });
        talkData.Add(400, new string[] { "������ ����ߴ� ������ �ִ� å���̴�." });
        talkData.Add(500, new string[] { "��." });

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
