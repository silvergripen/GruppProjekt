![Group_Project__Bank_appHeader4](https://user-images.githubusercontent.com/105611442/204922422-a20169fd-4967-4ccf-9a9d-2484a0e46f24.png)


![GitHub top language](https://img.shields.io/github/languages/top/silvergripen/GruppProjekt?style=plastic)
![GitHub last commit](https://img.shields.io/github/last-commit/silvergripen/GruppProjekt?style=plastic)

**This is the start of a simple bank console app with an arrow selection menu where you can log in and create new customers as an admin,
open new accounts as a customer and get a list of your accounts with the balance shown.**


![PearBankGif_LogIn](https://user-images.githubusercontent.com/105611442/205093863-4861abd9-151b-4200-b3b6-079f35042c8e.gif)


## Usage

`Admin social security number: 123` `Admin password: 0000`

First you need to log in as an admin to create your first customer.
Then you can log out and log in again as a customer.
**<br>NOTE! When you log out as a customer the list of customers will reset
and you'll have to re-add new customers in the admin menu again.**
- You have 3 tries to enter the correct password when you log in.
- You have 3 tries when you re-enter the social security number when opening a new account.


## Backlog

- The app has nice, clear menus, coloring and a logo in ASCII-art
- Every user can log in with a unique username and password
- Admin can create new users
- Only 3 tries allowed when logging in
- Customers can open new accounts
- Customers can view a list of their accounts and the balance
- Customers can open new savings accounts and see the interest rate

## Structure - classes etc.

### Account class
Holds the basic variables needed for all accounts.

### Admin class - Inherits from User
Holds variables for input from admin when adding new customers.<br>
With the method:
- `AddCustomer()` - adds the new customers to the `List<Customer> userList` in the **User** class.

### Application class
Constains the different menus and similar small methods plus the ASCII-logo.<br>
With the methods:
- `Start()`
- `LoginScreen()`
- `RunCustomerMenu()`
- `RunAdminMenu()`
- `AddAccountMenu()`
- `LoggingOut()` - Logging out the user
- `ExitApp()`
- `OutOfTries()` - Restarts the program when user is out of tries
- `Logo()`

### CheckingAccount class - Inherits from Account
Has a `Constructor` that holds the clearing number and account balance.<br>
With the method: 
- `NewCheckingAccount()` - creates a new checking account.

### Customer class - Inherits from User
Has `List<CheckingAccount> CheckingAccountList` and `List<SavingsAccount> SavingsAccountList`.<br>
With the methods:
- `AddCheckingAccount()` - creates account and adds it to the list.
- `AddSavingsAccount()` - creates account and adds it to the list.
- `CheckingPersonNr()` - checks if the social security number exists in the `List<Customer> userList`<br>
- `ListOfAccounts()`

![PearBankAccounts](https://user-images.githubusercontent.com/105611442/205067220-dced0a40-4f27-4649-bc30-c1940863bea4.jpg)


### Menu class
Has the variables for creating the menus aswell as a `Constructor` that enables the usage of those variables.<br>
With the methods:
- `DisplayOptions()` - shows the options of the menu.
- `Run()` - runs the menu and enables the usage of the arrow keys to navigate the menu.

### Program class
Has the `Start()` method from the **Application** class that starts the whole application.

### SavingsAccount class - Inherits from Account
Has the variable for the savings rates aswell as a `Constructor` with the clearing number and account balance.<br>
With the method: 
- `NewSavingsAccount()` - creates a new savings account.

### User class
Holds the basic variables needed for all users aswell as the `List<Customer> userList`.<br>
With the methods:
- `ValidatePassword()` - Checks if the password matches the social security number.
- `AdminUser()` - Creates the admin user.
- `VerifyLogin()` - Checks if the user is able to log in with their three tries.
- `ValidateAdmin`- Checks if the user is a admin.
