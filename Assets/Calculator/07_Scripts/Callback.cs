using System;

public class Callback
{
    //Buttons
    public static event Action OnOnePress;
    public static event Action OnTwoPress;
    public static event Action OnThreePress;
    public static event Action OnFourPress;
    public static event Action OnFivePress;
    public static event Action OnSixPress;
    public static event Action OnSevenPress;
    public static event Action OnEightPress;
    public static event Action OnNinePress;
    public static event Action OnZeroPress;
    public static event Action OnPlusPress;
    public static event Action OnMinusPress;
    public static event Action OnDividePress;
    public static event Action OnMultiplyPress;
    public static event Action OnClearPress;
    public static event Action OnEqualPress;

    //Panels
    public static event Action<bool> OnMainPanelActivation;
    public static event Action<bool> OnHistoryPanelActivation;

    //Game



    // Button Methods

    //Panel Methods
    public void MainPanelActivation(bool isActive) => 
        OnMainPanelActivation?.Invoke(isActive);

    public void HistoryPanelActivation(bool isActive)=>
        OnHistoryPanelActivation?.Invoke(isActive);

    // Game Methods

}
