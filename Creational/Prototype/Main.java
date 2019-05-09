import java.util.Date;


public class Main {
	public static void main(String[] args) throws CloneNotSupportedException {
		Prototype.ObjectA typeA = new Prototype.ObjectA();
		typeA.setPropertyA(new Date().toLocaleString());
		System.out.println(typeA.getPropertyA());
		Prototype.ObjectA typeClone = typeA.clone();
		System.out.println(typeClone.getPropertyA());
		Prototype.ObjectA typeNew = new Prototype.ObjectA();
		typeNew.setPropertyA(new Date().toGMTString());
		System.out.println(typeNew.getPropertyA());
	}

}
