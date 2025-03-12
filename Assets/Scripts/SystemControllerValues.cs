using System;
using UnityEngine;
using static UnityEngine.InputSystem.InputSettings;

[DefaultExecutionOrder(-100)]
public class SystemControllerValues : MonoBehaviour{

    #region Instance
    [SerializeField]public static SystemControllerValues instance;
    #endregion

    #region ScriptTableObjects
    [Header("ScriptableObjects")]
    public MoneySystem moneyData;
    #endregion

    public int i = 0;

    private void Awake() {
        instance = this;
    }


    private void FixedUpdate() {
        i++;
        if (i == 20) {
            moneyData.addMoney(10);
            i = 0;
        }
    }
}