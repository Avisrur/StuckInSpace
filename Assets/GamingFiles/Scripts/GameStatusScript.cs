using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatusScript : MonoBehaviour
{

    public static int score = 0;
    public static int lives = 3;
    public static float startTime = 180;
    public static bool timerFlag;
    public static bool CatchGameNotPlayed = true;
    public static bool breakoutGameNotPlayed = true;
    public static bool initiateCoins = true;
    public static Dictionary<string, bool> coinsToActivate = new Dictionary<string, bool>();
    public static Vector3 checkPoint = GameObject.Find("StartRespawn").GetComponent<Transform>().position;

    public static void InitializeStats()
    {
        GameStatusScript.score = 0;
        GameStatusScript.checkPoint = GameObject.Find("StartRespawn").GetComponent<Transform>().position;
        GameStatusScript.CatchGameNotPlayed = true;
        GameStatusScript.breakoutGameNotPlayed = true;
        GameStatusScript.initiateCoins = true;
        GameStatusScript.startTime = 180;
        GameStatusScript.lives = 3;
    }
}
