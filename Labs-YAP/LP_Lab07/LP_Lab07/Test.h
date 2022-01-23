#pragma once //Применение директивы #pragma
#include "Dictionary.h" //Применение директивы #include
#include"Test.h"

//#define TEST_CREATE_01 Instance t_1 = Create(LONGNAME, 1)//Применение директивы #define

//#define TEST_CREATE_02 Instance t_2 = Create(NORMALNAME, 101)
//
//#define TEST_ADDENTRY_03 Instance t_3 = Create(NORMALNAME, 1);AddEntry(t_3 , e1); AddEntry(t_3 , e2)
//
//#define TEST_ADDENTRY_04 Instance t_4 = Create(NORMALNAME, 2); Entry t1 = { 1,"Гладкий" }, t2 = { 1,"Веялкин" };AddEntry(t_4 , t1); AddEntry(t_4 , t2)
//
//#define TEST_GETENTRY_05 Instance t_5 = Create(NORMALNAME, 2); Entry t1 = { 1,"Гладкий" };Entry testget = GetEntry(t_5, 2)
//
//#define TEST_DELENTRY_06 Instance t_6 = Create(NORMALNAME, 2); Entry t1 = { 1,"Гладкий" };AddEntry(t_6 , t1);DelEnrty(t_6, 2)
//
//#define TEST_UPDENTRY_07 Instance t_7 = Create(NORMALNAME, 2);Entry t1 = { 1,"Гладкий" }; Entry testupd1 = { 6,"Гурин" };AddEntry(t_7 , t1);UpdEntry(t_7, 3, testupd1);
//
#define TEST_UPDENTRY_08 Instance t_8 = Create(NORMALNAME, 2);Entry t1 = { 1,"Гладкий" };Entry t2 = { 2,"Смелов" };AddEntry(t_8 , t1);AddEntry(t_8 , t2); Entry testupd2 = { 1,"Гурин" };UpdEntry(t_8, 2, testupd2)
//#define TEST_DICTIONARY