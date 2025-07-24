# RevenueApp

Aplikacja do zarządzania i przeprowadzania analiz przychodów firmy zajmującej się sprzedażą software'u. 

## Funckje

W łatwy sposób użytkownik (zależnie od roli) może:
- bezpiecznie się zarejestrować, zalogować,
- stworzyć kontrakt na dany software oraz dodać do niego płatności,
- zwrócić przychody realne lub przewidywane dla wszystkich lub wybranych produktów,
- dodać, usunąć klienta prywatnego lub klienta-firmę,
- zaktualizować informacje o klientach,
- kilka przykładowych testów jednostkowych.

## Instrukcje

Gdy chcesz uruchomić ten program, to:
- zwróć uwagę na to co zapisałem w Uwagach,
- dla własnego użytku postaw bazę danych MSSql na Dockerze, a następnie dokonaj migracji w celu stworzenia bazy danych na nim,
- komendy pomocne przy migracjach:
```c
dotnet new tool-manifest
```
```c
dotnet tool install dotnet-ef
```
```c
dotnet ef migrations add Init
```
```c
dotnet ef database update
```

## Uwagi

- pamiętaj, aby w appsettings.json zmienić ConnectionStrings na taki, jaki Ci będzie pasował (ja korzystałem z localhosta postawionego na Dockerze) oraz SecretKey, który służy do hashowania hasła,
- korzystałem z Postmana, jak chcesz korzystać ze Swaggera, to usuń komentarze z launchSetting.json,
- pamiętaj, aby po udanym zalogowaniu podać bearerToken, taki jaki Ci zostanie zwrócony,
- dostępne role to zwykły użytkownik oraz admin.

## Planowane zmiany

- panel frontend'owy,
- eksport danych do plików CSV,
- resetowanie hasła,
- dodanie pozostałych testów jednostkowych i integracyjnych.
