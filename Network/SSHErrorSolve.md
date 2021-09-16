## Host와 VirtualBox(Ubuntu) SSH
### SSH 연결
1. 가상머신 네트워크 설정
2. 윈도우 cmd에서 ssh로 가상머신에 로그인
    `ssh 사용자이름@서버ip`
3. host에서 연결 확인 `ping 서버ip`
   서버에서 연결 확인 `ping host ip`

#
   
### VSCode로 SFTP 설정
1. vscode의 sftp install 후 연결
    - 빈 폴더 생성 후 F1 누름     
      검색에 SFTP:config 클릭     
      sftp.json 설정
    
2. **ssh를 root계정으로 접속할 경우 가상머신의 ssh root로그인을 허용해야함**
    - ssh는 기본적으로 root로 로그인하는 것을 막아둠
        - 이거 몰라서.. root로 로그인하면 `all configured authentication methods failed` 뜨고... 그렇다고 sunny로 로그인하면 `Permission denined` 떠서.. 진짜 너무.. 속으로 눈물 한바가지 흘렸다...😭😭😭😭😭
        - 정말.. 도저히 안돼서 winSCP도 해보고..(같은 문제 발생)... 도저히 안되서 포기하고 putty까지 깔았다가... 소장님 도움으로 해결함..
    - 그래서 파일편집기에서 ssh 설정에 있는 root계정 로그인을 허용해야함

        ![Untitled](https://user-images.githubusercontent.com/44824456/133613150-6d154293-6f29-46a1-b980-47d3f5ee2ce5.png)

        파일 `경로 : /etc/ssh/sshd_config`
