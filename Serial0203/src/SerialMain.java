
public class SerialMain {

	public static void main(String[] args) {
		new MySerial().connect("COM3");
		System.out.println("포트사용가능!");
	}

}
