/*******************************************************************
* COPYRIGHT       : 2025
* PROJECT         : AI Tutorial
* FILE NAME       : IInteractable.cs
* DESCRIPTION     : Interface for interactable items
*
* REVISION HISTORY:
* Date             Author                    Comments
* ---------------------------------------------------------------------------
* 2005/04/18      Akram Taghavi-Burris      Created Interface
*
*
/******************************************************************/

using UnityEngine;

    public interface IInteractable
    {
        public void OnInteract(GameObject interactor);
         
    }//end IInteractable
    