«адание Ђ онтрольна€ точка є4 Ч перегрузка операторов отношени€ и true/falseї

¬ариант 1. Balance (баланс счЄта)
 ласс Balance хранит сумму на счЄте (decimal Amount).
 онструктор Balance(decimal amount).
operator ==, operator != Ч сравнение по значению Amount. ѕереопределите Equals и GetHashCode.
operator <, operator >, operator <=, operator >= Ч сравнение по значению Amount.
operator true Ч баланс положительный (Amount > 0); operator false Ч баланс не положительный.
ѕереопределите ToString(), например: "125,50 руб.".

![код класса Balance](Code2.png)
![код Program и результат](BalanceCode+Results.png)