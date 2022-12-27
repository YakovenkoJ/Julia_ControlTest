Задача: Написать программу, которая из имеющегося массива строк *array* сформирует новый массив из строк, 
длина которых меньше, либо равна 3 символам.

Для начала необходимо определить размер нового массива: *count* = кол-во строк, длина которых меньше, либо равна 3 символам.

Сделаем это при помощи метода **CountLetters**:
1. Присваиваем переменной count значение *count = 0*.
2. Устанавливаем счетчик *i* в позицию 0.
3. Пока *i < array.Length* проверяем:

- Если *array[i].Length <= 3*, увеличиваем *count* на 1;
- В противном случае увеличиваем счетчик *i* на 1.

4. По завершении алгоритма получаем значение *count*.

Далее выполняем задачу - формируем новый массив строк при помощи метода **CreateMas**:
1. Передаем в метод значение *count* и массив *array*.
2. Объявляем новый массив *LengthResult* размером *count*.
3. Объявляем счетчик *ind* и устанавливаем его в позицию 0.
4. Пока *i < array.Length* проверяем:

- Если *array[i].Length <= 3*, присваиваем значению *LengthResult[ind] = array[i]* и увеличиваем счетчик *ind* на 1;
- В противном случае увеличиваем счетчик *i* на 1.

5. По завершении алгоритма получаем новый массив *LengthResult*.
