domains		% dinh nghia kieu du lieu
	s = symbol
predicates	% khai bao cac vi tu
	chet(s)
	nguoi(s)
clauses		
	%liet ke cac su kien
	nguoi(meo).
	nguoi("Tinh").
	nguoi("Socrates").
	
	%liet ke cac quy tac: luat keo theo tren cac vi tu chi co 1 ket luan
	chet(Ai) :- nguoi(Ai).
	