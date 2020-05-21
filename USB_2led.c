
#define mcu_sw1 's'
#define mcu_sw2 'w'
#define in_size 2
#define out_size 2

unsigned char readbuff[in_size] absolute 0x500;
unsigned char writebuff[out_size] absolute 0x540;
int sw =0;
void interrupt(){

    if (INT0IF_bit == 1)
   {
     INT0IF_bit = 0;
     sw = 1;
   }
   
   if (INT1IF_bit == 1)
   {
     INT1IF_bit = 0;
     sw = 2;
   }
   
     if(USBIF_bit == 1)
   {
      USB_Interrupt_Proc();
      USBIF_bit = 0;
   }
}
void main() {
     ADCON1 |= 0x0F;
  CMCON |= 0x07;


  PORTE=0x00; LATE=0x00;
  TRISE0_bit = 0;
  TRISE1_bit = 0;

  PORTB=0x00; LATB=0x00;
  TRISB0_bit = 1;
  
  HID_Enable(&readbuff,&writebuff);
  
  INT0IF_bit=0; INT0IE_bit=1; INTEDG0_bit=1;
  INT1IF_bit=0; INT1IE_bit=1; INTEDG1_bit=1;

  USBIE_bit = 1; USBIF_bit = 0;
  PEIE_bit=1;  GIE_bit=1;
  
  while(1)
 {
     if(sw == 1 ){
      writebuff[0]  = mcu_sw1;
       HID_Write(&writebuff,2);
       sw = 0;
     }
      if(sw == 2 ){
      writebuff[0]  = mcu_sw2;
       HID_Write(&writebuff,2);
       sw = 0;
     }
 
    if(HID_Read() !=0 )
    {   
        HID_Read();
        
       if(readbuff[0] == 1){
          writebuff[0] = 5;
          RE0_bit = 1;


          HID_Write(&writebuff,out_size);
       }
       
       else if(readbuff[0] == 2) {
            writebuff[0] = 6;

           RE0_bit = 0;

          HID_Write(&writebuff,out_size);
       }
       
       else if(readbuff[0] == 3){
          writebuff[0] = 7;
          RE1_bit = 1;


          HID_Write(&writebuff,out_size);
       }
       
       else if(readbuff[0] == 4) {
            writebuff[0] = 8;

           RE1_bit = 0;

          HID_Write(&writebuff,out_size);
       }

    }
  }
}