## Carousel
콘텐츠가 돌아가면서 보이는 슬라이드 쇼    
배너 이미지를 보여줄 때 사용    
[Docs](https://getbootstrap.com/docs/5.0/components/carousel/)

**구분**
- 인디케이터 부분
- 이미지 부분
- 이동버튼 부분

```html
<!--인디케이터부분 : 현재 이미지를 표시하는 바 버튼 부분-->
<div id="carouselExampleIndicators" class="carousel slide" data-bs-ride="carousel">
  <div class="carousel-indicators">
    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1" aria-label="Slide 2"></button>
    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2" aria-label="Slide 3"></button>
  </div>
  <!--이미지 부분 : 어떤 이미지를 넣을지 이미지를 등록 부분-->
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="..." class="d-block w-100" alt="...">
        <!--캡션-->
	<div class="carousel-caption d-none d-md-block"> 
        <h5>First slide label</h5>
        <p>Some representative placeholder content for the first slide.</p>
      </div>
    </div>
    <div class="carousel-item">
      <img src="..." class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="..." class="d-block w-100" alt="...">
    </div>
  </div>
  <!--이동버튼 부분 : 이미지를 이동하는 좌우 버튼 부분-->
  <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Previous</span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Next</span>
  </button>
</div>

```

**indicator**

![1](https://user-images.githubusercontent.com/44824456/135979796-17782cf4-a6f5-430e-bc2e-80a44ff25c0e.png)

**caption**
![2](https://user-images.githubusercontent.com/44824456/135979814-00e35b92-e42c-4a60-8f9f-e074e749623d.png)
