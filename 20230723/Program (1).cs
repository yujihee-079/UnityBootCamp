﻿using System;

namespace MyApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            // float -> 실수형 데이터 형식
            // 3.14 2.5 ...

            float hp = 222.14366666f; // 약 6.92 7자리의 정밀도
                                      // 32비트는 사용하는데 
                                      // 1비트 - 부호부 
                                      // 8비트 - 지수부 . 위치
                                      // 23비트 - 가수부 실제 숫자푠현     

            // 234.666 <- 더블 형식의 값이구나
            // 234.666f <- 플롯 형식의 값이구나
            float f = 4444.444f; // 약 7자리의 정밀도
            double d = 13333.5555555555; // 약 15~16자리의 정밀도

            // string -> 문자열 데이터 형식
            // Console.WriteLine("안녕하셈");
            // unicode

            // char -> 문자 담는 데이터 형식
            // 'a', 'b'
            char c = 'a';

            // bool -> 참과 거짓을 담는 데이터 형식
            bool isAlive = false;

            // 캐스팅 -> 형식 변환 

            // 형식 변환의 종류
            // 명식적 형변환, 암시적 형변환 이라는게 있습니다.

            // 명시적 형변환 - "데이터 유실 위험 있음"
            int high = 222222222;
            short low = (short)high;

            // 암시적 형변환 - "데이터 유실 위험 없음"
            short low2 = 1;
            int high2 = low2;

            float high3 = high; // 200 //300.3 // 222222224 
                                //  "편의성 vs 안전성" 사이에서 타협을 했다고 합니다.
                                // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/numeric-conversions?utm_source=chatgpt.com
                                // "Conversions from int, uint, long or ulong to float … may cause a loss of precision, but never a loss of magnitude.” 


            // Parse

            // string -> int 스트링을 인트로 변환
            // ex)종족을 고르세요.
            // 1. 전사, 2. 마법사, 3. 도둑, 4. 마법소녀
            string name = Console.ReadLine(); // <- 4를 입력
                                              // int.Parse 안하면 4를 썻어도 int 인 4가 아님 문자열 "4" 가 저장됨
                                              // 저장된 데이터의 체계도 다름
                                              // int -> ... 0000 0100
                                              // string -> 8FA4 25FA
            int p = int.Parse(name); // <- 이때 "4" 가 4로 변환됨
            Console.WriteLine(p);

            // int -> string 정수를 스트링으로 변환
            // "+사과 {정수형 타입}개"
            // "+사과 {정수형 타입}개"
            // "+사과 {정수형 타입}개"
            // 자리 표시자 이용 방법
            int a = 1;
            int b = 99;
            string s = string.Format("엄마가 오이를 {0} ~ {0}개 사오라고 했는데 몇개지?", a, b);
            Console.WriteLine(s);

            // 스트링인터폴레이션 이용 방법 
            int worldCount = 15;
            string memo2 = $"어제 내 세상이 {worldCount}번 무너졌어";

            // 산술연산 -> 사칙연산 + 나머지
            // + - * / %
            // 곱셈이 + - 보다 우선순위 높음
            // () 안에 있는애가 더 높음
            int a = 10;
            a = a + 1;

            // 축약형(할당연산자)
            //int hp = 100;
            //int monsterAttack = 99;
            //hp = hp - monsterAttack;
            //hp *= monsterAttack;

            // 증감연산자
            int mp = 100;
            ++mp; // <- 101
            --mp; // <- 99
            // 증감연산자는 앞에 붙이는거랑 뒤에 붙이는거랑 차이가 있다.
            ++mp; // 전위 증감연산
            mp++; // 후위 증감연산

            //int hp = 100;
            //Console.WriteLine($"앞에 붙일게~ {++hp}");
            //Console.WriteLine($"뒤에 붙일게~ {hp++}");

            // 전위 증감연산 - 먼저계산하고 변수 전달
            // 후위 증감연산 - 변수 전달 먼자 하고 계산

            // 변수를 만들어서 데이터를 저장하고 그 데이터를 가공 까지 했어요.
            // 가공한 데이터가 조건에 맞는지? 확인함
            // hp 깎임 <- 산술 hp == 0?
            // 초등학교떄 배운거
            // < <= > >= == !=
            int hp = 100;
            int monsterAttack = 101;
            hp -= monsterAttack;
            bool isAlive = (hp > 0);
            Console.WriteLine(isAlive);

            /*
             Q.
10보다 5가 크다를 비교 연산으로 표현하면? 5 > 10

3은 1보다 작다를 비교 연산으로 표현하면? 3 < 1

7은 7과 같다를 비교 연산으로 표현하면? 7 == 7

9는 10과 같지 않다를 비교 연산으로 표현하면? 9 != 10
             
4는 4보다 크거나 같다를 비교 연산으로 표현하면? 4 >= 4

2는 1보다 작거나 같다를 비교 연산으로 표현하면? 2 <= 1

100은 100.0과 같다를 비교 연산으로 표현하면? 100 == 100.0

'B'는 'A'보다 크다를 비교 연산으로 표현하면? 'B' > 'A'

20은 5 곱하기 4보다 작다를 비교 연산으로 표현하면? 20 < 5 * 4

"cat"은 "Cat"과 같다를 비교 연산으로 표현하면? "cat" == "Cat"
             */

//ctrl + kc : 주석 할때 
//ctrl + ku : 주석 풀때

// 게임 아이템이 착용레벨이 50 이상 이고 힘 수치가 15 이상 일때 <- 다중조건
// &&논리곱AND ||논리합OR !논리부정NOT

// && (AND) : 두 조건이 모 두 만족(true)할때 참을 반환합니다.
//bool hasRequiredLevel = false;
//bool hasRequiredStr = true;

//bool isRequired = hasRequiredLevel && hasRequiredStr; // <- false 

// || (OR) : 두 조건중 하나라도 만족(true) 할때 참을 반환합니다. 
//bool hasRequiredLevel = true;
//bool hasRequiredStrength = false;
//bool isRequired = hasRequiredLevel || hasRequiredStrength; // <- true

// ! (NOT) : 논리연산 대상이 참이면 거짓, 거짓이면 참 반환
//bool isAlive = false;
////isAlive = true;
//isAlive = !isAlive;
//// 만약에 어떠한 조건이 참이면
//{
//    isAlive = !isAlive;
//}

/*
 * 아래 명제가 어떤 논리연산을 하는지 적어주세요(OR AND NOT)
1. 내 이상형은 키도 크고 몸도 좋은 사람이다. AND
2. 나는 주말에 영화 보거나 책을 읽는다. OR
3. 비행기를 타려면 여권이 있고 비자도 있어야 한다.AND
4. 공부를 안했으면 공부를 해야한다. NOT
5. 카드를 사용하려면 비밀번호를 알고 있어야 하고 카드가 유효해야 한다. AND
6. 회의에 참석하려면 정장을 입거나 깔끔한 비즈니스 캐주얼을 입으면 된다. OR
7. 불이 켜져있으면 꺼야한다. NOT
8. 친구가 바쁘면 영화관에 혼자 가거나 집에서 영화를 본다.OR
9. 건강을 유지하려면 규칙적으로 운동을 하고 균형 잡힌 식사를 해야 한다. AND
10. 여름 휴가는 바다로 가거나 산으로 간다. OR
*/
}

}
}