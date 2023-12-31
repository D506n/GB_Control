# GB_Control# Функция выполняемая программой:

Программа просит пользователя ввести текст, формирует из него массив  
после чего формирует новый массив из строк, длина которых меньше, либо равна 3  
символам (далее: "необходимое количество символов") и выдаёт его пользователю.

# Оглавление:

>[Функция выполняемая программой](#функция-выполняемая-программой)
> 
>[Описание используемых методов](#описание-используемых-методов):
>
>1. [EnterTextArray](#entertextarray)
>2. [EnterText](#entertext)
>3. [CreateArrayWithThreeSymbol](#createarraywiththreesymbol)
>4. [PrintArray](#printarray)

# Описание используемых методов:

## EnterTextArray

Метод принимает в качестве аргументов следующие данные:

1. Строку типа `string`, с сообщением для пользователя.

Метод "EnterTextArray", создаёт массив строк из данных которые вводит пользователь,     
для этого используется вспомогательный метод [EnterText](#entertext). 

Возвращает массив `string[]`.

Описание работы метода по пунктам:

1. EnterTextArray принимает сообщение, которое будет выводиться пользователю.

2. Далее метод создаёт пустой массив типа `string[]` и вызывает метод [EnterText](#entertext), в    
который передаёт сообщение для пользователя. Пустой массив создаётся при    
помощи конструкции: `Array.Empty<string>()`, для соответствия правилу "[CA1825](https://learn.microsoft.com/ru-ru/dotnet/fundamentals/code-analysis/quality-rules/ca1825)";

3. Если возвращённая методом [EnterText](#entertext) строка содержит хотя бы один символ, то  
размер пустого массива созданного в шаге 2 увеличивается на единицу, и в  
образованную ячейку записывается полученная от пользователя строка, после  
чего снова вызывается метод [EnterText](#entertext), и цикл повторяется с шага 2;

4. Если пользователь вводит пустую строку, то данный цикл прерывается и программа  
переходит к вызову следующего метода;

## EnterText

Метод принимает в качестве аргументов следующие данные:

1. Строку типа `string`, с сообщением для пользователя.

Данный метод необходим для взаимодействия с пользователем. 

Возвращает данные типа `string`.

Подробнее:

1. EnterText принимает текст типа `string`, чтобы в последствии выдать его пользователю;

2. EnterText выводит принятое в первом шаге сообщение пользователю, и принимает текст   
типа `string`, который вводит пользователь;

3. EnterText возвращает введённый пользователем текст.

## CreateArrayWithThreeSymbol

Метод принимает в качестве аргументов следующие данные:

1. Массив тиипа `string[]` в котором будет искать строки длиной 3 и менее символов.

Данный метод принимает массив и создаёт новый массив в который помещает все строки  
длинной 3 и менее символов из принятого массива. Если исходный массив не содержит ни  
одной строки нужной длины, то возвращается пустой массив. 

В случае нахождения строк необходимой длины возвращает массив `string[]`.   
Если строки не найдены, то возвращает пустой массив без ячеек.

Подробнее:

1. CreateArrayWithThreeSymbol принимает массив типа `string[]`;

2. Далее метод создаёт пустой массив при помощи конструкции:  `Array.Empty<string>()`,  
для соответствия правилу "[CA1825](https://learn.microsoft.com/ru-ru/dotnet/fundamentals/code-analysis/quality-rules/ca1825)";

3. Запускается цикл который проверяет длину строк в каждой ячейке исходного массива;

4. Если цикл находит в массиве строку нужной длины, то размер массива созданного в  
шаге 2 увеличивается на 1. В созданную ячейку записывается значение найденой строки;

5. После проверки всего исходного массива метод возвращает созданный им массив типа  
`string[]`, в который записаны все строки нужной длины.

## PrintArray

Метод принимает в качестве аргументов следующие данные:   
1. Массив типа `string[]`, данные из которого в последствии будут выданы пользователю;
2. Строку типа `string` с сообщением для пользователя, если строки нужной длины найдены;
3.  Строку типа `string` c сообщением, для случаев, когда строки нужной длины не найдены.

Получив необходимые данные метод выдаёт пользователю все строки необходимой длины.

Подробнее:
1. Выполняется проверка, содержит ли принятый в качестве аргумента массив хотя бы одну  
ячейку. Если массив содержит хотя бы одну ячейку, то выполняются действия описанные     
с шага 2, по шаг 3 включительно. Если массив не содержит ячеек, то выполняется шаг 4.

2. Пользователю выводится сообщение которое было принято в качестве аргумента,  
говорящее, что нужные строки найдены.

3. Запускается цикл, в ходе которого в консоль выводится содержимое всех ячеек  массива,    
который был принят в качестве аргумента. Содержимое ячеек отделяется   друг от друга    
символом ";".

4. Пользователю выдаётся сообщение, которое было принято в качестве аргумента,  
говорящее, что нужные строки не найдены.