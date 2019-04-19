This is to demonstrate a regression in EntityFrameworkCore 2.1.

To date, no version of EntityFrameworkCore supports ambient transactions with SQLite databases.

In EntityFrameworkCore 2.0 it was possible to just ignore any ambient transaction, which could be useful in some cases. However, in EntityFrameworkCore 2.1 and later, although EntityFrameworkCore recognizes that ambient transactions are not supported and gives the same warning, ignoring the warning just gives a NotSupportedException and does not allow you to ignore the ambient transaction.
