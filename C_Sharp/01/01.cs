// 디폴트 리터럴 타입
123 // int 리터럴
12.3 // double 리터럴
"A" // string 리터럴
'a' // char 리터럴
true // bool 리터럴

// C# 데이터 타입 예제
// Bool
bool b = true;

// Numeric
short sh = -32768;
int i = 2147483647;
long l = 1234L;     // L Suffix
float f = 123.45F;  // F Suffix
double d1 = 123.45;
double d2 = 123.45D;
decimal d = 123.45M;

// Char / String
char c = 'A';
string s = "Hello";

// DateTime 2011-10-30 12:35
DateTime dt = new DateTime(2011, 10, 30, 12, 35, 0);

int i = int.MaxValue;
float f = float.MinValue;

int? i = null;
i = 101;

Nullable<int> j = null;
j = 10;
int k = j.Value;

