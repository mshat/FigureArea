### Вопрос 1
<code>[Учебная работа по бэкенду, Django](https://github.com/mshat/web_project)</code> - мой вклад: бэк, фронт на шаблонах, RestAPI, диаграммы. Контейнеризация, маршрутизация, сервер - коллеги.
К сожалению, код красотой не блещет, тк всё писалось в спешке.

<code>[Простая работа по бэкенду, Django](https://github.com/mshat/rsoi-simple-perosn-with-api-on-docker)</code> - небольшой бэк с апи, больше для обучения работе с Docker и CI/CD.

### Вопрос 2

Выполненное задание: <code>[(Этот репозиторий)](https://github.com/mshat/FigureArea)</code>
Реализована библиотека для вычисления площади треугольника по трём сторонам и площади круга по радиусу. 
Согласно тз, поддерживается только задание треугольника по сторонам и круга по радиусу.
Библиотека предоставляет пользователю следующие компоненты:
* интерфейс IFigure с методом CalculateArea;
* класс Cirlce : IFigure;
* класс Triangle : IFigure и его базовый класс Polygon;
* классы, описывающие то, чем задаются фигуры: Radius и FigureSide, а также их базовый класс LineSegment;
* классы исключений: FigureConstructorException, RadiusException, FigureSideException,  LineSegmentException.

Написаны юнит-тесты для большинства методов.

Простота добавления новых геометрических фигур обеспечивается за счёт интерфейса IFigure, классов, описывающих составные части фигур: Radius и FigureSide и базовых классов Polygon, LineSegment.

Вычисление площади фигур без привязки к конкретному типу обеспечивается за счёт реализации классами фигур интерфеса IFigure, описывающего метод для вычисления площади фигуры.

Проверка на правильность треугольника реализована методом CheckRightTriangle класса Triangle.

Диаграмма классов:
<code>![Диаграмма классов](https://github.com/mshat/FigureArea/blob/master/ClassDiagram.png)</code>
### Вопрос 3


### Вопрос 4


