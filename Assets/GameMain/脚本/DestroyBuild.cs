using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DestroyBuild : MonoBehaviour
{
    [SerializeField]private GameObject DestroyInferface;
    [SerializeField] private GameObject MainUI;
    private void Update()
    {
        Destroy();
    }
    private void Destroy()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D[] col = Physics2D.OverlapPointAll(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            foreach (Collider2D c in col)
            {
                if (c.tag == "Build1")
                {
                    Destroy(c.gameObject);
                }
            }
        }
    }

    public void Exit()
    {
        DestroyInferface.SetActive(false);
        MainUI.SetActive(true);
    }

}
