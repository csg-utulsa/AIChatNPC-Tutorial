/*******************************************************************
* COPYRIGHT       : 2025
* PROJECT         : AI Tutorial
* FILE NAME       : UIButtonHandler.cs
* DESCRIPTION     : Registers UI Button actions 
*                   Use reflection to invoke the corresponding input action method in GameStateInputHandler
*
* REVISION HISTORY:
* Date             Author                    Comments
* ---------------------------------------------------------------------------
* 2005/04/18     Akram Taghavi-Burris      Created Class
*
*
/******************************************************************/


using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

namespace ProfessorAkram.AITutorial
{
    public abstract class UIButtonHandler : MonoBehaviour
    {
        [SerializeField] protected Canvas _canvas; // <- Instead of UIDocument
        protected Dictionary<string, Button> _buttonDictionary = new();

        private void Awake()
        {
            // Get the Canvas component attached to this GameObject
            _canvas = GetComponentInParent<Canvas>();

            if (_canvas == null)
            {
                Debug.LogError($"{nameof(UIButtonHandler)} requires a Canvas reference.");
                return;
            }
        }

        private void Start()
        {
            InitializeButtons();
        }

        private void InitializeButtons()
        {
            // Get all Button components that are children of the Canvas
            Button[] buttons = _canvas.GetComponentsInChildren<Button>(true);

            if (buttons.Length == 0)
            {
                Debug.LogWarning("No buttons found in the Canvas.");
                return;
            }

            foreach (var button in buttons)
            {
                string buttonNameCopy = button.name; // <-- make a copy!

                if (string.IsNullOrEmpty(buttonNameCopy))
                    continue;

                _buttonDictionary[buttonNameCopy] = button;
                button.onClick.AddListener(() => OnButtonClick(buttonNameCopy));
            }
        }

        private void OnButtonClick(string buttonName)
        {
            // Use reflection to invoke the corresponding method
            var methodInfo = GetType().GetMethod($"On{buttonName}",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            if (methodInfo != null)
            {
                methodInfo.Invoke(this, null);
            }
            else
            {
                Debug.LogWarning($"No method found for button: On{buttonName} in {nameof(UIButtonHandler)}.");
            }
        }
        
    }//end UIButtonHandler
    
}//end namespace
