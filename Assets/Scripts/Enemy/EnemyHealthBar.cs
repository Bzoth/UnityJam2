using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private Camera cameraOne;
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;
    void Update()
    {
        transform.rotation = cameraOne.transform.rotation;
        transform.position = target.position + offset;
    }

    public void UpdateHealth(float currentValue, float maxValue)
    {
        slider.value = currentValue / maxValue;
    }
}
