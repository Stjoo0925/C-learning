# C# 데이터 타입 가이드

## 1. 값 타입 (Value Types)

### 정수형
```csharp
byte b = 255;           // 범위: 0 ~ 255
sbyte sb = -128;        // 범위: -128 ~ 127
short s = 32767;        // 범위: -32,768 ~ 32,767
ushort us = 65535;      // 범위: 0 ~ 65,535
int a = 10;            // 범위: -2,147,483,648 ~ 2,147,483,647
uint ui = 4294967295;   // 범위: 0 ~ 4,294,967,295
long l = 9223372036854775807;    // 범위: -2^63 ~ 2^63-1
ulong ul = 18446744073709551615; // 범위: 0 ~ 2^64-1
```

### 실수형
```csharp
float pi = 3.1415f;     // 7자리 정밀도
double d = 3.141592653589; // 15-17자리 정밀도
decimal m = 3.1415926535897932384m; // 28-29자리 정밀도
```

### 논리형
```csharp
bool isGPSEnabled = true;
bool isConnected = false;
```

### 문자형
```csharp
char at = '@';          // 단일 문자
char grade = 'A';
```

## 2. 참조 타입 (Reference Types)

### 문자열
```csharp
string myName = "Denis";
string message = "Hello, World!";
```

### 객체
```csharp
object obj = new object();
```

### 동적 타입
```csharp
dynamic dynamicVar = 100;
```

## 3. 특수 타입

### Nullable 타입
```csharp
int? nullableInt = null;
bool? nullableBool = null;
```

## 4. 사용자 정의 타입

### 클래스, 구조체, 인터페이스
```csharp
class MyClass { }
struct MyStruct { }
interface IMyInterface { }
```

### 대리자
```csharp
delegate void MyDelegate(string message);
```

## 주요 특징
- 값 타입: 스택 메모리에 직접 저장
- 참조 타입: 힙 메모리에 저장되고 스택에는 참조만 저장
- Nullable 타입: 값 타입에 null 할당 가능
- 사용자 정의 타입: 개발자가 직접 정의하는 타입 