public class Introduction {

    // Entry point of the program
    public static void main(String[] args) {
        // Print a welcome message
        System.out.println("Welcome to Java!");

        // Declare and initialize variables
        int number = 10;
        String name = "Alice";

        // Print the variables
        System.out.println("Number: " + number);
        System.out.println("Name: " + name);

        // Use a loop to print numbers from 1 to 5
        System.out.println("Printing numbers from 1 to 5:");
        for (int i = 1; i <= 5; i++) {
            System.out.print(i + " ");
        }
        System.out.println();

        // Use a conditional statement to check if a number is even or odd
        int checkNumber = 7;
        if (checkNumber % 2 == 0) {
            System.out.println(checkNumber + " is even.");
        } else {
            System.out.println(checkNumber + " is odd.");
        }

        // Call a function to calculate the square of a number
        int squareResult = square(4);
        System.out.println("Square of 4 is: " + squareResult);
    }

    // Function to calculate the square of a number
    public static int square(int num) {
        return num * num;
    }
}
