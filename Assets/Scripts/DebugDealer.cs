using UnityEngine;

public class DebugDealer : MonoBehaviour
{
    public CardStack dealer;
    public CardStack player;

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 256, 28), "Interactuar"))
        {
            player.Push(dealer.Pop());
        }
    }
}
