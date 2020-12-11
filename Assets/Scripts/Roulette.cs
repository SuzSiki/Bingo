using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roulette : MonoBehaviour
{
    public static Roulette instance = null;
    List<int> drawedCards;

    ExitGames.Client.Photon.Hashtable roomHash;

    void Singleton(){
        if(instance == null){
            instance = this;
        }
        else if(instance != this){
            Destroy(this.gameObject);
        }
    }

    void Awake(){
        roomHash.Add("NextNum",0);
        roomHash.Add("Drawed",new List<int>());
    }

        

    public void UpdateList(int number){
        List<int> drawedNumbers = roomHash["Drawed"] as List<int>;
        drawedNumbers.Add(number);
        roomHash["NextNum"] = number;
    }
}
