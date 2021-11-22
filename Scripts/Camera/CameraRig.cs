using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CameraRig : MonoBehaviour
{

    public Transform y_axis;
    public Transform x_axis;
    public float moveTime;

    public void AlignTo (Transform target){
        Sequence seq = DOTween.Sequence ();
        seq.Append(y_axis.DOMove(target.position, 0.75f));
        seq.Join (y_axis.DORotate (new Vector3(0f, target.localRotation.eulerAngles.y, 0f), 0.75f));
        seq.Join (x_axis.DOLocalRotate (new Vector3(target.localRotation.eulerAngles.x, 0f, 0f), 0.75f));
    }
}
