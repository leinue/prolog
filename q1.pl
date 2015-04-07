zero(1,N):-N=0.

square(0,[]).
square(Total,Num):-
Total is Num*Num.

square_list([],[]).
square_list([H|T],[R1|R2]):-
square(V,H),
R1=V,
square_list(T,R2).

sum(0,[]).
sum(Total,[Head|Tail]):- 
sum(Sum,Tail),
Total is Sum + Head.

eq_div3or5([],[]).
eq_div3or5([A|B],[H|T]):-
R is A mod 3,
R is 0,
H=A,
eq_div3or5(B,T).

sumeq_div3or5([],0).
sumeq_div3or5([H|B],R):-
eq_div3or5([H|B],T),
square_list(T,V),
sum(R,V).