using UnityEngine;
using UnityEngine.UI;

public class PatientInvestigationHover : MonoBehaviour {

    public Sprite bodyPartSprite;
    public Sprite placeholderBodyPartSprite;
    public Image zoomedImage;

    public void BodyPartZoomEnter() {
        zoomedImage.sprite = bodyPartSprite;
    }

    public void BodyPartZoomExit()
    {
        zoomedImage.sprite = placeholderBodyPartSprite;
    }
}
