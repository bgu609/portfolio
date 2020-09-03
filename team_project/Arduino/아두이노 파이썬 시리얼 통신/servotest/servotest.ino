#include<Servo.h>
Servo servo1;
Servo servo2;
Servo servo3;

void setup() {
  Serial.begin(9600);

  servo1.attach(7);
  servo2.attach(8);
  servo3.attach(9);
  

  servo1.write(10);
  servo2.write(80);
  servo3.write(90);
}

void loop() {
  
  delay(1000);
  servo2.write(10);
  delay(1000);
  servo1.write(90);
  delay(1000);
  servo3.write(0);
  delay(1000);
  servo1.write(10);
  delay(1000);
  servo2.write(80);
  servo3.write(90);
}
