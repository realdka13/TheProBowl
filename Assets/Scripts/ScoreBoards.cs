using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoards : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void FillScoreBoard(int player, int roll, int score)
    {
        print(player  + " " + roll + " " + score);
    }
}
