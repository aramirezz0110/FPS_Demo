using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIAnimationController : MonoBehaviour
{
    [Header("UI Buttons")]
    [SerializeField] private Button dance1Button;
    [SerializeField] private Button dance2Button;
    [SerializeField] private Button dance3Button;
    [Header("Animation References")]
    [SerializeField] private Animator animator;
    private void Start()
    {
        AsignListeners();
    }
    private void AsignListeners()
    {
        dance1Button.onClick.AddListener(PlayAnimation1);
        dance2Button.onClick.AddListener(PlayAnimation2);
        dance3Button.onClick.AddListener(PlayAnimation3);
    }
    private void PlayAnimation1() => animator.SetTrigger(UIAnimationParameters.Dance1);
    private void PlayAnimation2() => animator.SetTrigger(UIAnimationParameters.Dance2);
    private void PlayAnimation3() => animator.SetTrigger(UIAnimationParameters.Dance3);
    

}
