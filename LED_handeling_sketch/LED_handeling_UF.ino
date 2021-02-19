
//board : EPS8266 NODEMCU V3

void setup() {
  Serial.begin(115200);
  pinMode(2, OUTPUT);
  digitalWrite(2, HIGH);
}

void loop() {
  char receiveVal;
  if (Serial.available() > 0)//check if the serial is available
  {
    receiveVal = Serial.read();//read the character sent in the serial by the userform
    if (receiveVal == '1')
      digitalWrite(2, LOW); //switch on the led, I don't know why but in my ESP8266 LOW switch on the builtin led. High switch off
    else
      digitalWrite(2, HIGH); //switch off the led
  }
  delay(100);
}