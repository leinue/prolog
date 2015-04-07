log_table([],[]).
log_table([A|B], [H|T]) :-
Log is log(A),
H=[A,Log],
log_table(B,T).