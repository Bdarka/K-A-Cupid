using UnityEngine;
using TMPro;
using UnityEngine.UI;

// Going to comment this more throughly to make it easier to work on this project if I have to take time off from it

// Using this enum to darken character portrait based so only the current speaker stands out. 6 now for scalability
public enum CurrentSpeaker
{
    Character1,
    Character2, 
    Character3, 
    Character4, 
    Character5, 
    Character6
}

public class DialogueDisplaySystem : MonoBehaviour
{
    // These are where we'll put the Visual Novel style portraits
    // Likely keep these in /Resources during VN scenes rather than have a list on this script
    public Image CharacterPortrait1;
    public Image CharacterPortrait2;

    // Where the text is going to go
    // Will likely use Google Sheets -> CRV -> JSON pipeline to get these written 
    public TextMeshProUGUI DialogueBox;

    // Gotta be able to have sounds play. May scale later for voiced dialogue. It would be ideal if budget allows
    public AudioSource SFXSource;
    public AudioClip SFXClip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SFXSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CharacterTalking(CurrentSpeaker currentSpeaker)
    {

    }
}
