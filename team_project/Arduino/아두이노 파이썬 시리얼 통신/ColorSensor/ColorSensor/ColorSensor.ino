///////색판별/////
int s0 = 3;
int s1 = 4;
int s2 = 5;
int s3 = 6;
int out = 7;

void setup() {
  //시리얼 통신 시작
  Serial.begin(9600);

  //핀 설정
  pinMode(s0, OUTPUT);
  pinMode(s1, OUTPUT);
  pinMode(s2, OUTPUT);
  pinMode(s3, OUTPUT);
  pinMode(out, INPUT);
  
  digitalWrite(s0, HIGH);   
  digitalWrite(s1, LOW);
}

void loop() {
  int val = 0;
  
  digitalWrite(s2, LOW);
  digitalWrite(s3, LOW);
  val = pulseIn(out, LOW);
//val = digitalRead(out);
  Serial.print("RED : ");
  Serial.print(val, DEC);
  delay(10);

  digitalWrite(s2, HIGH);
  digitalWrite(s3, HIGH);
  val = pulseIn(out, LOW);
//val = digitalRead(out);
  Serial.print("     GREEN : ");
  Serial.print(val, DEC);
  delay(10);

  digitalWrite(s2, LOW);
  digitalWrite(s3, HIGH);
  val = pulseIn(out, LOW);
//val = digitalRead(out);
  Serial.print("     BLUE : ");
  Serial.println(val, DEC);
  

  delay(400);
}
