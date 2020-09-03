
/*
미세 먼지 센서 값 출력
http://www.devicemart.co.kr/
*/

// 미세 먼지 없을 때 초기 V 값 0.35
// 공기청정기 위 등에서 먼지를 가라앉힌 후 voltage값 개별적으로 측정 필요
#define no_dust 0.35

// 아두이노 - 미세 먼지 센서 연결
int dustout=A0;
int v_led=7;

// 센서로 읽은 값 변수 선언
float vo_value=0;

// 센서로 읽은 값을 전압으로 측정 변수
float sensor_voltage=0;

// 실제 미세 먼지 밀도 변수
float dust_density=0;

void setup()
{
 Serial.begin(9600); // 통신 속도 9600bps로 시리얼 통신 시작
 pinMode(v_led,OUTPUT); // 적외선 led 출력으로 설정
}

void loop()
{

 // 미세 먼지 센서 동작
 digitalWrite(v_led,LOW); // 적외선 LED ON
 delayMicroseconds(280); // 280us동안 딜레이
 vo_value=analogRead(dustout); // 데이터를 읽음
 delayMicroseconds(40); // 320us - 280us
 digitalWrite(v_led,HIGH); // 적외선 LED OFF
 delayMicroseconds(9680); // 10ms(주기) -320us(펄스 폭) 한 값

 sensor_voltage=get_voltage(vo_value);
 dust_density=get_dust_density(sensor_voltage);

  Serial.print("value = ");
  Serial.println(vo_value);
  Serial.print("Voltage = ");
  Serial.print(sensor_voltage);
  Serial.println(" [V]");
  Serial.print("Dust Density = ");
  Serial.print(dust_density);
  Serial.println(" [ug/m^3]");
  
  delay(1000);
}

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
