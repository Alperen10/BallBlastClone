using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : MonoBehaviour
{
    Coroutine shootingRoutine;
    void Update()
    {
        if (Input.GetMouseButton(0) && shootingRoutine == null)
        {
            shootingRoutine = StartCoroutine(Shoot());
        }
        else if (!Input.GetMouseButton(0) && shootingRoutine != null)
        {
            StopCoroutine(shootingRoutine);
            shootingRoutine = null;
        }
    }

    private IEnumerator Shoot()
    {
        while (true)
        {
            float shootSpeed = 1f / GameManager.Instance.bps;
            float initShootSpeed = shootSpeed;
            int rowCount = 1;


            while (shootSpeed < GameManager.Instance.maxShootSpeed)
            {
                shootSpeed += initShootSpeed;
                rowCount++;
            }

            Projectile shotProjectile = Projectile.GetFromPool();
            shotProjectile.gameObject.SetActive(true);
            shotProjectile.SetCount(rowCount);
            yield return new WaitForSeconds(shootSpeed);

        }
    }
}
