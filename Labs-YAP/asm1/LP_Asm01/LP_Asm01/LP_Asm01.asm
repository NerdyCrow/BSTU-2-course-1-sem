.586P																; система команд (процессор Pentium)
.MODEL FLAT, STDCALL 												; модель памяти, Плоская модель памяти , соглашение о вызовах
includelib kernel32.lib 											; компановщику: компоновать с kerne132 	
																		
ExitProcess PROTO : DWORD 											; прототип функции для завершения процесса Windows	
MessageBoxA PROTO : DWORD, : DWORD, : DWORD, : DWORD 				; прототип API-функции МеssagеВохА 	
																		
.STACK 4096 														; выделение стека объемом 4 мегабайта 	
																		
.CONST 																; сегмент констант 	
																		
.DATA 																; сегмент данных	
MB_OK   EQU  0													; EQU определяет константу	
STR1    DB   "Моя первая программа", 0 									; строка, первый элемент данные + нулевой бит	
STR2    DB   "Привет всем!", 0											; строка, первый элемент данные + нулевой бит	
HW      DD   ? 															; двойное слово длиной 4 байта, неинициапицировано 	
																		
.CODE 																; сегмент кода 	
																		
main PROC 															; точка входа main 	
START :																; метка 													
		
		
		INVOKE MessageBoxA, HW, OFFSET STR2, OFFSET STR1, MB_OK			
					
	push - 1 														; код возврата процесса Windows(параметр ExitProcess)	
	call ExitProcess 												; так завершается любой процесс Windows 																			
main ENDP 															; конец процедуры		
																		
end main															; конец модуля main 