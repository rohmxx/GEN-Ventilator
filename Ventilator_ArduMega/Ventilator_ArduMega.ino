#include <LiquidCrystal_I2C.h>
#include <math.h>

LiquidCrystal_I2C lcd(0x27,20,4);  // set the LCD address to 0x27 for a 20 chars and 4 line display

// motor initialization
int i=0;;

int RPWM=2;
int LPWM=3;
int R_EN=31;
int L_EN=33;

int sensor = 35;
int limit_s=37;
int Start_Button, Stop_Button;
int detick=0;
int xPIP=25,xPEEP=5,xVTe=360,xRR=20,xRRr=2.0,y,ModeSelect=1,DesktopMode;

String inputString;         // a String to hold incoming data
bool stringComplete = false;  // whether the string is complete

char temp_data;
char buff_serial[512];
int indeks;
uint16_t start_indeks, stop_indeks, indeks1,indeks2,indeks3,indeks4;
uint16_t longof_data;
uint8_t mode, breath=0;

float PIP=25,PEEP=5,VTe=360,RR=20,RRr=2.0;

bool DesktopTuning=0;

void setup()
{
  lcd.init();                      // initialize the lcd 
  lcd.backlight();

  Serial.begin(115200);

    //set output pin
  pinMode(RPWM, OUTPUT); 
  pinMode(LPWM, OUTPUT); 
  pinMode(R_EN, OUTPUT); 
  pinMode(L_EN, OUTPUT);
  digitalWrite(L_EN,HIGH);
  digitalWrite(R_EN,HIGH);

  pinMode(sensor,INPUT_PULLUP);
  pinMode(limit_s,INPUT_PULLUP);
  pinMode(41,INPUT_PULLUP);

  pinMode(21, INPUT_PULLUP);
  
}

void loop()
{
   // print the string when a newline arrives:
  if (stringComplete) 
  {
    if(inputString.indexOf("*1#")>-1)  // ON-State
    {
      lcd.clear();
      breath=0;
      mode=1;
    }
    
    else if(inputString.indexOf("*0#")>-1) //Off-State
    {
      lcd.clear();
      mode=0;
      breath=0;
    }

    else if(inputString.indexOf("*W")>-1)
    {
      if(mode==1 && inputString.indexOf("*M")<0 && inputString.indexOf("*N")<0 && inputString.indexOf("*O")<0 && inputString.indexOf("*P")<0 && inputString.indexOf("*Q")<0 && inputString.indexOf("*R")<0 && inputString.indexOf("*S")<0 && inputString.indexOf("*T")<0)
      {
        DesktopTuning=1;
        start_indeks=inputString.indexOf('W');
        indeks1=inputString.indexOf('&',start_indeks);
        indeks2=inputString.indexOf('&',indeks1+1);
        indeks3=inputString.indexOf('&',indeks2+1);
        indeks4=inputString.indexOf('&',indeks3+1);
        stop_indeks=inputString.indexOf('#',indeks4);

        PIP=inputString.substring(start_indeks+1,indeks1).toFloat();
        PEEP=inputString.substring(indeks1+1,indeks2).toFloat();
        VTe=inputString.substring(indeks2+1,indeks3).toFloat();
        RR=inputString.substring(indeks3+1,indeks4).toFloat();
        RRr=inputString.substring(indeks4+1,stop_indeks).toFloat();

        breath=0;
      }
      if(mode==1 && inputString.indexOf("*P")>-1)
      {
        breath=0;
        pompa_ambu(30,100,1);
      }
      if(mode==1 && inputString.indexOf("*Q")>-1)
      {
        breath=0;
        lepas_ambu(30,100);
      }
      if(mode==1 && inputString.indexOf("*R")>-1) //RUN
      {
          breath=1;Serial.print("#RUN");
      }
      if(mode==1 && inputString.indexOf("*S")>-1) //STOP
      {
        breath=0;
      }
      //*******************************************DESKTOP TUNING & MODE DISABLED**********************************************
      if(mode==1 && inputString.indexOf("*T")>-1)
      {
        DesktopTuning=0;DesktopMode=0;
      }
      //***************************************************MODE SELECT***********************************************************
      if(mode==1 && inputString.indexOf("*M")>-1)
      {
        DesktopMode=1;delay(1);
        ModeSelect=1;
      }
      if(mode==1 && inputString.indexOf("*N")>-1)
      {
        DesktopMode=1;delay(1);
        ModeSelect=2;
      }
      if(mode==1 && inputString.indexOf("*O")>-1)
      {
        DesktopMode=1;delay(1);
        ModeSelect=3;
      }
    }
    // clear the string:
    inputString = "";
    stringComplete = false;
  }
  
  //**************************************************DESKTOP TUNING***************************************************
  if(DesktopTuning)
  {
    xPIP=int(PIP); xPEEP=int(PEEP); xVTe=int(VTe); xRR=int(RR);  xRRr=int(RRr);
  }
  else if(!DesktopTuning)
  {
    //**************************************************POT TUNING********************************************************
    if(!breath)
    {
      if(!DesktopMode){ModeSelect=(((analogRead(A2)*2)/1000)+1);}
      xPIP =((float)(analogRead(A1)/1023.0)*25+15);
      xPEEP=((float)(analogRead(A0)/1000.0)*10+5);
      xVTe =((float)(analogRead(A5)/1023.0)*600+200);
      xRR  =((float)(analogRead(A4)/1023.0)*34+6);
      xRRr =(((analogRead(A3)*3)/1010)+1);
    }
  }

  //************************************************CONNECT/DISCONNECT****************************************************
  if(mode==1) Screen1();
  else if(mode==0) Screen0();

  //******************************************************BREATH**********************************************************
  if(mode==1&&digitalRead(41)==0){breath=1;Serial.print("#RUN");}
  if(breath==1)
  {
    y=((60000/xRR)/(xRRr+1));
    pompa_ambu(50,y,100);
    lepas_ambu(50,y*xRRr);
  }
  else if(breath==0)
  {
    Serial.print("#STOP");
    pompa_ambu(0,0,0);
    lepas_ambu(0,0);
  }

  //*****************************************************LIMIT SW************************************************
  if(digitalRead(limit_s)) 
  {
    lcd.setCursor(0,0);
    lcd.print("1");
  }
  else
  {
    lcd.setCursor(0,0);
    lcd.print("0");
  }

}

void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read();
    // add it to the inputString:
    inputString += inChar;
    // if the incoming character is a newline, set a flag so the main loop can
    // do something about it:
    if (inChar == '\n') {
      stringComplete = true;
    }
  }
}

void Screen0()
{
  lcd.setCursor(1,0);
  lcd.print("Medical Ventilator");
  lcd.setCursor(6,1);
  lcd.print("PC - AC");
  lcd.setCursor(0,2);
  lcd.print("Powered By GEN-I RnD");
  lcd.setCursor(8,3);
  lcd.print("2020");
}

void Screen1()
{
  char buff_lcd[5];
  
  if(ModeSelect==1)
  {
    lcd.setCursor(1,0);
    lcd.print("Medical Ventilator");
    lcd.setCursor(0,1);
    lcd.print("P. Control ");
  }
  if(ModeSelect==2)
  {
    lcd.setCursor(1,0);
    lcd.print("Medical Ventilator");
    lcd.setCursor(0,1);
    lcd.print("PC-Thres.  ");
  }
  if(ModeSelect==3)
  {
    lcd.setCursor(1,0);
    lcd.print("Medical Ventilator");
    lcd.setCursor(0,1);
    lcd.print("PC-Assist  ");
  }
  lcd.setCursor(0,2);
  lcd.print("PIP =");
  sprintf(buff_lcd,"%4d", xPIP);
  lcd.print(buff_lcd);
  lcd.setCursor(0,3);
  lcd.print("PEEP=");
  sprintf(buff_lcd,"%4d", xPEEP);
  lcd.print(buff_lcd);
  lcd.setCursor(11,1);
  lcd.print("VTe =");
  sprintf(buff_lcd,"%4d", xVTe);
  lcd.print(buff_lcd);
  lcd.setCursor(11,2);
  lcd.print("RR  =");
  sprintf(buff_lcd,"%4d", xRR);
  lcd.print(buff_lcd);
  lcd.setCursor(11,3);
  lcd.print("RRr =");
  sprintf(buff_lcd,"%4d", xRRr);
  lcd.print(buff_lcd);
}

void pompa_ambu(uint8_t rpm, int waktu, int jeda)
{
  int w, j;
         analogWrite(LPWM,0);
         analogWrite(RPWM,rpm); //close ambu bag
         while(w<waktu)
         {
          if(!digitalRead(21)) breath=0;
          w++;delay(1);
         }
         analogWrite(RPWM,0);
         while(j<jeda)
         {
          if(!digitalRead(21)) breath=0;
          j++;delay(1);
         }
} 

void lepas_ambu(uint8_t rpm, int waktu)
{
    int w;
    int periode=0;
    while(digitalRead(limit_s) && (periode<waktu))
    {
       if(!digitalRead(21)) breath=0;
       analogWrite(LPWM,rpm); //open ambu bag
       analogWrite(RPWM,0);
       delay(1);
       periode++;
    }
    analogWrite(LPWM,0);
    while(w<(waktu-periode))
    {
      if(!digitalRead(21)) breath=0;
      w++;delay(1);
    }
}
