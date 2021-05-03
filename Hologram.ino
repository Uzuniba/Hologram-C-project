uint8_t Sutun[286]={
255,16,16,16,255,0,0,255,145,145,129,
0,0,255,1,1,1,1,0,0,255,
1,1,1,1,0,0,255,129,129,129,
255,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,};
void setup() {//dfg
DDRD=B11111111;//D portunun 8 bitini çıkış olarak atar
pinMode(A4,INPUT);
pinMode(A2,OUTPUT);//Hall effect sensörünün 5 volt çıkışı a2 çıkışı ile sağlanmıştır(enerji tasarrufu için)
digitalWrite(A2,HIGH);//A2 çıkışı aktif edilerek sensör aktif hale getirilir
PORTD=0;//D portunun tüm çıkışları 0 volta çekilir
}
int a=400;//iki sütün arasındahi gecikme süresi mikrosaniye cinsinden
void loop() {
 if(analogRead(A4)<500)//hall effect sensörü mıknatısın üzerinde ise  başlangıç verir
 {
     for(int i=0;i<50;i++)// Sütun dizisinin tüm elemanlarını  tarayan döngü
     {
     PORTD=Sutun[i];//Sütun dizisinin elemanlarını portd ye aktarır
     delayMicroseconds(a); //Bir sütunun görünürlük süresi
     }
 }
PORTD=0;
}
