# include <iostream>
int main() {

  char sign;
  float num1, num2;

  std::cout << "Enter operator: +, -, *, /: ";
  std::cin >> sign;

  std::cout << "Enter two operands: ";
  std::cin >> num1 >> num2;

  switch(sign) {

    case '+':
      std::cout << num1 << " + " << num2 << " = " << num1 + num2;
      break;

    case '-':
      std::cout << num1 << " - " << num2 << " = " << num1 - num2;
      break;

    case '*':
      std::cout << num1 << " * " << num2 << " = " << num1 * num2;
      break;

    case '/':
      std::cout << num1 << " / " << num2 << " = " << num1 / num2;
      break;

    default:
      std::cout << "Error!Choose one of these operators:+, -, *, /";
      break;
  }

  return 0;
}