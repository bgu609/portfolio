int Led = 12; // LED 연결단자 설정
int sensorpin = 4; // 센서값을 읽을 단자 설정 OUT
int val; // 센서값
 
void setup () {
  pinMode (Led, OUTPUT); // LED 단자를 아웃풋으로 설정
  pinMode (sensorpin, INPUT); // 센서값을 인풋으로 설정
  pinMode(5, OUTPUT);
  pinMode(6, OUTPUT);

  digitalWrite(5, LOW);
  digitalWrite(6, HIGH);
}
 
void loop () {
  val = digitalRead (sensorpin); // 센서값을 읽어옴
  if (val == HIGH) { // 장애물 감지 안됨
    digitalWrite (Led, LOW); //LED 끔
  } else {
    digitalWrite (Led, HIGH);
  }
}
