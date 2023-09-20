using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillDataLoaderUI : MonoBehaviour {
    [SerializeField] private SkillDataSO skillDataSO;
    [SerializeField] private Image skillImage;

    private void Start() {
        SetSkillImage();
    }

    private void SetSkillImage() {
        if (skillDataSO.skillSprite != null) {
            skillImage.sprite = skillDataSO.skillSprite;
            skillImage.gameObject.SetActive(true);
        } else {
            Debug.Log("SkillDataSO element has no a sprite!");
            skillImage.gameObject.SetActive(false);            
        }
    }

    public SkillDataSO GetSkillDataSO() {
        return skillDataSO;
    }
}
