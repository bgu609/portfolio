/////온습도/////
#include<DHT.h>//라이브러리 추가
#define DHTTYPE DHT11//센서 종류 정의
int DHTSensor = 9;//온습도 센서 핀
DHT dht(DHTSensor, DHTTYPE);//온습도 센서 연결
float valt;//온도 값 변수
float valh;//습도 값 변수

/////불꽃 감지 센서/////
int FASensor = A0;//아날로그 센서 핀
int FDSensor = A1;//디지털 센서 핀
int valfa;//아날로그 값 변수
int valfd;//디지털 값 변수

/////흔들림 감지 센서/////
int VBSensor = A2;//흔들림 감지 센서 핀
int valvb;//흔들림 값 변수

/////미세먼지 감지 센서/////
int DASensor = A3;//미세먼지 아날로그 핀
int DLed = 7;//미세먼지 판별 led 핀
float valda;//미세번지 값 변수

void setup() {
  //시리얼 통신 시작
  Serial.begin(9600);

  //핀 설정 -> GROUND, VCC 는 일괄처리
  pinMode(DHTSensor, INPUT);//DHT핀 설정
  pinMode(FASensor, INPUT);//불꽃감지 아날로그 핀 설정
  pinMode(FDSensor, INPUT);//불꽃감지 디지털 핀 설정
  pinMode(VBSensor, INPUT);//흔들림 감지센서 핀 설정
  pinMode(DASensor, INPUT);//미세먼지 감지센서 핀 설정
  pinMode(DLed, OUTPUT);//미세먼지 판별 led 핀 설정
//  digitalWrite(DLed, HIGH);//미세먼지 판별 led on
  //DHT 온습도 센서 시작
  dht.begin();
}

void loop() {
  //온도값, 습도 값 받기
  valt = dht.readTemperature();
  valh = dht.readHumidity();
  //불꽃감지 센서 값 받기
  valfa = analogRead(FASensor);
  valfd = digitalRead(FDSensor);
  //흔들림 감지 센서 값 받기
  valvb = analogRead(VBSensor);
  //미세먼지 감지 센서 값 받기
  valda = analogRead(DASensor);

//미세먼지 농도 변환 공식
//digitalWrite(DLed, LOW);
//delayMicroseconds(280);
//valda = analogRead(DASensor);
//delayMicroseconds(40);
//digitalWrite(DLed,HIGH);
//delayMicroseconds(9680);

float valtage = valda* (5.0 / 1024.0);
float dustDensity = (0.17 * valtage - 0.1) * 1000;
   
  
 
  
  Serial.print(valt);//온도
  Serial.print("/");
  Serial.print(valh);//습도
  Serial.print("/");
  Serial.print(valfa);//불꽃 아날로그
  Serial.print("/");
  Serial.print(valfd);//불꽃 디지털
  Serial.print("/");
  Serial.print(valvb);//흔들림 감지 센서
  Serial.print("/");
//  Serial.println(dustDensity);
  Serial.println(dustDensity);
  delay(400);
}
