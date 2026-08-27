using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField]
    private float GameTime;

    [SerializeField]
    private TMP_Text timerText;

    public bool isPlaying;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isPlaying = true;
    }

    // Update is called once per frame
    void Update()
    {
        //while(isPlaying)
        if(GameTime > 0) 
        {
            GameTime -= Time.deltaTime;
            int min = (int)GameTime / 60;
            int seg = (int)GameTime % 60;
            timerText.text =min.ToString("00") + ":"+ seg.ToString("00"); 
        }
        if(GameTime <= 0)
        {
            isPlaying=false;
        }
    }
}
