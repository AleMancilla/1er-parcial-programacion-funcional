from pyswip import Prolog
prolog = Prolog()

prolog.assertz("padre(Alejandro, Jorge)")
prolog.assertz("padre(Alejandro, Mari)")
prolog.assertz("padre(Jorge, Franco)")
prolog.assertz("padre(Jorge, Sindy)")
prolog.assertz("padre(Fernando, Jesus)")
prolog.assertz("padre(Fernando, Lucia)")
prolog.assertz("madre(Ester, Jorge)") 
prolog.assertz("madre(Ester, Mari)")
prolog.assertz("madre(Veronica, Franco)")
prolog.assertz("madre(Veronica, Sindy)")
prolog.assertz("madre(Mari, Jesus)")
prolog.assertz("madre(Mari, Lucia)")
prolog.assertz("abuelos(X,Y,Z) :- (padre(A,Z); madre(A,Z)), (padre(X,A), madre(Y,A))")
prolog.assertz("nietos(X,Y,Z) :- (padre(A,X); madre(A,X)), (padre(Y,A), madre(Z,A))")
prolog.assertz("primos(X,Y) :- (padre(A1,X); madre(A1,X)),(padre(A2,Y); madre(A2,Y)),(padre(P,A1), padre(P,A2), madre(M,A1), madre(M,A2)), X\=Y, A1\=A2")


for elementos in prolog.query("abuelos(X, Y, Z)"):
	print(elementos["X"]," y ", elementos["Y"] ," son los abuelos de ",elementos["Z"])

print("\n")
for elementos in prolog.query("nietos(X, Y, Z)"):
	print(elementos["X"]," es nieto de ", elementos["Y"] ," y ",elementos["Z"])

print("\n")
for elementos in prolog.query("primos(X, Y)"):
	print(elementos["X"]," es primo de ", elementos["Y"])
