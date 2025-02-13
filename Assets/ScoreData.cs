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
        // 作成するデータ
        ScoreData scoreData = new ScoreData(100, "Player1");

        // JSONに変換
        string json = JsonUtility.ToJson(scoreData);

        // 保存するファイルのパスを指定
        string filePath = Application.persistentDataPath + "/test.json";

        // ファイルに書き込み
        File.WriteAllText(filePath, json);
        Debug.Log("JSON file saved at: " + filePath);
    }
}
