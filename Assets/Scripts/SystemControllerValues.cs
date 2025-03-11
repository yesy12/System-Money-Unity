using System;
using UnityEngine;

public class SystemControllerValues : MonoBehaviour{

    #region Instance

    [NonSerialized] public static SystemControllerValues instance;
    public event Action<float> OnMoneyChanged;

    #endregion

    #region ScriptTableObjects

    [Header("ScriptableObjects")]
    public MoneySystem moneyData;
    #endregion

    private void Awake() {
        instance = this;
    }

    #region Money
    public void SetMoney(float amount) {
        moneyData.quantify = amount;
        OnMoneyChanged?.Invoke(amount);
    }

    public float GetMoney() {
        return moneyData.quantify;
    }
    #endregion

    public void EarnMoney() {
        SetMoney(GetMoney() + 50);
    }
    int i = 0;
    private void FixedUpdate() {
        i++;
        if (i == 20) {
            EarnMoney();
            i = 0;
        }
    }
}