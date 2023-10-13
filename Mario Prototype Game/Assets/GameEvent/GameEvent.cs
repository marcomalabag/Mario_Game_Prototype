using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Purpose for adding and using Game events as scriptable objects 
 is because the game has many events. For example, the game 
can be over by falling or colliding with an enemy. Also, there 
are many events for scoring. To easily add those events, 
this unity architecture was added. */


    [CreateAssetMenu(menuName = "ScriptableObjects/GameEvent")]
    public class GameEvent : ScriptableObject
    {
        private List<IGameEventListener> listeners;

        private void OnEnable()
        {
            listeners = new List<IGameEventListener>();
        }

        public void Raise() // Executes the logic and code when the listeners see that the game event is raised
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised();
            }
        }

        public void RegisterListener(IGameEventListener gameEventListener)
        {
            listeners.Add(gameEventListener);
        }

        public void UnregisterListener(IGameEventListener gameEventListener)
        {
            listeners.Remove(gameEventListener);
        }
    }

