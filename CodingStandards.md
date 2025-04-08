# C# �ڵ� ���Ĵٵ�

## 1. ���� �� �޼ҵ� ���̹� ��Ģ

### ������ (Camel Case)
```csharp
int age = 22;
int userAge = 35;
bool isUserLoggedin = true;
```

### �޼ҵ�� (Pascal Case)
```csharp
void CheckInternetConnection()
{
    // ��Ʈ��ũ ���� �ڵ�
}
```

## 2. �ּ� �ۼ� ��Ģ

### ���� ���� �ּ�
```csharp
// ����� �α��� ���¸� Ȯ���ϴ� ����
bool isUserLoggedin = true;
```

### ���� ���� �ּ�
```csharp
/* �� �޼ҵ���� ����� �����͸� �����ϰ�
�����ͺ��̽��� �����ϴ� ������ ����մϴ� */
```

### XML ����ȭ �ּ�
```csharp
/// <summary>
/// �� �޼ҵ�� �ſ� ������ ����� �����մϴ�
/// </summary>
void CoolMethod()
{
    // ���� �ڵ�
}
```

## 3. ���̹� ������

### Ŭ���� (Pascal Case)
- Ŭ���� �̸��� �빮�ڷ� ����
- Ŭ������ ������ ��Ȯ�ϰ� ǥ��
```csharp
public class UserManager
{
}
```

### �޼ҵ� (Pascal Case)
- �޼ҵ� �̸��� �빮�ڷ� ����
- ���� ����� �̸� ���
```csharp
public void ValidateUserInput()
{
}
```

### ���� (Camel Case)
- ���� �̸��� �ҹ��ڷ� ����
- �����ϰ� �ǹ̰� ��Ȯ�ؾ� ��
```csharp
int userCount;
string firstName;
```

## 4. �ڵ� �ۼ� ��� ���

### 1. ��Ȯ�� (Clarity)
- �ڵ� ����� ������ ��Ȯ�ϰ� �����ϴ� �̸� ���

### 2. �ϰ��� (Consistency)
- �ڵ庣�̽� ��ü���� �ϰ��� ���̹� ��Ģ �ؼ�

### 3. ���� (Collaboration)
- �� �Ǵ� ȸ���� �ڵ� ǥ�� �ؼ�

### 4. ���������� (Maintainability)
- �������� ���� ���ɼ��� �켱��
- �ڵ� �������� ���̼� ��� 