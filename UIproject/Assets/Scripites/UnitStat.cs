using System;
using UnityEngine;

public class UnitStat : MonoBehaviour
{
    //enum unitStat
    //{
    //    마법사,
    //    공격력

    //}

    //unitStat Unit()
    //{
    //      unitStat 마법사 = new unitStat();
    //    unitStat 공격력 = new unitStat();
    //    Console.WriteLine($"{마법사}");
    //    공격력 = (unitStat)10;


    //}
    // 문제점 unit()메서드가 값을 반환하지 않음. unitStat을 반환한다고 선언했지만, return문이 없다.
    // enum은 인스턴스를 선언할 수 없음. 왜냐하면 enum은 값 타입이며 인스턴스를 생성하지 않는다.
    //unitstat에 정의된 값이 마법사 = 0; 공격력 =1;인데 , 10은 정의되지 않았다.

    enum UnitType
    {
        마법사,
        전사
    }

    class Stat
    {
        public UnitType 타입 { get; set; }
        public int 공격력 { get; set; }
    }

    Stat Unit()
    {
        Stat unit = new Stat();
        unit.타입 = UnitType.마법사;
        unit.공격력 = 10;

        Console.WriteLine($"타입: {unit.타입}, 공격력: {unit.공격력}");

        return unit;
    }

}
