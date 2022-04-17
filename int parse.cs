public class uc : MonoBehaviour
{
    public InputField firstnamein;
    public InputField lastnamein;
    public InputField agein;

    string deger1;
    string deger2;
    int deger3;


    void Start()
    {
        
    }

  
  public void ButtonClick()
    {
        deger1 = firstnamein.text;
        deger2 = lastnamein.text;
        deger3 = int.Parse(agein.text); //girilen değeri int e çeviriyoruz ve bu değerle matematiksel işlem yapabiliriz.
        Debug.Log(deger1);
        Debug.Log(deger2);
        Debug.Log(deger3);
    }


}
