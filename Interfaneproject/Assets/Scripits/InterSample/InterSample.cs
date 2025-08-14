using UnityEngine;
/*
 인터페이스 ( interface ) 560p


 */

public interface IThrowable
{ 
}

public interface IWeapon
{
    
}

public interface ICountable
{ 
}

public interface Ipotion
{
    
}

public interface IUsable
{
    
}

public class Item
{

}

public class Sword :Item ,IWeapon //interface가 뒤
{ }

public class JabLin : Item,ICountable, IThrowable{ }

public class MaxPotion : Item, ICountable, IUsable, Ipotion { }

public class FirePotion : Item, ICountable, IThrowable, Ipotion { }
public class InterSample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
