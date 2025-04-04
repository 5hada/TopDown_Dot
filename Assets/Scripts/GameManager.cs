using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TalkManager talkManager;
    public GameObject talkPanel;
    public Image profileImg;
    public TextMeshProUGUI talkText;
    public GameObject scanObject;
    public bool isAction;
    public int talkIndex;
    public void Action(GameObject scanObj)
    {
        scanObject = scanObj;
        ObjData objData = scanObject.GetComponent<ObjData>();
        Talk(objData.id, objData.isNpc);
        
        talkPanel.SetActive(isAction);

    }
    void Talk(int id, bool isNpc)
    {
        string talkData = talkManager.GetTalk(id,talkIndex);

        if(talkData == null)
        {
            talkIndex = 0;
            isAction = false;
            return;
        }
        if (isNpc)
        {
            talkText.text = talkData.Split(':')[0];

            profileImg.sprite = talkManager.GetProfile(id, int.Parse(talkData.Split(':')[1]));
            profileImg.color = new Color(1, 1, 1, 1);
        }
        else
        {
            talkText.text = talkData;
            profileImg.color = new Color(1, 1, 1, 0);
        }
        isAction = true;
        talkIndex++;
    }
}
