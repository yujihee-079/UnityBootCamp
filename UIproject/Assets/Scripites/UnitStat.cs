using System;
using UnityEngine;

public class UnitStat : MonoBehaviour
{
    //enum unitStat
    //{
    //    ������,
    //    ���ݷ�

    //}

    //unitStat Unit()
    //{
    //      unitStat ������ = new unitStat();
    //    unitStat ���ݷ� = new unitStat();
    //    Console.WriteLine($"{������}");
    //    ���ݷ� = (unitStat)10;


    //}
    // ������ unit()�޼��尡 ���� ��ȯ���� ����. unitStat�� ��ȯ�Ѵٰ� ����������, return���� ����.
    // enum�� �ν��Ͻ��� ������ �� ����. �ֳ��ϸ� enum�� �� Ÿ���̸� �ν��Ͻ��� �������� �ʴ´�.
    //unitstat�� ���ǵ� ���� ������ = 0; ���ݷ� =1;�ε� , 10�� ���ǵ��� �ʾҴ�.

    enum UnitType
    {
        ������,
        ����
    }

    class Stat
    {
        public UnitType Ÿ�� { get; set; }
        public int ���ݷ� { get; set; }
    }

    Stat Unit()
    {
        Stat unit = new Stat();
        unit.Ÿ�� = UnitType.������;
        unit.���ݷ� = 10;

        Console.WriteLine($"Ÿ��: {unit.Ÿ��}, ���ݷ�: {unit.���ݷ�}");

        return unit;
    }

}
