using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SwipeUI : MonoBehaviour
{
   [SerializeField] private Button _increaseButton;
   [SerializeField] private Button _decreaseButton;
   [SerializeField] private TMP_Text _swipeMinimumValue;
   private void Update()
   {
      _swipeMinimumValue.text = SetupSwipeSensativity.Instance._swipeSensitivity.ToString();
   }

   private void Start()
   {
      _increaseButton.onClick.AddListener(() => Increase(10));
      _decreaseButton.onClick.AddListener(() => Decrease(10));
   }

   public void Increase(int increaseValue)
   {
      SetupSwipeSensativity.Instance._swipeSensitivity += increaseValue;
   }
   public void Decrease(int decreaseValue)
   {
      SetupSwipeSensativity.Instance._swipeSensitivity -= decreaseValue;
   }
}
