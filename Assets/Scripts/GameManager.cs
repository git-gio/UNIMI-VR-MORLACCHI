using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    // public Transform[] cardSlots;
    public bool hasCard = false;

    public GameObject rightHand;

    public TMP_Text deckSizeText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        deckSizeText.text = "Deck Size: " + deck.Count.ToString();
    }

    public void DrawCards()
    {
        if (deck.Count == 0)
        {
            Debug.Log("No cards left");
        }
        else
        {
            Card randCard = deck[Random.Range(0, deck.Count)];
            if (hasCard == false)
            {
                randCard.gameObject.SetActive(true);
                randCard.transform.parent = rightHand.transform;
                deck.Remove(randCard);
                hasCard = true;
                return;
            }
        }
    }
}

