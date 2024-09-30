namespace OOP.OOP_Principles.Encapsulation;

// BankAccount class uses encapsulation to hide the internal state of the object
public class BankAccount
{
    private decimal _balance;

    public void Deposit(decimal depositAmount)
    {
        if (depositAmount <= 0)
        {
            throw new ArgumentException("Deposit amount cannot be negative");
        }
        
        _balance += depositAmount;
    }
    
    public void Withdraw(decimal withDrawAmount)
    {
        if (withDrawAmount <= 0)
        {
            throw new ArgumentException("Amount cannot be negative");
        }
        
        if (_balance < withDrawAmount)
        {
            throw new ArgumentException("Insufficient funds");
        }

        _balance -= withDrawAmount;
    }
    
    public decimal GetBalance()
    {
        return _balance;
    }
}