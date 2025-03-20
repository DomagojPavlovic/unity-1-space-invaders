using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletShoot : MonoBehaviour
{
    private readonly int MIN_LEVEL = 1;
    private readonly int MAX_LEVEL = 7;

    private readonly float LEVEL_2_BULLETS_OFFSET = 0.1f;

    private readonly float LEVEL_3_BULLETS_OFFSET = 0.1f;
    private readonly float LEVEL_3_BULLETS_ANGLE = 10f;

    private readonly float LEVEL_4_BULLETS_1_AND_2_OFFSET = 0.05f;
    private readonly float LEVEL_4_BULLETS_1_AND_2_ANGLE = 2f;
    private readonly float LEVEL_4_BULLETS_3_AND_4_OFFSET = 0.15f;
    private readonly float LEVEL_4_BULLETS_3_AND_4_ANGLE = 7.5f;

    private readonly float LEVEL_5_BULLETS_2_AND_3_OFFSET = 0.1f;
    private readonly float LEVEL_5_BULLETS_2_AND_3_ANGLE = 4f;
    private readonly float LEVEL_5_BULLETS_4_AND_5_OFFSET = 0.2f;
    private readonly float LEVEL_5_BULLETS_4_AND_5_ANGLE = 9f;

    private readonly float LEVEL_6_BULLETS_1_AND_2_OFFSET = 0.05f;
    private readonly float LEVEL_6_BULLETS_1_AND_2_ANGLE = 2f;
    private readonly float LEVEL_6_BULLETS_3_AND_4_OFFSET = 0.15f;
    private readonly float LEVEL_6_BULLETS_3_AND_4_ANGLE = 6.5f;
    private readonly float LEVEL_6_BULLETS_5_AND_6_OFFSET = 0.25f;
    private readonly float LEVEL_6_BULLETS_5_AND_6_ANGLE = 10f;

    private readonly float LEVEL_7_BULLETS_2_AND_3_OFFSET = 0.1f;
    private readonly float LEVEL_7_BULLETS_2_AND_3_ANGLE = 4f;
    private readonly float LEVEL_7_BULLETS_4_AND_5_OFFSET = 0.2f;
    private readonly float LEVEL_7_BULLETS_4_AND_5_ANGLE = 9f;
    private readonly float LEVEL_7_BULLETS_6_AND_7_OFFSET = 0.3f;
    private readonly float LEVEL_7_BULLETS_6_AND_7_ANGLE = 13f;

    public int level { get; private set; }

    public GameObject bullet;

    void Start()
    {
        if (StaticData.LoadFromStaticData())
        {
            level = StaticData.currentPlayerLevel;
        }
        else
        {
            level = MIN_LEVEL;
        }
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Shoot();
    }

    void Shoot()
    {
        switch (level)
        {
            case 1:
                Instantiate(bullet, transform.position, Quaternion.identity);
                break;
            case 2:
                Instantiate(bullet, transform.position + new Vector3(LEVEL_2_BULLETS_OFFSET, 0, 0), Quaternion.identity);
                Instantiate(bullet, transform.position + new Vector3(-LEVEL_2_BULLETS_OFFSET, 0, 0), Quaternion.identity);
                break;
            case 3:
                Instantiate(bullet, transform.position + new Vector3(LEVEL_3_BULLETS_OFFSET, 0, 0), Quaternion.AngleAxis(-LEVEL_3_BULLETS_ANGLE, Vector3.forward));
                Instantiate(bullet, transform.position, Quaternion.identity);
                Instantiate(bullet, transform.position + new Vector3(-LEVEL_3_BULLETS_OFFSET, 0, 0), Quaternion.AngleAxis(LEVEL_3_BULLETS_ANGLE, Vector3.forward));
                break;
            case 4:
                Instantiate(bullet, transform.position + new Vector3(LEVEL_4_BULLETS_3_AND_4_OFFSET, 0, 0), Quaternion.AngleAxis(-LEVEL_4_BULLETS_3_AND_4_ANGLE, Vector3.forward));
                Instantiate(bullet, transform.position + new Vector3(LEVEL_4_BULLETS_1_AND_2_OFFSET, 0, 0), Quaternion.AngleAxis(-LEVEL_4_BULLETS_1_AND_2_ANGLE, Vector3.forward));
                Instantiate(bullet, transform.position + new Vector3(-LEVEL_4_BULLETS_1_AND_2_OFFSET, 0, 0), Quaternion.AngleAxis(LEVEL_4_BULLETS_1_AND_2_ANGLE, Vector3.forward));
                Instantiate(bullet, transform.position + new Vector3(-LEVEL_4_BULLETS_3_AND_4_OFFSET, 0, 0), Quaternion.AngleAxis(LEVEL_4_BULLETS_3_AND_4_ANGLE, Vector3.forward));
                break;
            case 5:
                Instantiate(bullet, transform.position + new Vector3(LEVEL_5_BULLETS_4_AND_5_OFFSET, 0, 0), Quaternion.AngleAxis(-LEVEL_5_BULLETS_4_AND_5_ANGLE, Vector3.forward));
                Instantiate(bullet, transform.position + new Vector3(LEVEL_5_BULLETS_2_AND_3_OFFSET, 0, 0), Quaternion.AngleAxis(-LEVEL_5_BULLETS_2_AND_3_ANGLE, Vector3.forward));
                Instantiate(bullet, transform.position, Quaternion.identity);
                Instantiate(bullet, transform.position + new Vector3(-LEVEL_5_BULLETS_2_AND_3_OFFSET, 0, 0), Quaternion.AngleAxis(LEVEL_5_BULLETS_2_AND_3_ANGLE, Vector3.forward));
                Instantiate(bullet, transform.position + new Vector3(-LEVEL_5_BULLETS_4_AND_5_OFFSET, 0, 0), Quaternion.AngleAxis(LEVEL_5_BULLETS_4_AND_5_ANGLE, Vector3.forward));
                break;
            case 6:
                Instantiate(bullet, transform.position + new Vector3(LEVEL_6_BULLETS_5_AND_6_OFFSET, 0, 0), Quaternion.AngleAxis(-LEVEL_6_BULLETS_5_AND_6_ANGLE, Vector3.forward));
                Instantiate(bullet, transform.position + new Vector3(LEVEL_6_BULLETS_3_AND_4_OFFSET, 0, 0), Quaternion.AngleAxis(-LEVEL_6_BULLETS_3_AND_4_ANGLE, Vector3.forward));
                Instantiate(bullet, transform.position + new Vector3(LEVEL_6_BULLETS_1_AND_2_OFFSET, 0, 0), Quaternion.AngleAxis(-LEVEL_6_BULLETS_1_AND_2_ANGLE, Vector3.forward));
                Instantiate(bullet, transform.position + new Vector3(-LEVEL_6_BULLETS_1_AND_2_OFFSET, 0, 0), Quaternion.AngleAxis(LEVEL_6_BULLETS_1_AND_2_ANGLE, Vector3.forward));
                Instantiate(bullet, transform.position + new Vector3(-LEVEL_6_BULLETS_3_AND_4_OFFSET, 0, 0), Quaternion.AngleAxis(LEVEL_6_BULLETS_3_AND_4_ANGLE, Vector3.forward));
                Instantiate(bullet, transform.position + new Vector3(-LEVEL_6_BULLETS_5_AND_6_OFFSET, 0, 0), Quaternion.AngleAxis(LEVEL_6_BULLETS_5_AND_6_ANGLE, Vector3.forward));
                break;
            case 7:
                Instantiate(bullet, transform.position + new Vector3(LEVEL_7_BULLETS_6_AND_7_OFFSET, 0, 0), Quaternion.AngleAxis(-LEVEL_7_BULLETS_6_AND_7_ANGLE, Vector3.forward));
                Instantiate(bullet, transform.position + new Vector3(LEVEL_7_BULLETS_4_AND_5_OFFSET, 0, 0), Quaternion.AngleAxis(-LEVEL_7_BULLETS_4_AND_5_ANGLE, Vector3.forward));
                Instantiate(bullet, transform.position + new Vector3(LEVEL_7_BULLETS_2_AND_3_OFFSET, 0, 0), Quaternion.AngleAxis(-LEVEL_7_BULLETS_2_AND_3_ANGLE, Vector3.forward));
                Instantiate(bullet, transform.position, Quaternion.identity);
                Instantiate(bullet, transform.position + new Vector3(-LEVEL_7_BULLETS_2_AND_3_OFFSET, 0, 0), Quaternion.AngleAxis(LEVEL_7_BULLETS_2_AND_3_ANGLE, Vector3.forward));
                Instantiate(bullet, transform.position + new Vector3(-LEVEL_7_BULLETS_4_AND_5_OFFSET, 0, 0), Quaternion.AngleAxis(LEVEL_7_BULLETS_4_AND_5_ANGLE, Vector3.forward));
                Instantiate(bullet, transform.position + new Vector3(-LEVEL_7_BULLETS_6_AND_7_OFFSET, 0, 0), Quaternion.AngleAxis(LEVEL_7_BULLETS_6_AND_7_ANGLE, Vector3.forward));
                break;
        }
    }

    public void LevelUp()
    {
        if (level == MAX_LEVEL)
            return;
        level++;
    }

    public void LevelDown()
    {
        if (level == MIN_LEVEL)
            return;
        level--;
    }

}