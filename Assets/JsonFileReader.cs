
using System.IO;
using UnityEngine;

public class JsonFileReader : MonoBehaviour
{
    void Start()
    {
        string filePath = Application.persistentDataPath + "/test.json";

        if (File.Exists(filePath))
        {
            // ファイルを読み込む
            string json = File.ReadAllText(filePath);

            // JSONデータをScoreDataオブジェクトにデシリアライズ
            ScoreData scoreData = JsonUtility.FromJson<ScoreData>(json);

            // 読み込んだデータを表示
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
