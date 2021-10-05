## Modal

평소에는 보이지 않다가 사용자에 의해 다얼로그로 나타나는 영역     
div를 Modal로 만들어 사용할 수 있도록 지원됨

**주요 클래스**

`modal` : 지정된 영역을 Modal 요소로 만들어줌

`modal-content` : Modal 내부 영역 지정

`modal-header` : Modal의 제목 부분

`modal-body` : Modal 내용 부분

`modal-footer` : Modal 푸터 부분

[Docs](https://getbootstrap.com/docs/5.0/components/modal/)

#

```html
<!-- Button trigger modal -->
<button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal">
  Launch demo modal
</button>
<button type="button" class="btn btn-info btn-lg" onclick="showModal()">Open Modal in js</button>

<!--js로 modal 처리하기-->
<script>
	function showModal() {
		$('#exampleModal').modal("show")  //modal 띄우기
		$('#exampleModal').modal("hide")   //modal 사라지게
		$('#exampleModal').modal("toggle")  //modal 상태에 따라 띄우고 없어지게 함
</script>		

<!-- Modal -->
<div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel">Modal title</h5>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
      </div>
      <div class="modal-body">
        ...
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary">Save changes</button>
      </div>
    </div>
  </div>
</div>

```

![3](https://user-images.githubusercontent.com/44824456/135980617-f60c620c-7eed-4628-8a2b-b4bb63004078.png)

