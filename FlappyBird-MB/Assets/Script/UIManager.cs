using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

///<summary>
///
///</summary>
public class UIManager : MonoBehaviour
{
    private CanvasGroup canvasGroup;

    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void showUI()
    {
        canvasGroup.DOFade(1, 0.5f);
    }

    public void HideUI()
    {
        canvasGroup.DOFade(0, 0.5f).onComplete = () =>
        {
            gameObject.SetActive(false);
        };
    }

}
