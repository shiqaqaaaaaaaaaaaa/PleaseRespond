using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BuildCard : MonoBehaviour
{
    [SerializeField] private GameObject objectPrefab;
    private GameObject curObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnBeginDrug(BaseEventData data)
    {
        PointerEventData pointerEventData = data as PointerEventData;
        curObject = Instantiate(objectPrefab);
        curObject.transform.position = TranlateScreenToworld(pointerEventData.position);
    }
    public void OnDrug(BaseEventData data)
    {
        if (curObject == null)
        {
            return;
        }
        PointerEventData pointerEventData = data as PointerEventData;
        curObject.transform.position = TranlateScreenToworld(pointerEventData.position);
    }
    public void OnEndDrug(BaseEventData data)
    {
        if (curObject == null)
        {
            return;
        }
        PointerEventData pointerEventData = data as PointerEventData;
        Collider2D[] col = Physics2D.OverlapPointAll(TranlateScreenToworld(pointerEventData.position));
        foreach (Collider2D c in col)
        {
            if (c.tag == "BuildingPlace" && c.transform.childCount == 0)
            {
                curObject.transform.parent = c.transform;
                curObject.transform.localPosition = Vector3.zero;

                curObject = null;
                break;
            }
        }
        if (curObject != null)
        {
            GameObject.Destroy(curObject);
            curObject = null;
        }
    }
    public static Vector3 TranlateScreenToworld(Vector3 position)
    {
        Vector3 cameraTranslatePos = Camera.main.ScreenToWorldPoint(position);
        return new Vector3(cameraTranslatePos.x, cameraTranslatePos.y, 0);
    }
}
