## Summernote

오픈소스 이지윅 에디터로 코드를 작성하는 대신 간편하게 실제 페이지 레이아웃과 유사한 형식으로 웹페이지를 작성할 수 있는 HTML 편집기의 한 종류

- JS와 부트스트랩을 사용해 쉽게 웹 에디터 페이지를 구현할 수 있음  
- [Docs](https://summernote.org/)  
    
![7](https://user-images.githubusercontent.com/44824456/134843087-21488f0d-ae6e-429d-9188-2fa724e43c51.png)

#

### 부트스트랩 없이 사용하기

```html
<head>
    <!--summernote를 위한 Bootstrap, js, summernote import-->
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <link href="https://cdn.jsdelivr.net/npm/summernote@0.8.18/dist/summernote-lite.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/summernote@0.8.18/dist/summernote-lite.min.js"></script>
</head>

<body>
	...
			    $(document).ready(function() {
                            $('#summernote').summernote({  //bootstrap없이 툴바 사용할 수 있게 해줌
                                placeholder: 'Hello stand alone ui',
                                tabsize: 2,
                                height: 300,                             
                                toolbar: [
                                ['style', ['style']],
                                ['font', ['bold', 'underline', 'clear']],
                                ['color', ['color']],
                                ['para', ['ul', 'ol', 'paragraph']],
                                ['table', ['table']],
                                ['insert', ['link', 'picture', 'video']],
                                ['view', ['fullscreen', 'codeview', 'help']]
                                ]
                            });
                        });
                    </script>

                    <p id="summernote">본문을 입력해 주세요</p>
</body>
```

**부트스트랩 없이 적용한 이유!**

- 부트스트랩은 5.1.1 버전으로 CSS를 적용
- summernote 쓰려면 부트스트랩 3.4.1 버전 사용해야 되서 만들어 놓은 디자인이 안 맞게 되는 상황..
- 이 때 부트스트랩 없이 summernote를 사용하고 부트스트랩은 따로 원래 사용하던 걸 head에 명시하면 디자인과 summernote를 동시에 사용이 가능
