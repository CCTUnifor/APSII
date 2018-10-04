
public aspect CreditarAspect {
	pointcut creditarPointCut(): execution (void Conta.creditar(double));
	
	before(): creditarPointCut () {
		System.out.println("Vai creditar ");
	}
	
	after(): creditarPointCut () {
		System.out.println("Creditou ");
	}
}
