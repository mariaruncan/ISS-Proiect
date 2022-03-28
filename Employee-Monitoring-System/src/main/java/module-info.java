module com.example.employeemonitoringsystem {
    requires javafx.controls;
    requires javafx.fxml;
    requires javafx.graphics;


    opens com.example.employeemonitoringsystem to javafx.fxml;
    exports com.example.employeemonitoringsystem;
}