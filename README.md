# Требования к задаче
Создание приложения «Кулинарные заметки»
1. Регистрация пользователя через логин и пароль.
2. Авторизация пользователя через логин и пароль.
3. Профиль пользователя содержит фамилию, имя, дату рождения, ник.
4. Пользователь может:
   1) добавлять рецепт
   2) редактировать рецепт
   3) удалять рецепт
   4) сортировать рецепты по: виду кухни, времени приема пищи, способу приготовления, времени приготовления.
5. Запись о рецепте содержит: вид кухни, ингридиенты, время приготовления, способ приготовления.

![image](https://user-images.githubusercontent.com/113845482/201172784-4b361fd0-333f-46cc-ba9a-6e5831fa2a23.png)

Таблица user содержит информацию о пользователе:
1. id-pk
2. логин
3. пароль
4. фамилия, имя, отчество
5. ник
6. дата рождения

Таблица recipe содержит информацию о рецепте:
1. id-pk
2. время приготовления
3. название

Таблица ingredient содержит информацию о ингридиентах, которые используются в рецепте:
1. id-pk
2. название
3. вес

Таблица type_of_kitchen содержит информацию о видах кухни:
1. id-pk
2. название (русская кухня, французская кухня, итальянская кухня, азиатская кухня)

Таблица meal_time содержит информацию о времени приема еды:
1. id-pk
2. название (завтрак, обед, полдник, ужин)

Таблица cooking_method содержит информацию о способе приготовления еды:
1. id-pk
2. название (жареные, вареные, тушеные, печеные)
