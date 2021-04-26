using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings
{
    public static void SavePlayerInfo(string key, PlayerInfo info)
    {
        PlayerPrefs.SetString(key, info.name);
        PlayerPrefs.SetInt(key, info.level);
        PlayerPrefs.SetFloat(key, info.health);
        PlayerPrefs.SetFloat(key+"X", info.position.x);
        PlayerPrefs.SetFloat(key+"Y", info.position.y);
        PlayerPrefs.SetFloat(key+"Z", info.position.z);
    }

    public static PlayerInfo LoadPlayerInfo(string key)
    {
        PlayerInfo info = new PlayerInfo();
        info.name = PlayerPrefs.GetString(key, "Player");
        info.level = PlayerPrefs.GetInt(key, 0);
        info.health = PlayerPrefs.GetFloat(key, 0.0f);
        info.position = new Vector3( 
            PlayerPrefs.GetFloat(key + "X", 0.0f),
            PlayerPrefs.GetFloat(key + "Y", 0.0f),
            PlayerPrefs.GetFloat(key + "Z", 0.0f));
        return info;
    }
}
