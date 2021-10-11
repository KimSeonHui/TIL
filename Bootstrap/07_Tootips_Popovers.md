## Tooltip

- 태그의 title 속성에 css 적용할 수 있음
- 마우스를 올렸을 때 나타남
- jQuery 코드를 통해 tooltip 요소로 만들어줌

[Docs](https://getbootstrap.com/docs/5.0/components/tooltips/)

#

```html
<script>
//방법 1. data-bs-toggle로 모든 tooltip을 등록
	var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'))
	var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
	  return new bootstrap.Tooltip(tooltipTriggerEl)
	})

//방법 2. id를 부여해 각각 tooltip에 등록
$(function() {
	$('#a1, #a2, #a3, #a4, $a5').tooltip()
})
</script>

<button type="button" class="btn btn-secondary" data-bs-toggle="tooltip" data-bs-placement="top" title="Tooltip on top" id="a1">
  Tooltip on top
</button>
<button type="button" class="btn btn-secondary" data-bs-toggle="tooltip" data-bs-placement="right" title="Tooltip on right" id="a2">
  Tooltip on right
</button>
<button type="button" class="btn btn-secondary" data-bs-toggle="tooltip" data-bs-placement="bottom" title="Tooltip on bottom" id="a3">
  Tooltip on bottom
</button>
<button type="button" class="btn btn-secondary" data-bs-toggle="tooltip" data-bs-placement="left" title="Tooltip on left" id="a4">
  Tooltip on left
</button>
<button type="button" class="btn btn-secondary" data-bs-toggle="tooltip" data-bs-html="true" title="<em>Tooltip</em> <u>with</u> <b>HTML</b>"
	id="a5">
  Tooltip with HTML
</button>
```

![image](https://user-images.githubusercontent.com/44824456/135981816-3a9884bb-53b3-4e1f-b7f2-e508b45b420f.png)
![image](https://user-images.githubusercontent.com/44824456/135981853-4409c067-4858-4394-9e68-80f385045b09.png)

-----
## Popover
- 제목과 본문을 가지고 있는 말풍선을 띄울 수 있음
- 도움말 띄울 때 많이 사용

[Docs](https://getbootstrap.com/docs/5.0/components/popovers/)

**클릭했을 때 생성**

![image](https://user-images.githubusercontent.com/44824456/135982052-f1c24f69-df1f-49a6-b79e-8c4135866aaf.png)

#

```html
<script>
//방법 1. data-bs-toggle로 모든 popover을 등록
	var popoverTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="popover"]'))
	var popoverList = popoverTriggerList.map(function (popoverTriggerEl) {
	  return new bootstrap.Popover(popoverTriggerEl)
	})

//방법 2. id를 부여해 각각 popover에 등록
$(function() {
	$('#a1').popover()
})
</script>
	

<button type="button" class="btn btn-lg btn-danger" data-bs-toggle="popover" title="Popover title" data-bs-content="And here's some amazing content. It's very engaging. Right?" id="a1">
	Click to toggle popover
</button>
```

#

**외부를 클릭했을 때 사라지는 popover**

```html
<a tabindex="0" class="btn btn-lg btn-danger" role="button" data-bs-toggle="popover" data-bs-trigger="focus" title="Dismissible popover" data-bs-content="And here's some amazing content. It's very engaging. Right?">Dismissible popover</a>
```

focus가 주어졌을 때는 계속 보여지고 focus가 사라졌을 때는 사라짐
- 외부를 클릭하면 foucs가 사라지면서 popover가 사라지는 것 같은 효과가 나타남

#

**마우스 hover에 따라 사라지는 popover**

```html
<span class="d-inline-block" tabindex="0" data-bs-toggle="popover" data-bs-trigger="hover" data-bs-content="Disabled popover">
  <button class="btn btn-primary" type="button" disabled>Disabled button</button>
</span>
```

#

**JS로 popover 조작하기**

```jsx
<script>
	fucntion showAll() {
		$('#a1').popover("show")   // popover 보여주기
	}

	fucntion hideAll() {
		$('#a1').popover("hide")  // popover 숨기기
	}

	fucntion showToggle() {
		$('#a1').popover("toggle") // popover 상태에 따른 반전
	}
</scirpt>
```
