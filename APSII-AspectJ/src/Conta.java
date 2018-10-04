public class Conta {
	private String numero;
	private double saldo = 0.0;

	public Conta(String numero) {
		this.numero = numero;
	}

	public void creditar (double valor){ 
		saldo += valor;
	}

	public void debitar (double valor){
		System.out.println(" Vai debitar ");
		saldo -= valor;
		System.out.println("Debitou ");
	}

	public String getNumero() {
		return numero;
	}

	public double getSaldo() {
		return saldo;
	}

	public static void main (String[] args){
		
	}
}
