public class MyClass {
    public int MyMethod(int a, int b) {
        if (a == 0) {
            return b; 
        }
        return MyMethod(a - 1, a + b); 
    }
}