using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int partNum=0;//零件数量
    public int coreNum=0;//能源核心
    public int foodNum=0;//食物资源
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangePartNum(int changeNum)
    {
        partNum += changeNum;
        if(partNum <=0)
        {
            partNum = 0;
        }
    }
    public void ChangeCoreNum(int changeNum)
    {
        coreNum += changeNum;
        if (coreNum <= 0)
        {
            coreNum = 0;
        }
    }
    public void ChangeFood(int changeNum)
    {
        foodNum += changeNum;
        if (foodNum <= 0)
        {
            foodNum = 0;
        }
    }
    public void ChangePower(int changeNum)
    {
        power += changeNum;
        if (power <= 0)
        {
            power = 0;
        }
    }
}
