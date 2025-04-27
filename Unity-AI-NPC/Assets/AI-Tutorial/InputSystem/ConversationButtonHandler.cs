/*******************************************************************
* COPYRIGHT       : 2025
* PROJECT         : Game Input System
* FILE NAME       : ConversationButtonHandler.cs
* DESCRIPTION     : Concrete subclass of UIButtonHandler for
*                   defining actual methods.
* REVISION HISTORY:
* Date             Author                    Comments
* ---------------------------------------------------------------------------
* 2005/02/08      Akram Taghavi-Burris      Created Class
*
*
/******************************************************************/

using UnityEngine;

namespace ProfessorAkram.AITutorial
{
    public class ConversationButtonHandler : UIButtonHandler
    {

        private Canvas _aiCanvas; //Canvas for aI 


        private void Start()
        {
            _aiCanvas = this.GetComponentInParent<Canvas>();
        }
        
        // Called by input action or button named "Play"
        public void OnEndConversationButton()
        {
            _canvas.GetComponent<AITextConversation>().EndConversation();

        }//end CancelRequest()

        
        
    }//end ConversationButtonHandler


}//end namespace