### ความเป็นมา
###


 Form1 <|-- Data
    Form1 <|-- Filecsv
    Data <|-- Calculator
    Form1 : -void BTexpenses_Click()
    Form1 : -void BTrevenue_Click()
    Form1: -void tbmemo_Click()
    Form1: -void NUM1_Click()
    Form1: -void NUM2_Click()
    Form1: -void NUM3_Click()
    Form1: -void NUM4_Click()
    Form1: -void NUM5_Click()
    Form1: -void NUM6_Click()
    Form1: -void NUM7_Click()
    Form1: -void NUM8_Click()
    Form1: -void NUM9_Click()
    Form1: -void NUM0_Click()
    class Data{
        +int number;
        +string day;
        +string schedule;
        +int revenue;
        +int expenses;
        +int remain ;
    }
    
    class Filecsv{
        +bool wrifile()
        +string sort
        +string Path
    }
    
    class Calculator{
        +int addcount
        +int Remain
        +void sumofrev()
        +void sumofexp()
        +int expenses
        +int revenue
    }