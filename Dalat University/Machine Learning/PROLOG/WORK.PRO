%trace
domains
	i = integer
	ds = i*
predicates
	nhap (ds)
	xuat (ds)
clauses
	nhap ([D|Cuoi]) :-
		readint (D), 
		D > 0, !,
		nhap (Cuoi).
	nhap ([]).
	
	xuat ([]).
	xuat ([D | Cuoi]) :- 
		write (D, " "),
		xuat (Cuoi).
goal
	clearwindow(),
	nhap (L1), xuat (L1),
	nhap (L2), xuat (L2).