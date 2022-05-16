## Docker
# docker start sqlserver

# ef banco de dados relacional

# 1 - ADICIONAR OS PACOTES
# 2 - CRIAR CLASSE CONFIGURADORA
# 3 - SERVIÇOS DO ASPNET

## Essencial para rodar o Entity
# dotnet add package Microsoft.EntityFrameworkCore
# dotnet add package Microsoft.EntityFrameworkCore.Design
# dotnet add package Microsoft.EntityFrameworkCore.SqlServer
# dotnet tool install --global dotnet-ef
# dotnet ef migrations add CreateProduct
# dotnet ef migrations remove
# dotnet ef database update
# dotnet ef database update 20220512142311_CreateProduct -> voltar uma versão no ef

# dotnet tool install --global dotnet-outdated-tool
# dotnet outdated --upgrade -> verificar se existe atualização de pacotes nuget

# dotnet build

# select * from [dbo].[__EFMigrationsHistory] -> tabela para verificar todas migrations no banco de dados
# DTO -> DATA TRANSFERER OBJECT
#
#
#
