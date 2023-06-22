using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Adventure : MonoBehaviour
{
    [SerializeField] private UI Day;
    [SerializeField] private Character c01;
    [SerializeField] private Character c02;
    [SerializeField] private Character c03;
    [SerializeField] private Character c04;
    [SerializeField] private GameObject Day01;
    [SerializeField] private GameObject Day02;
    [SerializeField] private GameObject Day03;
    [SerializeField] private GameObject Day04;
    [SerializeField] private GameObject Day05;
    [SerializeField] private GameObject Day06;
    [SerializeField] private GameObject Day07;
    public float f;
    public int R;
    // Start is called before the first frame update
    void Start()
    {
      if(Day.Day==1)
        {
            Day01.SetActive(true);
        }
      else if (Day.Day==2)
        {
            Day02.SetActive(true);
        }
      else if(Day.Day==6)
        {
            Day03.SetActive(true);
        }
      else if(Day.Day==11)
        {
            Day04.SetActive(true);
        }
      else if(Day.Day>2&&Day.Day<6)
        {
            f = Random.value * 10;
            if(f>=0&&f<3)
            {
                Day04.SetActive(true);
            }
            else if(f>=3&&f<6)
            {
                Day05.SetActive(true);
            }
            else if(f>=6&&f<9)
            {
                Day06.SetActive(true);
            }
            else if(f>=9&&f<=10)
            {
                Day07.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
   
    public void run()
    {
        Day.Reputation -= R;
    }
    public void battle01()
    {

    }
}
