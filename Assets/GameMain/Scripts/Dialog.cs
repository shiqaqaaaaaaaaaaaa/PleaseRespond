using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dialog : MonoBehaviour
{
    [Header("UI")]
    public Text TextLabel;
    public Image FaceImage;
    public Image BG;
    //public Image FaceImage02;
    public GameObject F01;
    // public GameObject F02;
    public Character C01;
    public Character C02;
    public Character C03;
    public Character C04;

    [Header("文本")]
    public TextAsset TextFile;
    public int Index;
    public float TextSpeed;

    [Header("头像1")]
    public Sprite Face11, Face12, Face13, Face14, Face15, Face16, Face17, Face18;

    [Header("头像2")]
    public Sprite Face21, Face22, Face23, Face24, Face25, Face26, Face27, Face28;

    [Header("头像3")]
    public Sprite Face31, Face32, Face33, Face34, Face35, Face36, Face37, Face38;

    [Header("头像4")]
    public Sprite Face41, Face42, Face43, Face44, Face45, Face46, Face47, Face48;

    [Header("背景")]
    public Sprite BG1, BG2, BG3, BG4; 

    bool TextFinish;
    bool CancelType;
    public int life;
    public int infection;

    List<string> TextList = new List<string>();
    void Awake()
    {
        GetTextFromFile(TextFile);
        
    }

    private void OnEnable()
    {
        //TextLabel.text = TextList[Index];
        //Index++;
        TextFinish = true;
        StartCoroutine(SetTextUI());
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && Index==TextList.Count)
        {
            gameObject.SetActive(false);
            Index = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
            return;
        }
       /* if (Input.GetMouseButtonDown(0)&&TextFinish)
        {
            // TextLabel.text = TextList[Index];
            // Index++;
            StartCoroutine(SetTextUI());
        }*/
       if(Input.GetMouseButtonDown(0))
        {
            if(TextFinish&&!CancelType)
            {
                StartCoroutine(SetTextUI());
            }
            else if(!TextFinish)
            {
                CancelType = !CancelType;
            }
        }
    }

    void GetTextFromFile(TextAsset File)
    {
        TextList.Clear();
        Index = 0;
        var LineData= File.text.Split('\n');
        foreach (var line in LineData)
        {
            TextList.Add(line);
        }
    }

    IEnumerator SetTextUI()
    {
        TextFinish = false;
        TextLabel.text = "";
        switch (TextList[Index].Trim().ToString())
        {
            case "旁白":
                F01.SetActive(false);
               // F02.SetActive(false);
                Index++;                   
                break;
            case "11":
                F01.SetActive(true);
                FaceImage.sprite = Face11;
                Index++;
                break;
            case "12":
                F01.SetActive(true);
                FaceImage.sprite = Face12;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "13":
                F01.SetActive(true);
                FaceImage.sprite = Face13;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "14":
                F01.SetActive(true);
                FaceImage.sprite = Face14;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "15":
                F01.SetActive(true);
                FaceImage.sprite = Face15;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "16":
                F01.SetActive(true);
                FaceImage.sprite = Face16;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "17":
                F01.SetActive(true);
                FaceImage.sprite = Face17;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "18":
                F01.SetActive(true);
                FaceImage.sprite = Face18;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "21":
                F01.SetActive(true);
                FaceImage.sprite = Face21;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "22":
                F01.SetActive(true);
                FaceImage.sprite = Face22;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "23":
                F01.SetActive(true);
                FaceImage.sprite = Face23;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "24":
                F01.SetActive(true);
                FaceImage.sprite = Face24;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "25":
                F01.SetActive(true);
                FaceImage.sprite = Face25;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "26":
                F01.SetActive(true);
                FaceImage.sprite = Face26;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "27":
                F01.SetActive(true);
                FaceImage.sprite = Face27;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "28":
                F01.SetActive(true);
                FaceImage.sprite = Face28;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "31":
                F01.SetActive(true);
                FaceImage.sprite = Face31;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "32":
                F01.SetActive(true);
                FaceImage.sprite = Face32;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "33":
                F01.SetActive(true);
                FaceImage.sprite = Face33;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "34":
                F01.SetActive(true);
                FaceImage.sprite = Face34;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "35":
                F01.SetActive(true);
                FaceImage.sprite = Face35;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "36":
                F01.SetActive(true);
                FaceImage.sprite = Face36;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "37":
                F01.SetActive(true);
                FaceImage.sprite = Face37;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "38":
                F01.SetActive(true);
                FaceImage.sprite = Face38;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "41":
                F01.SetActive(true);
                FaceImage.sprite = Face41;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "42":
                F01.SetActive(true);
                FaceImage.sprite = Face42;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "43":
                F01.SetActive(true);
                FaceImage.sprite = Face43;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "44":
                F01.SetActive(true);
                FaceImage.sprite = Face44;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "45":
                F01.SetActive(true);
                FaceImage.sprite = Face45;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "46":
                F01.SetActive(true);
                FaceImage.sprite = Face46;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "47":
                F01.SetActive(true);
                FaceImage.sprite = Face47;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "48":
                F01.SetActive(true);
                FaceImage.sprite = Face48;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "01":
                F01.SetActive(true);
                FaceImage.sprite = Face48;
                //FaceImage02.sprite = Face02;
                Index++;
                break;
            case "BG1":
                BG.sprite = BG1;
                Index++;
                break;
            case "BG2":
                BG.sprite = BG1;
                Index++;
                break;
            case "BG3":
                BG.sprite = BG1;
                Index++;
                break;
            case "BG4":
                BG.sprite = BG1;
                Index++;
                break;
            case "f01":
               C01.life= C01.life - life;
               C02.life = C02.life - life;
               C01.Infection = C01.Infection + infection;
               C02.Infection = C02.Infection + infection;
               break;
            case "f02":
                C01.life = C01.life - life;
                C02.life = C02.life - life;
                C03.life = C03.life - life;
                C01.Infection = C01.Infection + infection;
                C02.Infection = C02.Infection + infection;
                C03.Infection = C03.Infection + infection;
                break;
            case "f03":
                C01.life = C01.life - life;
                C02.life = C02.life - life;
                C03.life = C03.life - life;
                C04.life = C04.life - life*2;
                C01.Infection = C01.Infection + infection;
                C02.Infection = C02.Infection + infection;
                C03.Infection = C03.Infection + infection;
                C04.Infection = C04.Infection + infection*2;
                break;

        }

        /*for (int i=0;i<TextList[Index].Length;i++ )
        {
            TextLabel.text += TextList[Index][i];
            yield return new WaitForSeconds(TextSpeed);
           
        }*/
        int letter = 0;
        while(!CancelType&&letter<TextList[Index].Length-1)
        {
            TextLabel.text += TextList[Index][letter];
            letter++;
            yield return new WaitForSeconds(TextSpeed);
        }
        TextLabel.text = TextList[Index];
        CancelType = false;
        TextFinish = true;
        Index++;
    }
}
