using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class PlayerInfo
{
    public string name;
    public int level;
    public float health;
    public Vector3 position;
}
public class PlayerInfoController : MonoBehaviour
{
    [SerializeField] TMP_InputField nameInput;
    [SerializeField] TMP_InputField levelInput;
    [SerializeField] TMP_InputField healthInput;
    [SerializeField] TMP_InputField posXInput;
    [SerializeField] TMP_InputField posYInput;
    [SerializeField] TMP_InputField posZInput;
    [SerializeField] string playerName;

    public void Load()
    {
        var info = Settings.LoadPlayerInfo(playerName);
        nameInput.text = info.name;
        levelInput.text = info.level.ToString();
        healthInput.text = info.health.ToString();
        posXInput.text = info.position.x.ToString();
        posYInput.text = info.position.y.ToString();
        posZInput.text = info.position.z.ToString();
    }

    public void Save()
    {
        Settings.SavePlayerInfo(playerName, GetInfo());
    }

    PlayerInfo GetInfo()
    {
        PlayerInfo info = new PlayerInfo();
        info.name = nameInput.text;
        info.level = Convert.ToInt32(levelInput.text);
        info.health = Convert.ToSingle(healthInput.text);
        info.position = new Vector3( 
            Convert.ToSingle(posXInput.text),
            Convert.ToSingle(posYInput.text),
            Convert.ToSingle(posZInput.text));
        return info;
    }
}
