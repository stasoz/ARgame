using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{
    private float health = 4;
    private float maxHealth = 4;
    public Slider healthBar;
    public GameObject restart;
    public GameObject menu;
    public Text score;
    private void Start()
    {
        healthBar.value = CalculateHealth();
        restart.SetActive(false);
        menu.SetActive(false);
        ShowScore();
    }
    void Update()
    {
        transform.Rotate(new Vector3(45, 90, 45) * Time.deltaTime);
        CheckOnDie();
        healthBar.value = CalculateHealth();
        ShowScore();
    }
    void CheckOnDie()
    {
        if (health <= 0)
        {
            SpawnObject.exit = true;
            Destroy(gameObject);
            restart.SetActive(true);
            menu.SetActive(true);
        }
    }
    float CalculateHealth()
    {
        return health / maxHealth;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "cockroach")
        {
            health -= 1;
        }
    }
    void ShowScore()
    {
        score.text = "All kils " + MainBehaviour.count.ToString();
    }
}
