using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingDOTween : MonoBehaviour
{
    [SerializeField] private GameObject _fence;

    private void Start()
    {
        _fence.transform.DORotate(new Vector3(0, -75, 0), 3).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }
}
