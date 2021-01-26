﻿# Библиотека для вычисления площади геометрических фигур
## Поддерживаемые фигуры
1. Треугольники
2. Круги
## Пример использования
```
var figure = new Circle(4);
var square = figure.CalculateSquare();
```
## Добавление своих фигур
```
using GeometryDash;
internal class Cube : IFigure
{
    public double CalculateSquare()
        => ...
}
```
## Unit-тесты включены
## P.S.
Немного абстрактная трактовка задачи + пара условий добавляют неуверенности.
Если бы мне дали задачу написать библиотеку геометрических фигур с поддержкой различных функций (в том числе вычисление площади) - я бы поступил именно так, как сделал в этом проекте, единственное, что интерфейсы были бы бобогаче)
А так, задача довольно скудная, ведь это даже не создание + управление сущностью, а просто создание сущностей с одним вычисляемым полем - площадь, даже негде развернуться :с
Зачем интерфейс - при интеграции в систему это позволит писать такой код:
```
IFigure figure;
...
figure.CalculateSquare();
```