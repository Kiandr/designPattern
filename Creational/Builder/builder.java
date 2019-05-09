public class UserBuilder {
    public static class User {
        private String firstName;
        private String lastName;
        private String eMail;
        private String phoneNumber;
        private Integer age;
        public User() {}
		public UserBuilder getUser() {return new UserBuilder(this);}
        public User firstName(String aString){ this.firstName = aString; return this;}
        public User lastName(String aString){ this.lastName = aString; return this;}
        public User eMail(String aString){ this.eMail = aString; return this;}
        public User phoneNumber(String aString){ this.phoneNumber = aString; return this;}
        public User age(Integer aInteger){ this.age = aInteger; return this;}
	    }

	    private String firstName;
	    private String lastName;
	    private String eMail;
	    private String phoneNumber;
	    private Integer age;
	    public UserBuilder(User aUser){
	    this.firstName = aUser.firstName;
	    this.lastName = aUser.lastName;
	    this.eMail = aUser.eMail;
	    this.phoneNumber = aUser.phoneNumber;
	    this.age = aUser.age; }
	    public String getFullName() {return (this.firstName + " " + this.lastName);}
	    public String getEmail() {return this.firstName+"."+this.lastName+"@"+this.eMail;}
				
    }




