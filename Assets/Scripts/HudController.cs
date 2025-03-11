using UnityEngine;
using TMPro;
using static UnityEngine.InputSystem.InputSettings;

public class HudController : MonoBehaviour{

    public TMP_Text MoneyTextValue;

    private void Awake() {
        
    }

    private void OnEnable() {
        SystemControllerValues.instance.OnMoneyChanged += UpdateMoney;
    }

    private void OnDisable() {
        SystemControllerValues.instance.OnMoneyChanged -= UpdateMoney;
    }


    //void FixedUpdate(){
    //    MoneyTextValue.text = SystemControllerValues.instance.moneyData.quantify.ToString();
    //}

    private void UpdateMoney(float amount) {
        MoneyTextValue.text = amount.ToString();
        Debug.Log(amount.ToString());
    }

}