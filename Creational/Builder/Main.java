import java.util.Date;
public class Main {
	public static void main(String[] args) {
		UserBuilder.User user = new UserBuilder.User();
		user.age(20).firstName("Kian").lastName("Rad").eMail("gmail.com").phoneNumber("999-999-9999");
		UserBuilder newUser = user.getUser();
		System.out.print(newUser.getFullName());
		System.out.print(newUser.getEmail());
	}
}
