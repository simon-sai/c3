using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPlayerShipDetailCtrl : SaiMonoBehaviour
{
    [Header("Player Ship Detail")]
    private static UIPlayerShipDetailCtrl instance;
    public static UIPlayerShipDetailCtrl Instance { get => instance; }

    public UIAppear uIAppear;

    protected override void Awake()
    {
        if (UIPlayerShipDetailCtrl.instance != null) Debug.LogError("Only 1 UIPlayerShipDetail allow to exist");
        UIPlayerShipDetailCtrl.instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadUIAppear();
    }

    protected virtual void LoadUIAppear()
    {
        if (this.uIAppear != null) return;
        this.uIAppear = GetComponent<UIAppear>();
        Debug.LogWarning(transform.name + ": LoadUIAppear", gameObject);
    }
}