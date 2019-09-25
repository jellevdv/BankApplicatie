using System;

namespace BankApplicatie.Domein {
   
    public class BankAccount {
        #region Fields & Properties
        //field altijd met underscore laten beginnen
        //field is private iets+getter+setter
        private decimal _balance;
        // public const int Cost=2; //1x waarde aan toekennen, id declaratie, niet meer id constructor, met Hoofdletter
        // private readonly int _costReadOnly = 3; //zoals final in java, 1x te verklaren in de constructor 

        public string AccountNumber { get; }


        //beter properties (prop tab tab)
        //ipv get en set maak je direct gebruik van de property
        public decimal Balance {
            get { return _balance; }
            private set { //anders neemt hij de "public" over van Balance
                if (value < 0)
                    throw new ArgumentException("Balance cannot be negative");
                else
                    //Balance = value;==> is recursie want binnen Balance verwis je terug nr Balance
                    //daarom gebruik maken van _balance
                    _balance = value;
                ;
            }
        }
        #endregion

        #region Constructor
        //constructor=> ctor tab tab
        //public BankAccount(string accountNumber) : this(accountNumber,0) {
        //    //door : this een andere constructor aanroepen, zoals in java this.
        //    //je roept de onderstaande constructor aan (zonder de =0)
        //}


        //ctrl K+S
        public BankAccount(string accountNumber, decimal initialBalance = 0) {
            //moest je optionele derde parameter extra gebruiken dan:
            //declaren in programma als BankAcc ba3=new BankAcc("dqzdzqd",derde: 200);
            //door die =0 wordt initalBalance een otpionele parameter,
            //je mag er een waarde voor meegeven, indien je geen meegeeft wordt gewoon 0 gebruikt
            AccountNumber = accountNumber;
            Balance = initialBalance;
            //  _costReadOnly = 3;
        }
        #endregion

        #region Methods
        public void Deposit(decimal amount) {
            //Balance= Balance+amount; zowel get als set gebruik je hier
            if (amount <= 0) {
                throw new ArgumentException("Amount cannot be negative");
            }
            Balance += amount;
        }
        public void Withdraw(decimal amount) {
            if (amount <= 0) {
                throw new ArgumentException("Amount cannot be negative");
            }
            Balance -= amount;
        }
        #endregion




    }
}
