#include <Smoothed.h> 

 Smoothed <int> sensorA; 

void setup() {

  // put your setup code here, to run once:
  Serial.begin(115200);
  sensorA.begin(SMOOTHED_AVERAGE, 10);	
 
}

void loop() {
  int out = analogRead(A0);
  sensorA.add(out);
  // put your main code here, to run repeatedly:
  
  Serial.print(sensorA.get());
  Serial.print(">");
  Serial.println(1);
  
  delay(5);
}
