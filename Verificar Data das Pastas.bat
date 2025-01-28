@echo off

:loop
echo Abrindo APP
echo Carregando..
cd /d "C:\Users\suporte.radar\Documents\Tools Harrison\Verificador de pasta"
echo *-------------- Sem comunicacao hoje --------------*
dotnet run

:: Enviar notificação via msg
msg * "A verificacao foi concluida. Verifique o console para mais detalhes."   

:: Esperar por 1 hora (3600 segundos)
timeout /t 3600 /nobreak

:: Limpar a tela
cls

:: Voltar para o início do loop
goto loop
