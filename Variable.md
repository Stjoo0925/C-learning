# C# ������ Ÿ�� ���̵�

## 1. �� Ÿ�� (Value Types)

### ������
```csharp
byte b = 255;           // ����: 0 ~ 255
sbyte sb = -128;        // ����: -128 ~ 127
short s = 32767;        // ����: -32,768 ~ 32,767
ushort us = 65535;      // ����: 0 ~ 65,535
int a = 10;            // ����: -2,147,483,648 ~ 2,147,483,647
uint ui = 4294967295;   // ����: 0 ~ 4,294,967,295
long l = 9223372036854775807;    // ����: -2^63 ~ 2^63-1
ulong ul = 18446744073709551615; // ����: 0 ~ 2^64-1
```

### �Ǽ���
```csharp
float pi = 3.1415f;     // 7�ڸ� ���е�
double d = 3.141592653589; // 15-17�ڸ� ���е�
decimal m = 3.1415926535897932384m; // 28-29�ڸ� ���е�
```

### ����
```csharp
bool isGPSEnabled = true;
bool isConnected = false;
```

### ������
```csharp
char at = '@';          // ���� ����
char grade = 'A';
```

## 2. ���� Ÿ�� (Reference Types)

### ���ڿ�
```csharp
string myName = "Denis";
string message = "Hello, World!";
```

### ��ü
```csharp
object obj = new object();
```

### ���� Ÿ��
```csharp
dynamic dynamicVar = 100;
```

## 3. Ư�� Ÿ��

### Nullable Ÿ��
```csharp
int? nullableInt = null;
bool? nullableBool = null;
```

## 4. ����� ���� Ÿ��

### Ŭ����, ����ü, �������̽�
```csharp
class MyClass { }
struct MyStruct { }
interface IMyInterface { }
```

### �븮��
```csharp
delegate void MyDelegate(string message);
```

## �ֿ� Ư¡
- �� Ÿ��: ���� �޸𸮿� ���� ����
- ���� Ÿ��: �� �޸𸮿� ����ǰ� ���ÿ��� ������ ����
- Nullable Ÿ��: �� Ÿ�Կ� null �Ҵ� ����
- ����� ���� Ÿ��: �����ڰ� ���� �����ϴ� Ÿ�� 