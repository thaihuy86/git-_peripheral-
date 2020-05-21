
_interrupt:

;USB_2led.c,10 :: 		void interrupt(){
;USB_2led.c,12 :: 		if (INT0IF_bit == 1)
	BTFSS       INT0IF_bit+0, BitPos(INT0IF_bit+0) 
	GOTO        L_interrupt0
;USB_2led.c,14 :: 		INT0IF_bit = 0;
	BCF         INT0IF_bit+0, BitPos(INT0IF_bit+0) 
;USB_2led.c,15 :: 		sw = 1;
	MOVLW       1
	MOVWF       _sw+0 
	MOVLW       0
	MOVWF       _sw+1 
;USB_2led.c,16 :: 		}
L_interrupt0:
;USB_2led.c,18 :: 		if (INT1IF_bit == 1)
	BTFSS       INT1IF_bit+0, BitPos(INT1IF_bit+0) 
	GOTO        L_interrupt1
;USB_2led.c,20 :: 		INT1IF_bit = 0;
	BCF         INT1IF_bit+0, BitPos(INT1IF_bit+0) 
;USB_2led.c,21 :: 		sw = 2;
	MOVLW       2
	MOVWF       _sw+0 
	MOVLW       0
	MOVWF       _sw+1 
;USB_2led.c,22 :: 		}
L_interrupt1:
;USB_2led.c,24 :: 		if(USBIF_bit == 1)
	BTFSS       USBIF_bit+0, BitPos(USBIF_bit+0) 
	GOTO        L_interrupt2
;USB_2led.c,26 :: 		USB_Interrupt_Proc();
	CALL        _USB_Interrupt_Proc+0, 0
;USB_2led.c,27 :: 		USBIF_bit = 0;
	BCF         USBIF_bit+0, BitPos(USBIF_bit+0) 
;USB_2led.c,28 :: 		}
L_interrupt2:
;USB_2led.c,29 :: 		}
L_end_interrupt:
L__interrupt16:
	RETFIE      1
; end of _interrupt

_main:

;USB_2led.c,30 :: 		void main() {
;USB_2led.c,31 :: 		ADCON1 |= 0x0F;
	MOVLW       15
	IORWF       ADCON1+0, 1 
;USB_2led.c,32 :: 		CMCON |= 0x07;
	MOVLW       7
	IORWF       CMCON+0, 1 
;USB_2led.c,35 :: 		PORTE=0x00; LATE=0x00;
	CLRF        PORTE+0 
	CLRF        LATE+0 
;USB_2led.c,36 :: 		TRISE0_bit = 0;
	BCF         TRISE0_bit+0, BitPos(TRISE0_bit+0) 
;USB_2led.c,37 :: 		TRISE1_bit = 0;
	BCF         TRISE1_bit+0, BitPos(TRISE1_bit+0) 
;USB_2led.c,39 :: 		PORTB=0x00; LATB=0x00;
	CLRF        PORTB+0 
	CLRF        LATB+0 
;USB_2led.c,40 :: 		TRISB0_bit = 1;
	BSF         TRISB0_bit+0, BitPos(TRISB0_bit+0) 
;USB_2led.c,42 :: 		HID_Enable(&readbuff,&writebuff);
	MOVLW       _readbuff+0
	MOVWF       FARG_HID_Enable_readbuff+0 
	MOVLW       hi_addr(_readbuff+0)
	MOVWF       FARG_HID_Enable_readbuff+1 
	MOVLW       _writebuff+0
	MOVWF       FARG_HID_Enable_writebuff+0 
	MOVLW       hi_addr(_writebuff+0)
	MOVWF       FARG_HID_Enable_writebuff+1 
	CALL        _HID_Enable+0, 0
;USB_2led.c,44 :: 		INT0IF_bit=0; INT0IE_bit=1; INTEDG0_bit=1;
	BCF         INT0IF_bit+0, BitPos(INT0IF_bit+0) 
	BSF         INT0IE_bit+0, BitPos(INT0IE_bit+0) 
	BSF         INTEDG0_bit+0, BitPos(INTEDG0_bit+0) 
;USB_2led.c,45 :: 		INT1IF_bit=0; INT1IE_bit=1; INTEDG1_bit=1;
	BCF         INT1IF_bit+0, BitPos(INT1IF_bit+0) 
	BSF         INT1IE_bit+0, BitPos(INT1IE_bit+0) 
	BSF         INTEDG1_bit+0, BitPos(INTEDG1_bit+0) 
;USB_2led.c,47 :: 		USBIE_bit = 1; USBIF_bit = 0;
	BSF         USBIE_bit+0, BitPos(USBIE_bit+0) 
	BCF         USBIF_bit+0, BitPos(USBIF_bit+0) 
;USB_2led.c,48 :: 		PEIE_bit=1;  GIE_bit=1;
	BSF         PEIE_bit+0, BitPos(PEIE_bit+0) 
	BSF         GIE_bit+0, BitPos(GIE_bit+0) 
;USB_2led.c,50 :: 		while(1)
L_main3:
;USB_2led.c,52 :: 		if(sw == 1 ){
	MOVLW       0
	XORWF       _sw+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__main18
	MOVLW       1
	XORWF       _sw+0, 0 
L__main18:
	BTFSS       STATUS+0, 2 
	GOTO        L_main5
;USB_2led.c,53 :: 		writebuff[0]  = mcu_sw1;
	MOVLW       115
	MOVWF       1344 
;USB_2led.c,54 :: 		HID_Write(&writebuff,2);
	MOVLW       _writebuff+0
	MOVWF       FARG_HID_Write_writebuff+0 
	MOVLW       hi_addr(_writebuff+0)
	MOVWF       FARG_HID_Write_writebuff+1 
	MOVLW       2
	MOVWF       FARG_HID_Write_len+0 
	CALL        _HID_Write+0, 0
;USB_2led.c,55 :: 		sw = 0;
	CLRF        _sw+0 
	CLRF        _sw+1 
;USB_2led.c,56 :: 		}
L_main5:
;USB_2led.c,57 :: 		if(sw == 2 ){
	MOVLW       0
	XORWF       _sw+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__main19
	MOVLW       2
	XORWF       _sw+0, 0 
L__main19:
	BTFSS       STATUS+0, 2 
	GOTO        L_main6
;USB_2led.c,58 :: 		writebuff[0]  = mcu_sw2;
	MOVLW       119
	MOVWF       1344 
;USB_2led.c,59 :: 		HID_Write(&writebuff,2);
	MOVLW       _writebuff+0
	MOVWF       FARG_HID_Write_writebuff+0 
	MOVLW       hi_addr(_writebuff+0)
	MOVWF       FARG_HID_Write_writebuff+1 
	MOVLW       2
	MOVWF       FARG_HID_Write_len+0 
	CALL        _HID_Write+0, 0
;USB_2led.c,60 :: 		sw = 0;
	CLRF        _sw+0 
	CLRF        _sw+1 
;USB_2led.c,61 :: 		}
L_main6:
;USB_2led.c,63 :: 		if(HID_Read() !=0 )
	CALL        _HID_Read+0, 0
	MOVF        R0, 0 
	XORLW       0
	BTFSC       STATUS+0, 2 
	GOTO        L_main7
;USB_2led.c,65 :: 		HID_Read();
	CALL        _HID_Read+0, 0
;USB_2led.c,67 :: 		if(readbuff[0] == 1){
	MOVF        1280, 0 
	XORLW       1
	BTFSS       STATUS+0, 2 
	GOTO        L_main8
;USB_2led.c,68 :: 		writebuff[0] = 5;
	MOVLW       5
	MOVWF       1344 
;USB_2led.c,69 :: 		RE0_bit = 1;
	BSF         RE0_bit+0, BitPos(RE0_bit+0) 
;USB_2led.c,72 :: 		HID_Write(&writebuff,out_size);
	MOVLW       _writebuff+0
	MOVWF       FARG_HID_Write_writebuff+0 
	MOVLW       hi_addr(_writebuff+0)
	MOVWF       FARG_HID_Write_writebuff+1 
	MOVLW       2
	MOVWF       FARG_HID_Write_len+0 
	CALL        _HID_Write+0, 0
;USB_2led.c,73 :: 		}
	GOTO        L_main9
L_main8:
;USB_2led.c,75 :: 		else if(readbuff[0] == 2) {
	MOVF        1280, 0 
	XORLW       2
	BTFSS       STATUS+0, 2 
	GOTO        L_main10
;USB_2led.c,76 :: 		writebuff[0] = 6;
	MOVLW       6
	MOVWF       1344 
;USB_2led.c,78 :: 		RE0_bit = 0;
	BCF         RE0_bit+0, BitPos(RE0_bit+0) 
;USB_2led.c,80 :: 		HID_Write(&writebuff,out_size);
	MOVLW       _writebuff+0
	MOVWF       FARG_HID_Write_writebuff+0 
	MOVLW       hi_addr(_writebuff+0)
	MOVWF       FARG_HID_Write_writebuff+1 
	MOVLW       2
	MOVWF       FARG_HID_Write_len+0 
	CALL        _HID_Write+0, 0
;USB_2led.c,81 :: 		}
	GOTO        L_main11
L_main10:
;USB_2led.c,83 :: 		else if(readbuff[0] == 3){
	MOVF        1280, 0 
	XORLW       3
	BTFSS       STATUS+0, 2 
	GOTO        L_main12
;USB_2led.c,84 :: 		writebuff[0] = 7;
	MOVLW       7
	MOVWF       1344 
;USB_2led.c,85 :: 		RE1_bit = 1;
	BSF         RE1_bit+0, BitPos(RE1_bit+0) 
;USB_2led.c,88 :: 		HID_Write(&writebuff,out_size);
	MOVLW       _writebuff+0
	MOVWF       FARG_HID_Write_writebuff+0 
	MOVLW       hi_addr(_writebuff+0)
	MOVWF       FARG_HID_Write_writebuff+1 
	MOVLW       2
	MOVWF       FARG_HID_Write_len+0 
	CALL        _HID_Write+0, 0
;USB_2led.c,89 :: 		}
	GOTO        L_main13
L_main12:
;USB_2led.c,91 :: 		else if(readbuff[0] == 4) {
	MOVF        1280, 0 
	XORLW       4
	BTFSS       STATUS+0, 2 
	GOTO        L_main14
;USB_2led.c,92 :: 		writebuff[0] = 8;
	MOVLW       8
	MOVWF       1344 
;USB_2led.c,94 :: 		RE1_bit = 0;
	BCF         RE1_bit+0, BitPos(RE1_bit+0) 
;USB_2led.c,96 :: 		HID_Write(&writebuff,out_size);
	MOVLW       _writebuff+0
	MOVWF       FARG_HID_Write_writebuff+0 
	MOVLW       hi_addr(_writebuff+0)
	MOVWF       FARG_HID_Write_writebuff+1 
	MOVLW       2
	MOVWF       FARG_HID_Write_len+0 
	CALL        _HID_Write+0, 0
;USB_2led.c,97 :: 		}
L_main14:
L_main13:
L_main11:
L_main9:
;USB_2led.c,99 :: 		}
L_main7:
;USB_2led.c,100 :: 		}
	GOTO        L_main3
;USB_2led.c,101 :: 		}
L_end_main:
	GOTO        $+0
; end of _main
