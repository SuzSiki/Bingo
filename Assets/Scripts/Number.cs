using UnityEngine.UI;
using UnityEngine;

public class Number : MonoBehaviour
{
    Text text;
    public Vector2 positionLocal{get;private set;} 
    RectTransform rectTransform;

    void Awake()
    {
        text = GetComponentInChildren<Text>();
    }

    public int num{
        get;private set;
    }

    public bool IsOpen = false;

    void Initialize(int Num,Color col,Vector2 Position){
        num = Num;
        text.text = num.ToString();
        text.color = col;
        positionLocal = Position;
        rectTransform.anchoredPosition = positionLocal;
    }

    public bool CheckNum(int Num){
        IsOpen = num == Num;
        return IsOpen;
    }
}
