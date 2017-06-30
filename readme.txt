Для корректной работы приложения необходимы следующие компоненты:
.NET Framework 4.5 
Локальный SQL Server с именем "(local)": при необходимости имя сервера для работы приложения можно изменить в файлах Bank.exe.config и Bank.vshost.exe.config в строке подключения:
        <add name="Bank.Properties.Settings.BankConnectionString" connectionString="Data Source=(local);Initial Catalog=Bank;Integrated Security=True"

Для демонстрации прилагается скрипт Create Database Tables Inserts_for_Bank.sql, который создаёт БД для дальнейшей работы в ней.
Скрипт выполняется Microsoft SQL Server Management Studio при предварительном подключении к локальному SQL Server'у с именем "(local)".

Логирование в приложении осуществляется при помощи Logger'а NLog, все логи пишутся в папку Content - Logs.