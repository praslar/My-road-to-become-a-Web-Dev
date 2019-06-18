domains		% dinh nghia kieu du lieu
	s = symbol
	i = integer
predicates	% khai bao cac vi tu
	cha(s,s)
	me(s,s)
	tuoi(s,i)
	nam(s)
	nu(s)
	ace(s,s)
	
clauses		
	cha(ong1, bo2).
	cha(ong1, me1).
	cha(ong1, di).
	cha(ong2, chu).
	cha(ong2, bo1).
	cha(ong2, me2).
	cha(bo1, contrai1).
	cha(bo1, congai1).
	cha(chu, contrai3).
	cha(bo2, contrai2).
	cha(bo2, congai2).
	
	me(ba1, bo2).
	me(ba1, me1).
	me(ba1, di).
	me(ba2, chu).
	me(ba2, bo1).
	me(ba2, me2).
	me(me1, contrai1).
	me(me1, congai1).
	me(di, congai3).
	me(me2, contrai2).
	me(me2, congai2).
	
	nam_sinh(ong1, 1900).
	nam_sinh(ong2, 1901).
	nam_sinh(bo1, 1930).
	nam_sinh(chu, 1935).
	nam_sinh(bo2, 1940).
	nam_sinh(ba1, 1905).
	nam_sinh(ba2, 1910).
	nam_sinh(di, 1945).
	nam_sinh(me1, 1945).
	nam_sinh(me2, 1943).
	nam_sinh(contrai1, 1970).
	nam_sinh(congai1, 1985).
	nam_sinh(congai3, 1975).
	nam_sinh(contrai2, 1980).
	nam_sinh(contrai3, 1982).
	nam_sinh(congai2, 1990).
	