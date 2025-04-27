/*******************************************************************
* COPYRIGHT       : 2025
* PROJECT         : AI NPC Tutorial - Transformers AI & Games Conference
* FILE NAME       : AITextChat.cs
* DESCRIPTION     : Handles the AI Text Interaction
* REQUIREMENTS    : Requires LLM Unity package https://github.com/undreamai/LLMUnity
*
* REVISION HISTORY:
* Date             Author                    Comments
* ---------------------------------------------------------------------------
* 2005/04/18      Akram Taghavi-Burris      Created Class
*
*
/******************************************************************/


using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using LLMUnity;
using StarterAssets; //reference to LLM Unity namespace


//See completed class AI-Tutorial\01-FinishedTutorial\Scripts\AITextConversation.cs
    public class AITextChat: MonoBehaviour
    {
        [Header("Game Actors")]
        [SerializeField]
        [Tooltip("Reference to player input component")]
        private PlayerInput _playerInput;
        private ThirdPersonController _playerController;
        
        [SerializeField]
        [Tooltip("String name of the player action map")]
        private string _playerActionMapName;
        [SerializeField]
        [Tooltip("String name of the ui action map")]
        private string _uiActionMapName;
        
//AI CHAT NPC REFERENCE

        [Header("Text Conversation Components")]
        [SerializeField]
        [Tooltip("Canvas for the AI conversation")]
        private Canvas _aiCanvas; //Canvas for aI 
        
        [SerializeField]
        [Tooltip("Input Text for the player")]
        private InputField _playerInputText;
        
        [SerializeField]
        [Tooltip("Text for the AI response")]
        private Text _aiResponseText;
        
        
        void Start()
        {
            //Disable the AI conversation canvas at start
            _aiCanvas.enabled = false;

            Debug.Log(_playerActionMapName);
            Debug.Log(_uiActionMapName);
            
            //Deactivate the player input field
            _playerInputText.interactable = false;

        }//end Start()
        
        
        /// <summary>
        /// Behaviors for toggling player input to ui input and cursor
        /// </summary>
        
        // This method toggles between UI and Player controls
        private void ToggleUI()
        {
            if (_playerInput.currentActionMap.name == "UI")
            {
                // Switch back to Player controls
                _playerInput.SwitchCurrentActionMap("Player");
                LockCursor();
            }
            else
            {
                // Switch to UI controls
                _playerInput.SwitchCurrentActionMap("UI");
                UnlockCursor();
            }
        }//end ToggleUI

        private void UnlockCursor()
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            
        }// end UnlockCursor()

        private void LockCursor()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }//end LockCursor()


        
// SUBSCRIBE to the AI CHAT NPC event

        
//HANDEL CONVERSATION
       

        //When player input is submitted
        void OnInputFieldSubmit(string message)
        {
            //Deactivate the player input field
            _playerInputText.interactable = false;
            
            //Set AI initial response
            _aiResponseText.text = "...";
            
 //INITIATE LLM CHAT
            
        }//end OnInputFieldSubmit
        

        //Post the AI response to the text box
        private void PostAIResponse(string text)
        {
            Debug.Log(text);
            _aiResponseText.text = text;
            
        }//end PostAIResponse()
        

        //When AI reply is completed
        private void OnReplyCompleted()
        {
            _playerInputText.interactable = true;
            _playerInputText.Select();
            _playerInputText.text = "";
            
        }//end OnReplyCompleted()
        

        //Cancel AI request
        public void OnCancelRequests()
        {
 //CANCEL the llm character request
            
            OnReplyCompleted();
            
        }//end CancelRequest()
        
        
        //End Conversation with AI
        public void EndConversation()
        {
//AI CHAT NPC END CONVERSATION

        }//end CancelRequest()
        

//ON VALIDATE LLM MODULE
        
}//end AITextInteraction
    
