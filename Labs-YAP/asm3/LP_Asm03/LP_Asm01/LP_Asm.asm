.586
.MODEL FLAT, STDCALL
includelib kernel32.lib

ExitProcess PROTO : DWORD
MessageBoxA PROTO : DWORD, : DWORD, : DWORD, : DWORD
SetConsoleTitleA PROTO : DWORD

.STACK 4096

.CONST
consoletitle db ' SMW Consol', 0

.DATA
MB_OK EQU 0
str1 byte "Массив содержит нулевой элемент", 0
str2 byte "Массив не содержит нулевой элемент", 0
strName byte "Слемнёв Виктор, ФИТ 1-6", 0
HW DD ?

wrd word 8Ah, 3Bh, 44h, 5Fh, 99h
Arr dword 1, 2, 3, 4, 5, 6, 7

.CODE
main PROC
	START:
		mov esi, offset wrd
		mov ax, [esi + 4]
		mov bx, [esi + 2]

		mov eax, 0
		mov esi, offset Arr
		mov ecx, lengthof Arr
	CYCLE:
		add eax, [esi]
		add esi, type Arr
		loop CYCLE

		mov ecx, lengthof Arr
		mov esi, 0
	CYCLE_1:
		cmp Arr[esi], 0
		jz w_0
		ADD esi, type Arr
		LOOP CYCLE_1

		jmp not_0
		
	w_0:
		mov ebx, 0
		push offset consoletitle
		call SetConsoleTitleA
		INVOKE MessageBoxA, HW, offset str1, offset strName, MB_OK
		jmp _end

	not_0:
		mov ebx, 1
		INVOKE MessageBoxA, HW, offset str2, offset strName, MB_OK

	_end:
		push -1
		call ExitProcess 
	
main ENDP

end main
