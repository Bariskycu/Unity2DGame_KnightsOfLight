using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Stat
{
    [SerializeField]
    private BarScript bar;

    [SerializeField]
    private float maxVal;

    [SerializeField]
    private float currentVal;

    public float _currentVal
    {
        get
        {
            return currentVal;
        }
        set
        {
            this.currentVal=Mathf.Clamp(value,0,maxVal);
            bar.Value = currentVal;
        }
    }

    public float _maxVal
    {
        get
        {
            return maxVal;
        }
        set
        {
            this.maxVal = value;
            bar.MaxValue = maxVal;
        }
    }

    public void Initialize()
    {
        this._maxVal = maxVal;
        this._currentVal = currentVal;
    }

}
