using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitScript : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] public int Speed = 5;
    [SerializeField] public int SpeedRemaining = 0;
    [Tooltip("Animation speed")]
    [SerializeField] public int animationSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        SpeedRemaining = Speed;
    }

    bool moving = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && SpeedRemaining > 0 && !moving)
        {
            Travel();
        }
    }

    bool finished = false;
    void Travel()
    {
        //store mouse pos
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mousePos == transform.position)
        {
            finished = true;
            return;
        }
        //find the final destination
        float finX, finY;
        finX = FindDestination(mousePos.x);
        finY = FindDestination(mousePos.y);

        //start moving
        Vector3 unit = gameObject.GetComponent<Transform>().position;
        if (unit.x != finX || unit.y != finY)
        {
            StartCoroutine(MoveTiles(unit, finX, finY));
        }

    }

    IEnumerator MoveTiles(Vector3 unit, float finX, float finY)
    {
        Vector3 newPos = gameObject.GetComponent<Transform>().position;
        while(SpeedRemaining > 0 && (finX != newPos.x || finY != newPos.y))
        {
            moving = true;
            if (finished) break;
            if (finX != newPos.x)
            {
                bool dirX = HeadingTowardsNegative(unit.x, finX);
                if (dirX)
                    newPos.x--;
                else newPos.x++;
                SpeedRemaining--;
            }
            if(finY != newPos.y)
            {
                bool dirY = HeadingTowardsNegative(unit.y, finY);
                if (dirY)
                    newPos.y--;
                else newPos.y++;
                SpeedRemaining--;
            }           
            gameObject.GetComponent<Transform>().position = newPos;
            yield return new WaitForSeconds(1/ animationSpeed);
        }
        moving = false;
    }

    private bool HeadingTowardsNegative(float s, float f)
    {
        float sign1 = Mathf.Sign(s);
        float sign2 = Mathf.Sign(f);
        if (sign1 < 0)
        {
            if (sign2 < 0)
            {
                if (s > f)
                    return true;
                return false;
            }
            return false;
        } else
        {
            if (sign2 > 0)
            {
                if (s < f)
                    return false;
                return true;
            }
            if (s > f)
                return true;
        }
        return false;
    }

    private float FindDestination(float pos)
    {
        float fin;
        if (pos < 0)
        {
            fin = (int)pos - 0.5f;
        }
        else
        {
            fin = (int)pos + 0.5f;
        }
        return fin;
    }

    IEnumerator MoveTileY(float unit, float finY)
    {
        Vector3 newPos = gameObject.GetComponent<Transform>().position;
        while (SpeedRemaining > 0 && finY != newPos.y)
        {
            moving = true;
            if (finished) break;
            bool dir = HeadingTowardsNegative(unit, finY);
            if (dir)
                newPos.y--;
            else newPos.y++;
            gameObject.GetComponent<Transform>().position = newPos;
            SpeedRemaining--;
            yield return new WaitForSeconds(1 / animationSpeed);
        }
        moving = false;
    }
}