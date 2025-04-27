/*******************************************************************
* COPYRIGHT       : 2025
* PROJECT         : AI Tutorial
* FILE NAME       : NPCChatAI.cs
* DESCRIPTION     : Behaviors for AI NPC
*
* REVISION HISTORY:
* Date             Author                    Comments
* ---------------------------------------------------------------------------
* 2005/04/18      Akram Taghavi-Burris      Created Interface
*
*
/******************************************************************/

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem;
using LLMUnity;

namespace ProfessorAkram.AITutorial
{
    [RequireComponent(typeof(BoxCollider))]
    public class NPCChatAI: MonoBehaviour, IInteractable
    {
//DEFINE EVENTS 
        
        [SerializeField] [Tooltip("GameObject that has the LLM Module")]
        private LLM _llmModel;
        
        [SerializeField] [Tooltip("GameObject to use for LLM Character")]
        private GameObject _llmCharacterGameObject;
        private LLMCharacter _llmCharacter;   
        
//DEFINE AI Prompt

        private string _aiCharacterPrompt;
        
        //Reference to the player input
        private PlayerInput _playerInput;

        // Async Task allows this method to be awaited without freezing the game loop.
        async void  Start()
        {
            
            //Ensure BoxCollider is a trigger
            BoxCollider npcCollider = this.gameObject.GetComponent<BoxCollider>();
            npcCollider.isTrigger = true;
            
//GET PROMPT

            await InstantiateLLMCharacter();

        }//end Start()

        
        
//Create the LLM Character component and set defaults
        // Async Task allows this method to be awaited without freezing the game loop.
        async Task  InstantiateLLMCharacter()
        {

          
            
        }//end InstantiateLLMCharacter()
        
        
        // Required by IInteractable Interface
        // Called when the player (or another object) interacts with the item. 
        public void OnInteract(GameObject interactor)
        {
            //Prepare player input for conversation
            Debug.Log($"Start AI Interaction");
            
//INVOKE ACTION

        }//end Interact()
        
        
        private void OnTriggerEnter(Collider other)
        {
            //If player get the player input
            if (other.CompareTag("Player"))
            {
                OnInteract(other.gameObject);
             //   _playerInput = other.gameObject.GetComponent<PlayerInput>();
              //  _playerInput.enabled = false;
            }

        }//end OnTriggerEnter()

        public void EndConversation()
        {
            Debug.Log($"End Conversation");
//INVOKE ACTION
        }

        private void OnTriggerExit(Collider other)
        {
//INVOKE ACTION
            EndConversation();
        }

         
    }//end IInteractable
    
}//end Namespace