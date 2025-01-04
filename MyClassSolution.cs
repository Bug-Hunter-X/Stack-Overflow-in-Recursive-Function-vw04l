public class MyClass {
    public int MyMethod(int a, int b) {
        if (a == 0) {
            return b; 
        }
        if (a < 0) {
            return b; //Add a condition to prevent negative a
        }
        if (a > 1000) { //Add a maximum recursion depth
            return b;   
        }
        return MyMethod(a - 1, a + b); 
    }
}