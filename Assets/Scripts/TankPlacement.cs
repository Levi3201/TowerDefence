using UnityEngine;

public class TankPlacement : MonoBehaviour
{
    public GameObject tankPrefab; // ссылка на спрайт танка, который будет создан при нажатии. Присваивается вручную в Inspector (перетаскиванием PlayerTank в это поле).
    private bool isOccupied = false; // определяет, занята ли точка (false – можно разместить танк, true – уже занята).

    void OnMouseDown() // вызывается при нажатии на объект.
    {
        if (!isOccupied) // Если точка свободна
        {
            GameObject newTank = Instantiate(tankPrefab, transform.position, Quaternion.identity); // создает новый танк в текущей позиции (transform.position). Quaternion.identity означает, что танк не будет повернут при спавне.
            isOccupied = true; // Отмечаем точку как занятую
            gameObject.SetActive(false); // Делаем точку невидимой
        }
    }
}
