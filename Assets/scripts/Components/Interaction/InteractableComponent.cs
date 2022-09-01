﻿
using UnityEngine;
using UnityEngine.Events;

namespace PixelCrew.Components.Interaction
{
    public class InteractableComponent : MonoBehaviour
    {
        [SerializeField] private UnityEvent _action;

        public void Interact()
        {
            _action?.Invoke();
        }
    }
}
