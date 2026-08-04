using UnityEngine;
using UnityEngine.EventSystems;

public class StartButtonClick : MonoBehaviour, IPointerClickHandler
{
    public SessionIntroController introController;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (introController != null)
        {
            introController.StartSession();
        }
    }
}