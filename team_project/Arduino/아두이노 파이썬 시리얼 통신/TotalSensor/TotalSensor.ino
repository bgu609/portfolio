/////온습도/////
#include<DHT.h>//라이브러리 추가
#define DHTTYPE DHT11//센서 종류 정의
int DHTSensor = 9;//온습도 센서 핀
DHT dht(DHTSensor, DHTTYPE);//온습도 센서 연결
float valt;//온도 값 변수
float valh;//습도 값 변수

/////불꽃 감지 센서/////
int FASensor = A0;//아날로그 센서 핀
int valfa;//아날로그 값 변수

/////흔들림 감지 센서/////
int VBSensor = A1;//흔들림 감지 센서 핀
int valvb;//흔들림 값 변수

/////미세먼지 감지 센서/////
// 미세 먼지 없을 때 초기 V 값 0.35
// 공기청정기 위 등에서 먼지를 가라앉힌 후 voltage값 개별적으로 측정 필요
#define no_dust 0.35
int Dusensor = A2;//미세 먼지 센서 핀
int Duled = 7;//미세먼지 적외선 LED 
float valDu = 0;//미세먼지 값 변수
float sensor_voltage = 0;// 센서로 읽은 값을 전압으로 측정 변수
float dust_density = 0;// 실제 미세 먼지 밀도 변수

void setup() {
  //시리얼 통신 시작
  Serial.begin(9600);

  //핀 설정 -> GROUND, VCC 는 일괄처리
  pinMode(DHTSensor, INPUT);//DHT핀 설정
  pinMode(FASensor, INPUT);//불꽃감지 아날로그 핀 설정
  pinMode(VBSensor, INPUT);//흔들림 감지센서 핀 설정
  pinMode(Duled,OUTPUT); // 미세먼지 적외선 led 출력으로 설정

  //DHT 온습도 센서 시작
  dht.begin();
}

int count = 0;

void loop() {
  
  //온도값, 습도 값 받기
  valt = dht.readTemperature();
  valh = dht.readHumidity();
  
  //불꽃감지 센서 값 받기
  valfa = analogRead(FASensor);
  
  //흔들림 감지 센서 값 받기
  valvb = analogRead(VBSensor);
  
  //미세먼지 감지 센서 작동, 값 받기 
  digitalWrite(Duled, LOW); // 적외선 LED ON
  delayMicroseconds(280); // 280us동안 딜레이
  valDu = analogRead(Dusensor); // 데이터를 읽음
  delayMicroseconds(40); // 320us - 280us
  digitalWrite(Duled,HIGH); // 적외선 LED OFF
  delayMicroseconds(9680); // 10ms(주기) -320us(펄스 폭) 한 값
  //미세먼지 농도 변환 공식
  sensor_voltage=get_voltage(valDu);
  dust_density=get_dust_density(sensor_voltage);  

  //시리얼 출력
  Serial.print(valt);//온도 센서
  Serial.print("/");
  Serial.print(valh);//습도 센서
  Serial.print("/");
  Serial.print(valfa);//불꽃 아날로그
  Serial.print("/");
  Serial.print(dust_density+70);//미세먼지 감지 센서
  Serial.print("/");
  Serial.println(valvb);//흔들림 감지 센서  

  delay(4990);

}

/////미세먼지 농도 변환 공식/////
float get_voltage(float value)
{
 // 아날로그 값을 전압 값으로 바꿈
 float V= value * 5.0 / 1024; 
 return V;
}
float get_dust_density(float voltage)
{
 // 데이터 시트에 있는 미세 먼지 농도(ug) 공식 기준
 float dust=(voltage-no_dust) / 0.005;
 return dust;
}
