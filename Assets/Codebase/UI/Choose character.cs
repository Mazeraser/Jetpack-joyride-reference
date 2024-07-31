using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codebase.UI
{
    public class ChooseCharacter : MonoBehaviour
    {
        public void SetPlayer(int index)
        {
            PlayerPrefs.SetInt("CharacterIndex", index);
        }
    }
}