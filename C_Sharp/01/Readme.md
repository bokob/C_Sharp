### C# 버전    
C#은 .NET Framework 버전 및 Visual Studio 버전과 밀접한 관련  
![image](https://github.com/bokob/C_Sharp/assets/85085804/37d2cac2-a3a0-472b-a2a5-a661dce5f350)

- Visual Studio 2010은 .NET 4.0 뿐만 아니라 .NET 2.0, .NET 3.0, .NET 3.5도 지원한다.  
- Visual Studio 2008은 .NET 3.5 뿐만 아니라 .NET 2.0, .NET 3.0도 지원한다.  
- C# 7.1, C# 7.2, C# 7.3은 Minor 버전으로 자동으로 Enable되지 않으며, VS에서 C# 프로젝트 속성창 => Build 탭 => Advanced 버튼 => Language Version 콤보박스에서 해당 버전을 선택해야 한다.  
- C# 8.0을 사용하기 위해서는 VS 2019를 Update 16.3 이상으로 업데이트하고 .NET Core 3.0 을 설치한 후 사용한다. C# 8.0은 .NET Framework 4.8에서 사용할 수 없다.  
- C# 10을 사용하기 위해서는 VS 2022/.NET 6를 설치한다. C# 10은 .NET 6에 포함되어 있다.  
- C# 11을 사용하기 위해서는 VS 2022 Update 17.4 이상과 .NET 7을 설치한다. C# 11은 .NET 7에 포함되어 있다.  

### C# 버전별 주요 기능  
![image](https://github.com/bokob/C_Sharp/assets/85085804/f31794c4-223c-49ed-ab01-80fadf31ee36)
![image](https://github.com/bokob/C_Sharp/assets/85085804/ab319132-0f1b-4f51-8243-a44a302d8198)
![image](https://github.com/bokob/C_Sharp/assets/85085804/0c247a6e-f258-49d7-9986-93a37e0deba6)  

### C# 데이터 타입
- C#을 포함한 모든 .NET 프로그래밍 언어는 .NET의 Common Type System에 정의된 .NET 데이 타입을 사용  
- C#은 int, double, string 과 같은 C# 키워드로 데이터 타입을 표현할 수 있다.
- 또한 System.Int32, System.Double, System.String 과 같은 .NET 데이터 클래스로 데이터 타입을 표현할 수도 있다.
- 내부적으로 C# 컴파일러는 C# 키워드로 된 데이터 타입을 컴파일 후 .NET 데이 타입으로 변경하게 된다.
![image](https://github.com/bokob/C_Sharp/assets/85085804/b75f539d-772a-49a1-ad83-9c1b5673ec0e)

### C# 리터럴 데이터  
- C# 코드에서 123, true, "ABC"와 같이 값을 직접 써줄 수 있는데, 이를 리터럴(Literal)이라 한다.  
- C#에서 리터럴 데이타를 사용할 때, 별도의 접미어 표시(Suffix)가 없는 경우 C# 컴파일러는 int, double, char, string, bool 데이타 타입에 기본적으로 그 값을 할당한다.  
- 특정 데이터 타입을 지정하고 싶으면, 리터럴 데이터 뒤에 1~2자의 타입 지정 접미어(Suffix)를 추가해야 한다. Suffix는 대소문자 구분이 없다.  
![image](https://github.com/bokob/C_Sharp/assets/85085804/637d4c0a-be3b-459f-b01a-9a32ee2a6e97)


### 최대값, 최소값  
- 숫자형 데이타 타입의 최대값 혹은 최소값을 알아내기 위해서는 .NET 데이타 타입 클래스들의 MaxValue, MinValue 프로퍼티를 사용  
```C#
int i = int.MaxValue;
float f = float.MinValue;
```  

### NULL  
- 어떤 변수가 메모리 상에 어떤 데이타도 가지고 있지 않다는 의미로서 NULL을 사용
- NULL을 표현하기 위하여 C# 에서는 소문자 null 키워드를 사용  
- 모든 데이터 타입이 NULL을 가질 수 있는 것은 아니다.  
- NULL을 가질 수 있는 타입(Refernec 타입), 가질 수 없는 타입(Value 타입)으로 구분할 수 있다.  

### Nullable Type  
- 정수(int)나 날짜(DateTime)와 같은 Value Type은 일반적으로 NULL을 가질 수 없다. 
- C# 2.0에서부터 이러한 타입들에 NULL을 가질 수 있게 하였는데, 이를 Nullable Type 이라 부른다.  
- C#에서 물음표(?)를 int나 DateTime 타입명 뒤에 붙이면 즉, int? 혹은 DateTime? 같이 하면 Nullable Type이 된다.  
- 이는 컴파일하면 .NET의 Nullable<T> 타입으로 변환된다.  
- Nullable Type (예: int?) 을 일반 Value Type (예: int)으로 변경하기 위해서는 Nullable의 .Value 속성을 사용한다.
