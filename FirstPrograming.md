# 🧑‍💻 C# 첫 번째 프로그램 구성 요소 설명

```csharp
using System;

namespace HelloWorld {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }
    }
}
```

---

### 🔹 `using System;`
**→ .NET 프레임워크 네임스페이스 참조**

이 라인은 컴파일러에게 `System` 네임스페이스를 사용하고 있음을 알려줍니다.  
이 네임스페이스는 **입출력과 같은 기본 동작에 필요한 클래스들**을 포함하고 있으며, `Console` 클래스도 여기에 속합니다.

---

### 🔹 `namespace HelloWorld {`
**→ 네임스페이스 이름**

네임스페이스는 **코드를 조직화하고 이름 충돌을 방지**하기 위해 사용됩니다.  
여기서 `HelloWorld`는 프로그램의 논리를 캡슐화하는 네임스페이스입니다.

---

### 🔹 `class Program {`
**→ 클래스 이름**

`Program`이라는 클래스를 정의합니다.  
C#에서는 **모든 실행 가능한 코드가 클래스 내에 있어야 하며**, `Program`은 메인 클래스로 자주 사용되는 이름입니다.

---

### 🔹 `static void Main(string[] args) {`
**→ 메서드 (Main 메서드)**

이 코드는 C# 콘솔 애플리케이션의 **메인 진입점**입니다.

- `static`: 인스턴스를 생성하지 않고 실행 가능함을 의미  
- `void`: 반환값이 없음을 의미  
- `string[] args`: 프로그램 실행 시 전달되는 **명령줄 인자 배열**

---

### 🔹 `Console.WriteLine("Hello World!");`
**→ 콘솔에 값 출력하는 메서드**

문자열 `"Hello World!"`를 **콘솔 창에 출력**합니다.  
`WriteLine` 메서드는 출력 후 **자동 줄바꿈**을 추가합니다.

---

### 🔹 `{ } 코드 블록`
**→ 코드 블록**

`Main` 메서드에 이어지는 중괄호 `{ }`는  
**프로그램이 실행될 때 수행할 문장들**을 포함합니다.
