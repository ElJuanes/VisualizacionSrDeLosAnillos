using UnityEngine;

public class ObjectDisabler : MonoBehaviour
{
    public GameObject objectToToggle;

    // Método que alterna el estado del objeto (activa o desactiva)
    public void ToggleObject()
    {
        if (objectToToggle != null)
        {
            bool isActive = objectToToggle.activeSelf;  // Verifica si el objeto está activo
            objectToToggle.SetActive(!isActive);  // Alterna el estado del objeto
        }
        else
        {
            Debug.LogWarning("No se ha asignado ningún GameObject para alternar.");
        }
    }

    // Método que se llama cuando el botón es presionado
    public void OnButtonClick()
    {
        Debug.Log("¡El botón ha sido presionado!");
        ToggleObject();  // Llama al método para alternar el estado del objeto
    }
}
