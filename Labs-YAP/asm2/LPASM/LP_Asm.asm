.586
.MODEL FLAT, STDCALL
includelib kernel32.lib

ExitProcess PROTO : DWORD
MessageBoxA PROTO : DWORD, : DWORD, : DWORD, : DWORD

.STACK 4096

.CONST

.DATA
MB_OK EQU 0
str1 byte "Результат равен = "
str3 byte "0", 0
str2 byte "Добро пожаловать", 0
HW DD ?
x byte 2
y byte 3

.CODE
main PROC
START:
		mov al, x
		add al, y
		add str3, al
	
		INVOKE MessageBoxA, MB_OK, offset str1, offset str2, HW
		
	push	-1
	call	ExitProcess
main ENDP

end main