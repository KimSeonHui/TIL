## 왜 CLI 방식을 해야 할까?

**GUI**

- 그래픽을 통해 제어
- 사용성을 높이기 위해 많은 에너지를 여기에 소모
- 동작하기 쉽다는 장점
- 하나의 일이 끝나는 걸 기다려야 다음 할 일을 명령 할 수 있음

#

**CLI**

- 그래픽이 없어 훨씬 더 적은 에너지를 사용해서 컴퓨터를 제어
- 따라서 서버 컴퓨터와 같이 헤비한 일을 하는 시스템에서는 CLI를 사용
- 하나의 일이 끝나는 걸 기다리지 않더라도 순차적으로 할 명령을 쭉 명시하면 할 일이 전부 끝난 후 결과를 반환

> 명령 하나에 2-3일 걸려 언제 끝날지 모르는 명령어라면?

- 결과를 보기 위해 계속 컴퓨터 앞에서 기다릴 수 있을까?

```sql
// 세상 오래 걸리는 두 개의 명령어라고 가정

// 1. 순차적 실행 
mkdir why  //끝나고 나야 다음 명령어 실행 가능
cd why
----------
//2. 순차적 실행 자동화
mkdir why; cd why  // 한 명령어가 끝나면 자동으로 다음 명령어 실행 후 결과 반환
```
순차적 실행을 자동화 할 수 있는 장점이 있기 때문에 CLI 사용!

#

### 파이프라인

하나의 명령을 실행 결과를 다른 것의 입력값으로 전달하는 것

`cat 파일명`

- 파일 내용 확인 명령어

`grep 검색하고싶은 텍스트 찾고자하는 파일`

- 특정한 정보에서 원하는 내용을 찾아주는 명령어

파이프 `|`

```sql
ls --help | grep sort
```

ls —help를 입력값으로 grep sort에 전달

- ls —help 명령어 중 sort를 포함한 것만 표시

![1](https://user-images.githubusercontent.com/44824456/133440194-9538a904-d14a-46d5-88ea-dbe24461f09d.png)

---

### 파일 다운 받기

명령어 시스템에서는 어떻게 다운을 받을까?

→ 파일을 다운받기 위한 프로그램이 필요

- wget

`wget 다운하고자 하는 url`

- 파일 다운로드

`wget -O 저장하려는 파일 이름 다운하고자 하는 url`

- 설정한 이름으로 파일 다운로드

---

## IO Redirection

![2](https://user-images.githubusercontent.com/44824456/133440283-3a263db3-7e73-499f-960e-64819484ecc9.png)

Unix Process에서는 1개의 Input, 2개의 Output 존재
**Output**
- standard Output : 실행되었을 때 결과 출력
- standard Error : 실행 중 에러가 발생했을 때 에러 출력
    - 에러를 별도의 출력으로 관리하기 때문

#

**Output**

화면으로 출력되는 것의 방향을 돌려서 다른 곳에 출력되게 하는 것

- ex) 화면으로 출력되는 것을 방향을 돌려 파일에 저장

    ![3](https://user-images.githubusercontent.com/44824456/133440520-1cd1f17f-6590-412f-a152-597a43c383a2.png))

    Unix process : `ls 명령어`

    command lline argument : `-l`

    standard output : 모니터에 출력

    output Redirection : 파일에 출력

    ```sql
    ls -l > result.txt // ls -l 결과를 result.txt 파일로 출력(저장)
    ```

출력이 2개이기 때문에 리다이렉션도 output과 error를 구분해야 함 

- `(1)>`  : standart ouput을 리다이렉션
- `2>` : error를 리다이렉션

```sql
ls -l 1> result.txt 2> error.log // ls -l 결과를 result.txt 파일로 출력(저장), 
																// 에러가 발생하면 error.log에 출력(저장)
```

#

**Input**

원래 입력 받는 방향을 돌려서 다른 방향에서 입력이 들어오게 하는 것

- ex) 사용자 입력을 받는 것을 방향을 돌려 파일에 있는 값을 입력값으로 준 것

    ![4](https://user-images.githubusercontent.com/44824456/133440569-f4797890-6c7b-4a68-9109-f71754e57bf2.png)

    Unix process : `cat 명령어`

    standard input : 사용자의 입력

    Input Redirection : 파일에 있는 내용을 입력

    ```sql
    cat < hello.txt // hello.txt 파일에 있는 내용을 입력값으로 전달
    ```

 #

**비교하면 좋을 것!**

![5](https://user-images.githubusercontent.com/44824456/133440592-e7abf766-f895-478f-901a-418b44ef2007.png)

Unix process : `cat 명령어`

command lline argument : `hello.txt`

standard input : 사용자의 입력

```sql
cat hello.txt // hello.txt 파일을 command lline argument로서 전달
```
 ~~command line argumnet로 처리가 가능하기 때문에 Input Redirection은 크게 사용될 일이 없음~~

---

## Shell & Kernel

![6](https://user-images.githubusercontent.com/44824456/133440634-e5fab283-3286-43a1-8870-9eb1f221b784.png)

**shell**       
사용자 명령어를 해석해서 커널이 이해할 수 있는 방식으로 커널에게 전달

**kernel**     
쉘로부터 받아서 하드웨어를 제어해서 명령을 처리할 수 있도록 함

> 커널과 쉘이 분리되어 있기 때문에 사용자가 자신에게 잘 맞는 쉘을 선택해서 사용할 수 있음
- 서로 다른 사용자가 서로 다른 쉘을 사용해서 커널에 접근할 수 있음

![7](https://user-images.githubusercontent.com/44824456/133440836-3906ec9c-f3d8-4f65-b2f5-9ec76bf4fbd6.png)

---

## Shell Script

특정 상황에서 사용되어야 하는 명령어들을 저장했다가 불러와서 사용할 수 있도록 하는 것

- 자동화해서 실행할 수 있음

`파일편집기 스크립트이름`      
 파일 편집기를 이용해 스크립트 작성 

`chmod +x backup`      
스크립트를 실행 가능하게 모드를 바꿈 

`./스크립트이름`      
스크립트 실행 

```sql
#!/bin/bash   // bin에 있는 bash로 프로그램을 실행하도록 알려줌

if ! [ -d bak ]; then
        mkdir bak
fi
cp *.log bak
```

---

## Directory structure

**Directory** : 데이터, 실행할 수 있는 프로그램을 정리정돈하는 수단

유닉스 계열에서 특정 프로그램은 정해져있는 이름의 디렉토리에 위치해야하는 규칙이 있음

![8](https://user-images.githubusercontent.com/44824456/133440922-52386e5e-0ca3-48ec-9199-e384f9a997fa.png)

1. **/ -Root**

1. **/bin -User Binaries**
    - Binaries : 실행 가능한 프로그램을 부르는 말이기도 함
    - 사용자가 사용하는 프로그램
        - ex) `pwd`, `nano`, `mkdir` ...

2. **/sbin -System Binaries**
    - 시스템 관리자가 사용하는 프로그램

3. **/etc - Configuration Files**
    - 설정을 변경할 수 있음
    - CLI이기 때문에 파일의 내용을 변경해서 어떻게 동작할지를 설정

4. **/var -Variable Files**
    - 내용이 고정되는 것이 아니라 바뀔 수 있는 파일이 있음
    - ex) log

5. **/tmp -Temporary Files**
    - 임시 파일이 저장되는 곳
    - 이곳에 저장된 파일은 껐다 키면 삭제됨

6. **/home -Home Directory**
    - 사용자의 파일들이 저장되는 디렉토리
    - 어디에 있든 /home으로 바로 갈 수 있는 명령어 :  `cd ~`

1. **/lib** **-System Library**
    - bin, sbin이 사용하는 라이브러리가 보관되는 곳

1. **/opt - Optional add-on Applications**
    - 특정 제품의 add-on 어플리케이션이 설치되는 곳
    - 경로를 지정해서 설치해야 하는 경우 어디에 설치해야 할지 모르겠다면 이곳에 해도 무방

2. **/usr -User Programs**
    - 설치하는 프로그램은 /usr/bin 또는 /usr/sbin에 저장
    - 기본적으로 번들로 제공되는 프로그램은 /bin, /sbin 쪽에 저장되어 있다고 생각하면 됨
----

### 참조

- [생활코딩- 리눅스](https://opentutorials.org/course/2598)
- [Linux Directory Structure](https://www.thegeekstuff.com/2010/09/linux-file-system-structure/)
