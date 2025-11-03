CREATE TABLE exsidmit_logininfo (
	UserID INT PRIMARY KEY IDENTITY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    UserPassword VARCHAR(255) NOT NULL
);

-- Test accounts
INSERT INTO exsidmit_logininfo (Username, UserPassword) VALUES ('admin', '1234');
INSERT INTO exsidmit_logininfo (Username, UserPassword) VALUES ('student', 'abcd');
INSERT INTO exsidmit_logininfo (Username, UserPassword) VALUES ('dangate', 'cute');
INSERT INTO exsidmit_logininfo (Username, UserPassword) VALUES ('billgwapokatalagakainiskangtaoka','joke');
INSERT INTO exsidmit_logininfo (Username, UserPassword) VALUES ('cutiecakes','joke');
INSERT INTO exsidmit_logininfo (Username, UserPassword) VALUES ('eriesgunagwapo','totoo');

