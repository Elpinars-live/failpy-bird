using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class logicscript : MonoBehaviour
{
    public int score = 0;
    public Text scoretext;

[ContextMenu("increase score")]
    public void addscore(int scoretoadd)
    {
        score += scoretoadd;
        scoretext.text = score.ToString(); // Corrected line
    }
}