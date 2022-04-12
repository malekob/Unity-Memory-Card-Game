using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCard : MonoBehaviour
{
    [SerializeField]
    private SceneController controller;
    [SerializeField]
    private GameObject Card_Back;

    public void OnMouseDown()
    {
        if (Card_Back.activeSelf && controller.canReveal)
        {
            Card_Back.SetActive(false);
            controller.CardRevealed(this);
        }
    }

    private int _id;
    public int id
    {
        get { return _id; }
    }

    public void ChangeSprite(int id, Sprite image)
    {
        _id = id;
        //This will get the sprite renderer components and changes the property of the sprite 
        GetComponent<SpriteRenderer>().sprite = image;  
    }

    public void Unreveal()
    {
        Card_Back.SetActive(true);
    }
}
