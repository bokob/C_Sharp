### C# 프로그래밍 언어  
C#은 마이크로소프트에서 개발된 객체 지향 프로그래밍 언어  
- Java 나 C++와 비슷한 면들을 많이 가지고 있다.  
- .NET Framework을 이용하여 프로그래밍하는 대표적인 언어  
- 윈도우 프로그래밍, 웹 프로그래밍, 게임 및 모바일 프로그래밍 등 모든 영역에서 사용되는 범용 프로그래밍 언어  

### C# 프로그램 소스코드  
- C# 프로그램은 .cs 라는 확장자를 사용  
- C++와 다르게 C#은 *.h과 같은 별도의 헤더 파일이 없다.

C# 프로그램으로부터 실행 파일을 만들기 위해서는
-  (1) Visual Studio를 사용하는 경우 C# 프로젝트를 빌드하여 실행파일을 생성하며 
-  (2) Visual Studio 없이 .NET Framework에서 제공되는 C# 컴파일러인 csc.exe를 이용하여 실행파일을 생성할 수 있다.
  
```C#
namespace Intro_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World...");
        }
    }
}
```
- 모든 C# 프로그램은 Main()이라는 시작 함수(메서드)를 가져야 한다. 
- Main() 메소드는 임의의 클래스 안에서 존재하며, 프로그램 상에 단 1개만 있어야 한다.
- Main()는 static으로 선언되며, 메소드 인자는 string[] 문자열
- System.Console은 .NET Framework 클래스이며, WriteLine은 화면에 데이타를 Console클래스의 출력하는 메서드  

### C# 코멘트  
```C#
namespace Intro_Ex2
{    
    class Program
    {
        static void Main(string[] args)
        {
            // 코멘트: 한 라인 코멘트는 두개의 슬래시 사용함       
            int a = 1;


            int b = 1;  // 코멘트: 하나의 문장 뒤에 코멘트를 달 수 있음

            /*
               복수 라인에 대한 코멘트
               int c;
               int d; 
            */
        }
    }
}
```
