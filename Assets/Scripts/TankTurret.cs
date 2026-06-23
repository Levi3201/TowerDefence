using UnityEngine;

public class TankTurret : MonoBehaviour
{
    public Transform target; // ссылка на объект, за которым должна следить пушка (игрок или враг). Присваивается вручную в Inspector или автоматически в коде.
    public float rotationSpeed = 5f; // скорость вращения пушки.

    void Update() // вызывается каждый кадр, обновляя поворот пушки
    {
        if (target != null) // проверяет, есть ли цель
        {
            Vector3 direction = target.position - transform.position; // определяет вектор направления к цели. target.position — transform.position создает вектор от пушки к врагу/игроку.
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; // Mathf.Atan2(y, x) вычисляет угол между пушкой и целью. * Mathf.Rad2Deg переводит угол из радиан в градусы, так как Unity работает в градусах.
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, angle), rotationSpeed * Time.deltaTime); // плавно поворачивает пушку. (Quaternion.Lerp() делает поворот сглаженным). Quaternion.Euler(0, 0, angle) создает угол поворота по оси Z, так как мы работаем в 2D. rotationSpeed * Time.deltaTime контролирует скорость поворота, чтобы она не была мгновенной.
        }
    }
}
