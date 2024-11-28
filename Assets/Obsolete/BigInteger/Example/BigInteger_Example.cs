using UnityEngine;

public class BigInteger_Example : MonoBehaviour
{
    void Start()
    {
        BigInteger a = new BigInteger(25);
        BigInteger b = new BigInteger("139435810094598308945890230913");
        BigInteger c = b / a;
        BigInteger d = b % a;
        BigInteger e = (c * a) + d;

        print(c);
        print(d);
        print(e);

        if (e != b)
        {
            print("Can never be true.");
        }
    }
}