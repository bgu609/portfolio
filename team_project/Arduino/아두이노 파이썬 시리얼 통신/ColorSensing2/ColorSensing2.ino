////////////////////////////////////
//컬러센서 PIN 정의
////////////////////////////////////
#define PIN_COLOR_S0 3
#define PIN_COLOR_S1 4
#define PIN_COLOR_S2 5
#define PIN_COLOR_S3 6

#define PIN_COLOR_OUT 2 //signal pin

////////////////////////////////////
//컬러센서 관련 변수선언
////////////////////////////////////
int flag = 0;  //what color reading now
byte counter = 0;  //signal data
byte countR = 0, countG = 0, countB = 0;  //signal data about color

void setup()
{
  Serial.begin(9600);
  pinMode(PIN_COLOR_S0, OUTPUT);  //set pin out
  pinMode(PIN_COLOR_S1, OUTPUT);
  pinMode(PIN_COLOR_S2, OUTPUT);
  pinMode(PIN_COLOR_S3, OUTPUT);

}

void TCS()
{
  flag = 0;
  digitalWrite(PIN_COLOR_S0, HIGH);
  digitalWrite(PIN_COLOR_S1, HIGH);

  digitalWrite(PIN_COLOR_S2, LOW);
  digitalWrite(PIN_COLOR_S3, LOW);

  attachInterrupt(0, ISR_INTO, CHANGE);
  timer0_init();
}
void ISR_INTO()
{
  counter++;
}

void timer0_init(void)
{
  TCCR2A = 0x00;
  TCCR2B = 0x07; //the clock frequency source 1024 points
  TCNT2 = 100;   //10 ms overflow again
  TIMSK2 = 0x01; //allow interrupt
}

ISR(TIMER2_OVF_vect)  //the timer 2, 10ms interrupt overflow again. Internal overflow interrupt executive function
{
  TCNT2 = 100;
  flag++;
  if (flag == 1)
  {
    countR = counter;

    Serial.print("red=");
    Serial.print(countR);
    Serial.print("  ");

    digitalWrite(PIN_COLOR_S2, HIGH);
    digitalWrite(PIN_COLOR_S3, HIGH);
  }
  else if (flag == 2)
  {
    countG = counter;

    Serial.print("green=");
    Serial.print(countG);
    Serial.print("  ");

    digitalWrite(PIN_COLOR_S2, LOW);
    digitalWrite(PIN_COLOR_S3, HIGH);
  }
  else if (flag == 3)
  {
    countB = counter;

    Serial.print("blue=");
    Serial.print(countB);
    Serial.println("");

    digitalWrite(PIN_COLOR_S2, LOW);
    digitalWrite(PIN_COLOR_S3, LOW);
    flag = 0 ;
  }
  counter = 0;
}
void loop()
{
  TCS();  //start interrupt routine
  while (1);  //infinite loop
}
