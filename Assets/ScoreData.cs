using System.IO;
using UnityEngine;

[System.Serializable]
public class ScoreData
{
    public int score;
    public string playerName;
    public string timestamp;

    public ScoreData(int score, string playerName)
    {
        this.score = score;
        this.playerName = playerName;
        this.timestamp = System.DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
    }
}

public class JsonFileCreator : MonoBehaviour
{
    void Start()
    {
        // �쐬����f�[�^
        ScoreData scoreData = new ScoreData(100, "Player1");

        // JSON�ɕϊ�
        string json = JsonUtility.ToJson(scoreData);

        // �ۑ�����t�@�C���̃p�X���w��
        string filePath = Application.persistentDataPath + "/test.json";

        // �t�@�C���ɏ�������
        File.WriteAllText(filePath, json);
        Debug.Log("JSON file saved at: " + filePath);
    }
}
