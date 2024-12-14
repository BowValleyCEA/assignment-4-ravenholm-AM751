using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static UnityEngine.GraphicsBuffer;

public class CameraHitScan : MonoBehaviour
{
    [SerializeField] private Transform targetOrigin;
    [SerializeField] private float targetDistance;
    [SerializeField] private LayerMask hitLayer;
    private int collectScore;
    [SerializeField] private TextMeshProUGUI scoreUI;
    private ITargetable _target = null;


    // Update is called once per frame
    void Update()
    {
        Vector3 origin = targetOrigin.position;
        RaycastHit hit;
        Debug.DrawLine(origin, targetOrigin.forward * targetDistance, Color.red);
       if (Physics.Raycast(origin, targetOrigin.forward, out hit, targetDistance,hitLayer))
        {
            ITargetable hitTarget = hit.collider.GetComponent<ITargetable>();

            if (hitTarget != null)
            {
                if (_target == null || _target == hitTarget)
                {
                    _target = hitTarget;
                }
                else
                {
                    collectScore += _target.StartTarget();
                    _target = null;
                    scoreUI.text = ("Score: " + collectScore);
                }
            }
           
           
       }
        else if (_target != null)
        {
            collectScore += _target.StartTarget();

            _target = null;
            scoreUI.text = ("Score: " + collectScore);
        }
    }
}
