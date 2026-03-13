//기본 플레이어 정보.
using System.Collections.Generic;
using UnityEngine;

public static class PlayerInfo
{
    public static string sex = "";
    public static string lastName = "김";
    public static string firstName = "감자";
    public static string job = "";

    //스탯부분
    public static int money = 0;
    public static int strength = 10;
    public static int sociability = 20;
    public static int intelligence = 10;
    public static int refinement = 10;
    public static int appearance = 5;

    /* 구버전으로 쓰인 부분
    public static int moveCount = 0;
    public static Dictionary<string, bool> visitedButtons = new();
    */
    public static int day = 1;

    //애정도
    public static Dictionary<string, int> affection = new()
        { {"ws",0 }, {"my",0 }, {"smr",0 }, {"ys",0 }, {"dan", 0 }, {"ch", 0 } };

    //친밀도
    public static Dictionary<string, int> intimacy = new()
        { {"ws",0 }, {"my",0 }, {"smr",0 }, {"ys",0 }, {"dan", 0 }, {"ch", 0 } };

    public static void AddAffection(string character, int value)
    {
        if (affection.ContainsKey(character))
            affection[character] += value;
    }
    public static void AddIntimacy(string character, int value)
    {
        if (intimacy.ContainsKey(character))
            intimacy[character] += value;
    }
    public static void AddMoney (int amount)
    {
        money += amount;
    }

    public static int GetAffection(string character)
    {
        return affection.ContainsKey(character) ? affection[character] : 0;
    }
    public static int GetIntimacy(string character)
    {
        return intimacy.ContainsKey(character) ? intimacy[character] : 0;
    }
    public static int GetMoney()
    {
        return money;
    }


  /*
    public static bool IsButtonVisited(string buttonID)
    {
        return visitedButtons.TryGetValue(buttonID, out bool isVisited) && isVisited;
    }

    public static void VisitButton(string buttonID)
    {
        visitedButtons[buttonID] = true;
        moveCount++;
        Debug.Log($"[PlayerInfo] Visited {buttonID}, moveCount = {moveCount}");
    }
    */

    //플레이어 초기화. 새게임 시작할 때 호출
    public static void ResetPlayerInfo()
    {
        sex = "";
        lastName = "";
        firstName = "";
        job = "";

        money = 0;
        strength = 10;
        sociability = 20;
        intelligence = 10;
        refinement = 10;
        appearance = 5;

        //moveCount = 0;
        day = 1;
        //visitedButtons.Clear();

        foreach (var key in new List<string>(affection.Keys))
        {
            affection[key] = 0;
        }

        foreach (var key in new List<string>(intimacy.Keys))
        {
            intimacy[key] = 0;
        }
    }
}
