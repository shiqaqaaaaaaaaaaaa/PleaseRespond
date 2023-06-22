using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildMenu : MonoBehaviour
{
    [SerializeField] GameObject buildMenu;//获取键造菜单
    [SerializeField] GameObject buildInterface;//获取键造界面
    [SerializeField] GameObject mainUI;//获取主要UI
    [SerializeField] GameObject DestroyInferface;//获取拆除界面
    /// <summary>
    /// 进入键造模式
    /// </summary>
    public void Build()
    {
        buildInterface.SetActive(true);
        buildMenu.SetActive(false);
        mainUI.SetActive(false);
        DestroyInferface.SetActive(false);
    }
    /// <summary>
    /// 退出菜单
    /// </summary>
    public void Esc()
    {
        buildMenu.SetActive(false);
    }
    /// <summary>
    /// 拆除模式
    /// </summary>
    public void Destroy()
    {
        DestroyInferface.SetActive(true);
        mainUI.SetActive(false);
        buildMenu.SetActive(false);
        buildInterface.SetActive(false);
    }
    /// <summary>
    /// 进入升级模式
    /// </summary>
    public void LevelUp()
    {

    }
}
