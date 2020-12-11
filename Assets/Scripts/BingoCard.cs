using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BingoCard : MonoBehaviour
{
    [SerializeField]BingoCard cardPref;
    [SerializeField]Vector2Int NumberNumVec;
    Number[,] Numbers;

    void Awake()
    {
        InitNumbers();
    }   

     void Initialize(){

    }
    void InitNumbers(){
        Numbers = new Number[NumberNumVec.x,NumberNumVec.y];
        
    }




}
