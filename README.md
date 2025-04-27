
# AI Chat NPC - Tutorial

**Prepared and Presented by**  
**Professor Akram Taghavi-Burris**  
Program Director and Associate Instructional Professor of Computer Simulation & Gaming  
University of Tulsa, Tandy School of Computer Science
---

## Overview

Welcome to the **AI Chat NPC Tutorial**! In this tutorial, we will build on top of the open-source **LLM Unity Plugin** and integrate advanced features to create interactive in-game characters capable of chatting with players. You will learn how to:

- Integrate **AI-powered NPCs** into Unity games.
- Use **Events** to delegate actions to various NPCs.
- Utilize **Async Tasks** for preloading prompts to ensure smooth gameplay.
- Randomize AI prompt loading for dynamic character interactions.
- Implement **Multiple AI prompts** to diversify NPC responses.

By the end of this tutorial, you'll have a working framework for AI-driven NPCs that can be integrated into your game projects for rich, dynamic player interactions.

---

## Prerequisites

Before starting this tutorial, ensure you have the following:

- **Unity (2020 or later)**: You will need a Unity version that supports the Unity Package Manager.
- **Open Source LLM Unity Plugin**: Download and integrate the open-source LLM plugin into your Unity project.
- **Basic Unity & C# Knowledge**: A familiarity with Unity development and C# scripting.
- **AI/LLM Setup**: A pre-configured LLM (large language model) or an API service that you intend to use for AI-driven conversation.

### Optional Prerequisite:

- **Unity StarterAssets Character Controller**: 
   - This tutorial is compatible with Unity's **StarterAssets Character Controller** package. It uses **Cinemachine** and the **New Input System** to provide smooth character movement and camera controls.
   - **Why Use StarterAssets**: It simplifies character movement and camera management, providing a ready-made controller for your NPC or player character. If you already have your own controller setup, feel free to skip this part, but using **StarterAssets** will speed up the process and make character setup easier.

---

## Tutorial Features

### 1. **In-Game Character Interaction**

We’ll begin by creating a functional AI Chat NPC that responds to player input. This section walks you through creating the necessary components, including:

- **Player Input Handling**: How to capture player text input and process it through the AI.
- **AI Response Handling**: Displaying the AI's response in the game world.
- **Text Field UI Integration**: Implementing an interactive UI for players to chat with the NPC.

### 2. **Integration of Events to Delegate Actions**

Learn how to use Unity’s Event System to delegate actions between your NPCs and other game elements. Events are ideal for decoupling the AI logic from other systems in your game.

- **Using C# Events**: Create event listeners that trigger specific actions in the NPC, like starting or ending a conversation.
- **Delegating Tasks**: How to delegate actions to other systems, such as starting gameplay elements, triggering animations, or activating triggers when the conversation ends.

### 3. **Async Tasks to Preload Prompts**

To ensure a smooth and seamless gameplay experience, we'll use **async tasks** to preload AI responses in the background.

- **Async AI Calls**: Understand how to load prompts asynchronously to avoid UI freezes during conversations.
- **Efficient AI Communication**: How to ensure that new AI responses are ready by the time the player submits a new message.

### 4. **Random AI Prompt Loading**

Introduce variability into NPC conversations by loading random prompts for each interaction.

- **Randomized Responses**: Set up multiple prompts that the NPC can choose from when responding.
- **Diverse Dialogue**: Learn how to enrich player-NPC interactions by adding variety to the conversations using random selections of AI-generated text.

### 5. **Multiple AI Prompts**

Extend the NPC's conversation by allowing multiple prompts to be handled at once.

- **Multiple Concurrent Prompts**: How to handle different conversation threads or topics simultaneously, without interrupting ongoing dialogues.
- **Managing Conversation State**: Learn how to manage multiple conversations and topics with ease.

---

<!-- ## Installation

1. **Download the Unity Project**: Clone the repository or download the project folder.
2. **Install the LLM Unity Plugin**: Follow the installation instructions from the [LLM Unity Plugin GitHub Repository](#). Ensure you have properly integrated it into your Unity project.
3. **Install Unity StarterAssets**: 
   - Install the **StarterAssets** package from Unity's **Package Manager** to get access to the **Character Controller** with **Cinemachine** and **New Input System**.
   - [Link to Unity StarterAssets Package](https://github.com/Unity-Technologies/StarterAssets)
4. **Add the Tutorial Script**: Import the provided tutorial script into your Unity project’s `Assets/Scripts` folder.
5. **Set Up the UI**: Implement the provided UI prefab for handling player inputs and displaying AI responses.
6. **Configure AI Model**: Set up and link your AI model or API endpoint in the `AIChatNPC` component.

--->

## Project Structure

Here’s a quick overview of the key files and folders in this project:

- **`00-StartTutorial`**: Contains the starting point of the tutorial with all the necessary assets and a base project setup.
- **`01-Finished-Tutorial`**: Contains the completed version of the tutorial with all the features fully implemented for easy comparison and access to completed steps.
- **Assets/Scripts/AITextConversation.cs**: Main script for managing the NPC’s chat interactions.
- **Assets/Scripts/AIChatNPC.cs**: Script responsible for initializing the AI and responding to player input.
- **Assets/Prefabs/UI/AIChatUI.prefab**: Prefab for the UI elements where players can interact with the NPC.
- **Assets/Prefabs/AICharacter.prefab**: The NPC character that will interact with the player.

---


## License

This tutorial is open-source and available under the [MIT License](LICENSE).
