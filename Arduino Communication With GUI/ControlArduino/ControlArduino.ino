#include <Wire.h>
#include <LiquidCrystal_I2C.h>

String inputString = "";
boolean stringComplete = false;
String commandString = "";

int pinLED1 = 8;
int pinLED2 = 9;
int pinLED3 = 10;
boolean isConnected = false;

LiquidCrystal_I2C lcd(0x27, 16, 2);

void setup() {
  Serial.begin(9600);
  pinMode(pinLED1, OUTPUT);
  pinMode(pinLED2, OUTPUT);
  pinMode(pinLED3, OUTPUT);
  LCDDisplay();
}

void loop() {
  if(stringComplete)
  {
    stringComplete = false;
    getCommand();

    if(commandString.equals("Start"))
    {
      lcd.clear();
    }
    
    if(commandString.equals("Stop"))
    {
      turnLedOFF(pinLED1);
      turnLedOFF(pinLED2);
      turnLedOFF(pinLED3);
      lcd.clear();
      lcd.print("Ready to Connect");
    }
    else if(commandString.equals("Text"))
    {
      String text = getTextToPrint();
      printText(text);
    }
    else if(commandString.equals("LED1"))
    {
      boolean LedState = getLedState();
      if(LedState == true)
      {
        turnLedON(pinLED1);
      }
      else
      {
        turnLedOFF(pinLED1);
      }
    }
    else if(commandString.equals("LED2"))
    {
      boolean LedState = getLedState();
      if(LedState == true)
      {
        turnLedON(pinLED2);
      }
      else
      {
        turnLedOFF(pinLED2);
      }
    }
    else if(commandString.equals("LED3"))
    {
      boolean LedState = getLedState();
      if(LedState == true)
      {
        turnLedON(pinLED3);
      }
      else
      {
        turnLedOFF(pinLED3);
      }
    }
    inputString = "";
  }
}

void LCDDisplay()
{
  lcd.begin();
  lcd.backlight();
  lcd.print("Ready to Connect");
}

boolean getLedState()
{
  boolean state = false;
  if(inputString.substring(5, 7).equals("ON"))
  {
    state = true;
  }
  else
  {
    state = false;
  }
  return state;
}

void getCommand()
{
  if(inputString.length() > 0)
  {
    commandString = inputString.substring(1, 5);
  }
}

void turnLedON(int pin)
{
  digitalWrite(pin, HIGH);
}

void turnLedOFF(int pin)
{
  digitalWrite(pin, LOW);
}

String getTextToPrint()
{
  String value = inputString.substring(5, inputString.length() - 2);
  return value;
}

void printText(String text)
{
  lcd.clear();
  lcd.setCursor(0, 0);
  if(text.length() < 17)
  {
    lcd.print(text);
  }
  else
  {
    lcd.print(text.substring(0, 16));
    lcd.setCursor(0, 1);
    lcd.print(text.substring(16, 32));
  }
}

void serialEvent()
{
  while(Serial.available())
  {
    char inChar = (char)Serial.read();
    inputString += inChar;

    if(inChar == '\n')
    {
      stringComplete = true;
    }
  }
}
