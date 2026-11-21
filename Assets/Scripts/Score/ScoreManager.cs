using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] List<GameItem> itemNames;
    [SerializeField] List<int> itemValues;

    int score;
    Dictionary<GameItem, int> itemValuesDictionary;

    void Awake()
    {
        itemValuesDictionary = new Dictionary<GameItem, int>();

        for (int i = 0; i < itemNames.Count - 1; i++)
        {
            GameItem itemName = itemNames[i];
            int itemValue = itemValues[i];
            itemValuesDictionary.Add(itemName, itemValue);
        }
    }

    void OnEnable()
    {
        GameEvents.OnTargetDestroyed += AddScore;
    }

    void OnDisable()
    {
        GameEvents.OnTargetDestroyed -= AddScore;
    }

    void AddScore(GameItem gameItem)
    {
        int value = itemValuesDictionary[gameItem];
        score += value;
        Debug.Log($"Puntaje: {score}");
    }
}
