using Assets.Calculator._07_Scripts.Controllers;
using Assets.Calculator._07_Scripts.Models;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public Panels GamePanels;
    public Buttons GameButtons;

    public ButtonController buttonController;
    public PanelController panelController;
    public Callback callback;

    private void Awake()
    {
        Initialize();   
    }

    void Start()
    {

    }

   
    void Update()
    {

    }

    private void OnEnable()
    {
        panelController?.Subscribe();
    }

    private void OnDisable()
    {
        panelController.Unsubscribe();
    }

    private void Initialize() 
    {
        buttonController = new ButtonController(GameButtons, callback);
        panelController = new PanelController(GamePanels, callback);
    }
}



