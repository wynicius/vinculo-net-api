echo off
echo Setando variáveis de ambiente...
set DB_SERVER=localhost
set DB_PORT=5433
set DB_USER=postgres
set DB_PASSWORD=1234
set DB_DATABASE=vinculo
set DB_POOLING=true

set KEYCLOACK_AUTHORITY=https://sso.blue.com.br/realms/dev
set KEYCLOACK_AUDIENCE=account
set URL_AUTORIZACAO=http://localhost:5000/api/administracao/autenticacao/autorizar

set ASPNETCORE_ENVIRONMENT=Development
set ASPNETCORE_URLS=http://*:5001

@REM set SOLICITACOES_ANEXOS_PATH=wwwroot\\solicitacoes
@REM set SOLICITACOES_ANEXOS_PATH=wwwroot\\solicitacoes

@REM set URL_SERVICO_FATURA=http://10.1.2.19:8081/faturas
set DB_INTERFACE_LEGADO_SERVER=localhost
set DB_INTERFACE_LEGADO_PORT=5433
set DB_INTERFACE_LEGADO_USER=postgres
set DB_INTERFACE_LEGADO_PASSWORD=1234
set DB_INTERFACE_LEGADO_DATABASE=vinculo-v1

echo Limpando cache...
dotnet clean

echo Buscando packages...
dotnet restore

echo Iniciando a API...
dotnet watch run --no-hot-reload
