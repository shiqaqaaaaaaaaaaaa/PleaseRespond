using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Radio : MonoBehaviour
{
    [SerializeField] private GameObject buildMenu;//获取键造菜单
    /// <summary>
    /// 鼠标单击调用键造菜单
    /// </summary>
    private void OnMouseDown()
    {
        buildMenu.SetActive(true);
    }
}

