using UnityEngine;
using UnityEngine.UI; 

public class UIButtonToggler : MonoBehaviour
{
    // Array para asignar los botones desde el editor
    public Button[] buttonsToToggle = new Button[5];

    // M�todo que alterna el estado de un bot�n de UI (por �ndice)
    public void ToggleUIButton(int index)
    {
        if (index >= 0 && index < buttonsToToggle.Length)
        {
            if (buttonsToToggle[index] != null)
            {
                bool isActive = buttonsToToggle[index].gameObject.activeSelf;  // Verifica si el bot�n est� activo
                buttonsToToggle[index].gameObject.SetActive(!isActive);  // Alterna el estado del bot�n
            }
            else
            {
                Debug.LogWarning("No se ha asignado ning�n bot�n en el �ndice " + index);
            }
        }
        else
        {
            Debug.LogError("�ndice fuera de rango: " + index);
        }
    }

    // M�todo que se llama cuando el bot�n es presionado
    public void OnUIButtonClick(int buttonIndex)
    {
        Debug.Log("�El bot�n de UI " + buttonIndex + " ha sido presionado!");
        ToggleUIButton(buttonIndex);  // Llama al m�todo para alternar el estado del bot�n de UI con el �ndice dado
    }
}
