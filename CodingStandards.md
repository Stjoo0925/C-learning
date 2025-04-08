# C# 코딩 스탠다드

## 1. 변수 및 메소드 네이밍 규칙

### 변수명 (Camel Case)
```csharp
int age = 22;
int userAge = 35;
bool isUserLoggedin = true;
```

### 메소드명 (Pascal Case)
```csharp
void CheckInternetConnection()
{
    // 네트워크 관련 코드
}
```

## 2. 주석 작성 규칙

### 단일 라인 주석
```csharp
// 사용자 로그인 상태를 확인하는 변수
bool isUserLoggedin = true;
```

### 다중 라인 주석
```csharp
/* 이 메소드들은 사용자 데이터를 저장하고
데이터베이스에 연결하는 역할을 담당합니다 */
```

### XML 문서화 주석
```csharp
/// <summary>
/// 이 메소드는 매우 유용한 기능을 수행합니다
/// </summary>
void CoolMethod()
{
    // 구현 코드
}
```

## 3. 네이밍 컨벤션

### 클래스 (Pascal Case)
- 클래스 이름은 대문자로 시작
- 클래스의 목적을 명확하게 표현
```csharp
public class UserManager
{
}
```

### 메소드 (Pascal Case)
- 메소드 이름은 대문자로 시작
- 동사 기반의 이름 사용
```csharp
public void ValidateUserInput()
{
}
```

### 변수 (Camel Case)
- 변수 이름은 소문자로 시작
- 간결하고 의미가 명확해야 함
```csharp
int userCount;
string firstName;
```

## 4. 코드 작성 모범 사례

### 1. 명확성 (Clarity)
- 코드 요소의 목적을 명확하게 전달하는 이름 사용

### 2. 일관성 (Consistency)
- 코드베이스 전체에서 일관된 네이밍 규칙 준수

### 3. 협업 (Collaboration)
- 팀 또는 회사의 코딩 표준 준수

### 4. 유지보수성 (Maintainability)
- 가독성과 이해 가능성을 우선시
- 코드 유지보수 용이성 고려 