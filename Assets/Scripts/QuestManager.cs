using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public int questID;
    public int questActionIndex;
    Dictionary<int, QuestData> questList;

    void Awake()
    {
        questList = new Dictionary<int, QuestData>();
        GenerateData();
    }
    void GenerateData()
    {
        questList.Add(10, new QuestData("마을 사람들과 대화하기", new int[] { 1000, 2000 }));
        questList.Add(20, new QuestData("루도의 동전 찾아주기.", new int[] { 1000, 2000 }));
    }
     
    public int GetQuestTalkIndex(int id)
    {
        return questID + questActionIndex;
    }

    public string CheckQuest(int id)
    {
        if(id== questList[questID].npcID[questActionIndex])
           questActionIndex++;
        if(questActionIndex == questList[questID].npcID.Length)
            NextQuest();

        return questList[questID].questName;
    }
    void NextQuest()
    {
        questID += 10;
        questActionIndex = 0;
    }
}
