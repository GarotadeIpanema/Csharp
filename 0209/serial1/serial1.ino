const int BUZZER = 10;
 
// #define BUZZER 10
#define DO1   262 // 4옥타브 도
#define RE    294 // 레
#define MI    330 // 미
#define FA    349
#define SOL   392
#define LA    440
#define SI    494
#define DO2   523
#define DELAY 300

const int hakGyo[] = {SOL, SOL, LA, LA, SOL, SOL, MI, SOL, SOL,
  MI, MI, RE, SOL, SOL, LA, LA, SOL, SOL, MI, SOL, MI, RE, MI, DO1};
#define LED 13
#include <Servo.h>
Servo myservo;
int pos = 0;
void setup() {
  myservo.attach(9); 
}

void loop() {
//  // 데이터 송신: 아두이노 -> PC
//
//  Serial.print("온도: 26.5℃");
//  Serial.println();
//  delay(2000);

controlSystem();
//  // 데이터 수신: PC -> 아두이노 
}
  void controlSystem(){
    if (Serial.available()) {
    char ch = Serial.read();
    if (ch == '1') {
      digitalWrite(LED, HIGH);
      // 데이터 송신: 아두이노 -> PC
      Serial.println("LED ON");
    }
    else if (ch == '0') {
      digitalWrite(LED, LOW);
      Serial.println("LED OFF");
    }
  
     else if(ch == '2'){
      Serial.println("멜로디 재생");
      for (int i=0; i<sizeof(hakGyo)/sizeof(int); i++) {
      tone(BUZZER, hakGyo[i], 300);
    delay(DELAY);
    
    }
     }
    else if(ch=='3'){
      Serial.println("서보모토 무브");
      for (pos = 0; pos <= 180; pos += 1) { // goes from 0 degrees to 180 degrees
    // in steps of 1 degree
    myservo.write(pos);              // tell servo to go to position in variable 'pos'
    delay(15);                       // waits 15ms for the servo to reach the position
  }
  for (pos = 180; pos >= 0; pos -= 1) { // goes from 180 degrees to 0 degrees
    myservo.write(pos);              
      }
    }
    delay(50);
    }
  }
