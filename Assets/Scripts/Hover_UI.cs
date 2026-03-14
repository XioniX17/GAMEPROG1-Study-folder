using UnityEngine;
using UnityEngine.EventSystems;

public class Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject HoverButton;
    public void OnPointerEnter(PointerEventData eventData)
    {
        HoverButton.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        HoverButton.SetActive(false);
    }
}
