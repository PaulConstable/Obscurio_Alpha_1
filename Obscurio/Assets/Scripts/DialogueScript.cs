using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "", menuName = "Dialogue", order = 1)]
public class DialogueScript : ScriptableObject {

    [TextArea(3,10)]public string DialogueText;
    public Sprite CharacterIcon;
}
