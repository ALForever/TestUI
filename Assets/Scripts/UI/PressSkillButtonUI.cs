using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressSkillButtonUI : MonoBehaviour{
    private SkillDataSO skillDataSO;
    private Button skillButton;


    public event EventHandler<OnPressSkillButtonEventArgs> OnPressSkillButton;
    public class OnPressSkillButtonEventArgs : EventArgs {
        public SkillDataSO skillDataSO;
    }


    private void Start() {
        skillDataSO = GetComponent<SkillDataLoaderUI>().GetSkillDataSO();
        skillButton = GetComponent<Button>();

        skillButton.onClick.AddListener(ButtonEventInvoke);
    }

    public void ButtonEventInvoke() {
        OnPressSkillButton?.Invoke(this, new OnPressSkillButtonEventArgs {
            skillDataSO = skillDataSO,
        });
    }


}
