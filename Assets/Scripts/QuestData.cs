using UnityEngine;

public class QuestData
{
    public string questName;
    public int[] npcID;

    public QuestData(string name, int[] npc)
    {
        questName = name;
        npcID = npc;
    }

}
