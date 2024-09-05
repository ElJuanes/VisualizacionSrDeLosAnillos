using UnityEngine;
using UnityEngine.UI; 

public class UIButtonToggler : MonoBehaviour
{
    // Array para asignar los botones desde el editor
    public Button[] buttonsToToggle = new Button[5];

    // Método que alterna el estado de un botón de UI (por índice)
    public void ToggleUIButton(int index)
    {
        if (index >= 0 && index < buttonsToToggle.Length)
        {
            if (buttonsToToggle[index] != null)
            {
                bool isActive = buttonsToToggle[index].gameObject.activeSelf;  // Verifica si el botón está activo
                buttonsToToggle[index].gameObject.SetActive(!isActive);  // Alterna el estado del botón
            }
            else
            {
                Debug.LogWarning("No se ha asignado ningún botón en el índice " + index);
            }
        }
        else
        {
            Debug.LogError("Índice fuera de rango: " + index);
        }
    }

    // Método que se llama cuando el botón es presionado
    public void OnUIButtonClick(int buttonIndex)
    {
        Debug.Log("¡El botón de UI " + buttonIndex + " ha sido presionado!");
        ToggleUIButton(buttonIndex);  // Llama al método para alternar el estado del botón de UI con el índice dado
    }
}
