using UnityEngine;
using TMPro;
using static UnityEngine.InputSystem.InputSettings;

public class HudController : MonoBehaviour{

    public TMP_Text MoneyTextValue;

    public GameObject instanceSystem;
    private SystemControllerValues systemControllerValues;

    private void Awake() {
        systemControllerValues = instanceSystem.GetComponent<SystemControllerValues>();
    }

    #region Events Action
    void OnEnable() {
        SystemControllerValues.instance.moneyData.OnMoneyChanged += UpdateMoney;     
    }

    void OnDisable() {
        SystemControllerValues.instance.moneyData.OnMoneyChanged -= UpdateMoney;
    }
    #endregion

    #region UpdateValuesText
    private void UpdateMoney(float amount) {
        MoneyTextValue.text = amount.ToString();
    }

    #endregion
}