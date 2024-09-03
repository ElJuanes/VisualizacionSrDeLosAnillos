using UnityEngine;

public class ObjectDisabler : MonoBehaviour
{
    public GameObject objectToToggle;

    // M�todo que alterna el estado del objeto (activa o desactiva)
    public void ToggleObject()
    {
        if (objectToToggle != null)
        {
            bool isActive = objectToToggle.activeSelf;  // Verifica si el objeto est� activo
            objectToToggle.SetActive(!isActive);  // Alterna el estado del objeto
        }
        else
        {
            Debug.LogWarning("No se ha asignado ning�n GameObject para alternar.");
        }
    }

    // M�todo que se llama cuando el bot�n es presionado
    public void OnButtonClick()
    {
        Debug.Log("�El bot�n ha sido presionado!");
        ToggleObject();  // Llama al m�todo para alternar el estado del objeto
    }
}
