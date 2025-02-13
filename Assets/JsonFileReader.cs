
using System.IO;
using UnityEngine;

public class JsonFileReader : MonoBehaviour
{
    void Start()
    {
        string filePath = Application.persistentDataPath + "/test.json";

        if (File.Exists(filePath))
        {
            // �t�@�C����ǂݍ���
            string json = File.ReadAllText(filePath);

            // JSON�f�[�^��ScoreData�I�u�W�F�N�g�Ƀf�V���A���C�Y
            ScoreData scoreData = JsonUtility.FromJson<ScoreData>(json);

            // �ǂݍ��񂾃f�[�^��\��
            Debug.Log("Score: " + scoreData.score);
            Debug.Log("Player: " + scoreData.playerName);
            Debug.Log("Timestamp: " + scoreData.timestamp);
        }
        else
        {
            Debug.Log("No file found at: " + filePath);
        }
    }
}
