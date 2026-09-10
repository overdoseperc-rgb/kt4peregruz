# КТ №4 — Вариант 1 — Balance
## Проект для Microsoft Visual Studio

Проект предназначен для открытия в **Microsoft Visual Studio 2022/2026** с установленным .NET 10 SDK.

### Как открыть

1. Распакуйте архив.
2. Откройте файл **KT4_Balance.sln** двойным щелчком.
3. В Visual Studio откроется Solution с проектом `KT4_Balance`.
4. В обозревателе решений откройте `Program.cs`.
5. Запустите через **Ctrl + F5** или зелёную кнопку запуска.

### Реализовано

- `Balance(decimal amount)`
- `operator ==`
- `operator !=`
- `Equals()`
- `GetHashCode()`
- `operator <`
- `operator >`
- `operator <=`
- `operator >=`
- `operator true`
- `operator false`
- `ToString()`

### Проверка из задания

`b1 = new Balance(100m)`

`b2 = new Balance(100m)`

`b3 = new Balance(-50m)`

Ожидается:

- `b1 == b2` → `True`
- `b1 == b3` → `False`
- `b1 > b3` → `True`
- `if (b1)` → срабатывает
- `if (b3)` → не срабатывает
