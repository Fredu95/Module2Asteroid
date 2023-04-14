using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StartGame : MonoBehaviour
{
     [SerializeField] GameObject player;
    [SerializeField] Transform startPosition;
    [SerializeField] TextMeshProUGUI startText;
    // Update is called once per frame
    void Update()
    {
  if (Input.GetButtonDown("Jump") && player != null)
  {
    Instantiate(player,startPosition.position, transform.rotation);
    Destroy(gameObject);
  }
  
    }
}
