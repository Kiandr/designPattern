
public class Prototype {
    
	public static class ObjectA implements Cloneable{
		private String propertyA; 
		private String propertyB;
		public String getPropertyA() {
			return propertyA;
		}
		public void setPropertyA(String propertyA) {
			this.propertyA = propertyA;
		}
		public String getPropertyB() {
			return propertyB;
		}
		public void setPropertyB(String propertyB) {
			this.propertyB = propertyB;
		}
		public ObjectA clone() throws CloneNotSupportedException {
			return (ObjectA) super.clone();
		}
		}
	}
