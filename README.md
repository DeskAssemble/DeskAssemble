# 가구 제작 및 판매 관리 시스템

## 개요

가구공장의 부품과, 완제품의 정보와 입고, 출고, 주문 내역등을 조회할 수 있고 조회한 데이터를 이용한 차트를 Devexpress, C#.NET Framework 및 EntityFramework를 이용해 구현하였다.

## 개발기간

2020년 12월 28일 ~ 2021년 1월 13일 (약 2주)

## 개발 환경

### 언어
- C# 8.0, C++

### 프레임워크
- .Net Framework 4.8
- EntityFramework 6.2
- Winform

### 데이터베이스
- MSSQL Server 2019

### 하드웨어
- Arduino Mega 2560, RFID RC522 Module

### 기타 개발환경
- Windows 10
- Microsoft Visual Studio Community 2019 v 16.8
- Microsoft SQL Server Management Studio v18.6
- Arduino IDE 1.8.13

## DB 스키마

![DB스키마](https://user-images.githubusercontent.com/74530618/103977728-341e4580-51bd-11eb-8fed-d8ee1c97a77a.jpg)

## RFID 등록 화면

 아두이노 RFID모듈에 제품을 스캔하고 입/출고할 창고와 수량을 입력후 DB에서 제품 등록 및 수량 업데이트
 
![RFID](https://user-images.githubusercontent.com/74530618/103982623-2bcb0800-51c7-11eb-8d4e-8bc1f7e16561.jpg)

## 메인 관리 화면 목록
### 1. 실행화면

 RibbonControl과 MdiManager를 사용해 버튼을 클릭했을 때 원하는 창을 불러오도록 설정

![메인폼](https://user-images.githubusercontent.com/74530618/103977959-b6a70500-51bd-11eb-9786-a0cb8080b28e.jpg)

### 2. 주문 리스트

 데이터의 Order 테이블에서 입고해야할 필요 부품의 발주정보와 출고해야할 완제품을 주문받은 정보를 GridControl로 출력

![주문 리스트](https://user-images.githubusercontent.com/74530618/103978478-e0acf700-51be-11eb-8f24-d756ce2c8980.jpg)

### 3. 창고 리스트

 - 데이터의 WareHouse 테이블에서 창고에대한 정보를 GridControl로 출력
 - 데이터의 Movement 테이블에서 입고된 수량과 출고된 수량을 계산해 창고별 제품의 수량을 PivotGridControl로 출력

![창고 리스트](https://user-images.githubusercontent.com/74530618/103978628-31bceb00-51bf-11eb-8717-012189371c5e.jpg)

### 4. 입출고 리스트

 아두이노 RFID 테그를 통해 쌓인 Movement 테이블의 데이터에서 창고에 제품과 부품이 입출고된 수량을 날짜별로 출력
 
 ![입출고 리스트](https://user-images.githubusercontent.com/74530618/103978984-156d7e00-51c0-11eb-89df-0e200906595a.jpg)

### 5. 부품 구매비율

 데이터의 Order 테이블에서 발주한 부품의 비율을 부품별 PieChart로 출력
  
![부품 구매비율](https://user-images.githubusercontent.com/74530618/103979251-c3792800-51c0-11eb-8df6-d67037388be1.jpg)

#### - 부품 상세 구매비율

 차트의 파이조각을 클릭했을 때 부품의 상세비율을 PieChart로 출력
 
 ![부품 상세 구매비율](https://user-images.githubusercontent.com/74530618/103979541-55813080-51c1-11eb-906b-82f362f776af.jpg)

### 6. 제품 판매비율

 데이터의 Order 테이블에서 주문받은 제품의 비율을 제품별 PieChart로 출력
 
 ![제품 판매비율](https://user-images.githubusercontent.com/74530618/103979732-c4f72000-51c1-11eb-99b4-edf53d7176e4.jpg)

#### - 제품 상세 판매비율

 차트의 파이조각을 클릭했을 때 제품의 상세비율을 BarChart로 출력
 
 ![제품 상세 판매비율](https://user-images.githubusercontent.com/74530618/103980879-0ee10580-51c4-11eb-901e-cd60c995216a.jpg)

### 7. 국가별 부품 구매비율

- 데이터의 Order 테이블에서 부품을 발주한 회사의 국가별로 지도에 BubbleChart를 출력
- Bubble의 크기별로 구매 비율을 출력

![국가별 부품 구매비율](https://user-images.githubusercontent.com/74530618/103980334-0936f000-51c3-11eb-84cd-db0a1f64501e.jpg)

### 8. 국가별 제품 판매비율

 - 데이터의 Order 테이블에서 제품을 주문한 회사의 국가별로 지도에 BubbleChart를 출력
 - Bubble의 크기별로 판매 비율을 출력

![국가별 제품 판매비율](https://user-images.githubusercontent.com/74530618/103980491-54e99980-51c3-11eb-93b8-ebb704e0877a.jpg)

### 9. 분기별 매출

 데이터의 Order 테이블에서 구매한 부품의 분기별 값과 판매한 제품의 분기별 값을 계산한 매출을 PivotGridControl로 출력

 ![분기별 매출](https://user-images.githubusercontent.com/74530618/103981154-9b8bc380-51c4-11eb-8c34-68a8d9b14c1c.jpg)

### 10. 기간당 지출

 데이터의 Expense 테이블의 인건비, 운송비, 유지보수비 데이터와 Order 테이블에서 부품을 구매하는데 사용한 비용을 기간별 LineChart로 출력
 
 ![기간당 지출](https://user-images.githubusercontent.com/74530618/103981464-308ebc80-51c5-11eb-8186-cbbcd689f3db.jpg)

### 11. 전월 대비 수익 증감률

 데이터의 Order 테이블에서 판매한 제품에 의한 월수익이 전월 대비 증가/감소한 비율을 AreaChart로 출력

![전월 대비 수익 증감률](https://user-images.githubusercontent.com/74530618/103980752-d17c7800-51c3-11eb-8879-c27acae2b98d.jpg)

### 12. 영업팀 실적비교

 데이터의 Order 테이블에서 판매건수를 팀별로 합한것과 팀별 목표건수를 비교해 Side-by-Side BarChart로 출력
 
![영업팀 실적비교](https://user-images.githubusercontent.com/74530618/103981549-59af4d00-51c5-11eb-9886-0a34c69a7cba.jpg)

### 13. 제품목록

 - Item 테이블의 데이터를 가져와 GridControl에 출력
 - GridControl을 클릭했을때 클릭한 제품/부품의 사진과 정보를 출력
 - 정보를 입력하고 이미지를 불러와 데이터를 등록/수정/삭제 가능
 
 ![제품목록](https://user-images.githubusercontent.com/74530618/103982168-52d50a00-51c6-11eb-8968-c5bbf1539757.jpg)
 
## 발생한 이슈
1. 이슈 : MSSQL에 이미지를 직접적으로 저장하는 방법을 못찾음
2. 이슈 : 지도 이미지 속 원하는 위치에 버블차트를 그리기 어려움

### 원인
1. 이슈 원인 : 이미지를 이진데이터로 컨버트 하는 방법을 찾기 쉽지 않았다.
2. 이슈 원인 : 지도 이미지내 위치의 좌표가 X, Y 값으로 나오는데 지도의 크기에 따라 매번 달라짐 

### 해결방법
1. 이슈 해결 방법 : 비주얼 스튜디오 WinForm으로 이미지를 이진데이터로 컨버트해서 DB에 저장함
2. 이슈 해결 방법 : 마이크로소프트사에서 지원하는 지도 컨트롤 중 Bing Map을 활용하요 해당 위치를 X,Y 좌표값이 아닌 위도와 경도로 표시
