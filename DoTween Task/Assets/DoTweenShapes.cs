using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class DoTweenShapes : MonoBehaviour
{
    [SerializeField] private Transform _innerShape, _outerShape;
    [SerializeField] private float _cycleLength = 5;
    [SerializeField] private MeshRenderer _Change;



    // Start is called before the first frame update
    void Start()
    {
        transform.DOMove(new Vector3(10, 0, 0), _cycleLength).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);

        _innerShape.DORotate(new Vector3(0, 360, 0), _cycleLength * 0.5f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);

        _outerShape.DOScale(0.5f, 20f);
            
            //(new Vector3(0, 0, 360), _cycleLength * 0.5f, RotateMode.FastBeyond360).SetEase(Ease.OutCirc).SetLoops(-1, LoopType.Yoyo);


        _Change.material.DOColor(Random.ColorHSV(), 0.5f).SetLoops(-1,LoopType.Restart);


    }



}

//public void Change()
//{
//    _Change.material.DOColor(Random.ColorHSV(), 0.2f);
//}

// Update is called once per frame
//    void Update()
//    {

//    }
//}
