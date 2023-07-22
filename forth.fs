\ Fibonacci function
: next-pair ( n1 n2 -- n2 n3 ) 
	tuck + ;
: fib ( n -- fib_n ) 
	dup 1 > if \ fib_0 = 0, fib_1 = 1, so do nothing
		0 1 rot 2 ( n -- 0 1 n 2 )
		?do next-pair loop 
		+ 
	then ;

\ Euclidean algorithm
: gcd ( n1 n2 -- gcd )
	?dup if
		tuck mod recurse
	then ;
