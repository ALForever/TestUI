using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillsDropDownWindowUI : MonoBehaviour
{
    [SerializeField] private GameObject skillsContainer;
    [SerializeField] private GameObject skillWindowContainer;
    [SerializeField] private Image skillImage;
    [SerializeField] private TextMeshProUGUI skillName;
    [SerializeField] private TextMeshProUGUI skillDescription;



    private PressSkillButtonUI[] pressSkillButtonUIs;
    private SkillDataSO currentSkillDataSO;

    private void Start() {
        pressSkillButtonUIs = skillsContainer.GetComponentsInChildren<PressSkillButtonUI>();

        foreach (var pressSkillButtonUI in pressSkillButtonUIs) {
            pressSkillButtonUI.OnPressSkillButton += PressSkillButtonUI_OnPressSkillButton;
        }
    }

    private void PressSkillButtonUI_OnPressSkillButton(object sender, PressSkillButtonUI.OnPressSkillButtonEventArgs e) {
        if (currentSkillDataSO != e.skillDataSO) {
            if (e.skillDataSO.skillSprite != null) {
                skillImage.sprite = e.skillDataSO.skillSprite;
                skillImage.gameObject.SetActive(true);
            }

            skillName.text = e.skillDataSO.skillName;
            skillDescription.text = e.skillDataSO.skillDescription;
        }
        

        WindowVisibilityController(e.skillDataSO);
    }

    private void WindowVisibilityController(SkillDataSO newSkillDataSO) {
        if (!skillWindowContainer.activeSelf) {
            //Окно с описанием умений свёрнуто
            skillWindowContainer.SetActive(true);
            currentSkillDataSO = newSkillDataSO;
        } else {
            //Окно с описанием умений развёрнуто
            if (currentSkillDataSO == newSkillDataSO) {
                //2ое нажатие на кнопку умения
                skillWindowContainer.SetActive(false);
            } else {
                //1ое нажатие на кнопку умения
                currentSkillDataSO = newSkillDataSO;
            }
        }
    }
}
