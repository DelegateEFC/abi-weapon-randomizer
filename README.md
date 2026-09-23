# ABI Weapon Randomizer

Aplikacja full-stack losująca zestaw broni i akcesoriów (na wzór loadout randomizera z gier FPS), z historią rozgrywek i autorskim algorytmem ważonej losowości - projekt stworzony w celach edukacyjnych, do nauki łączenia backendu (ASP.NET Core) z frontendem (Vue.js) oraz projektowania własnej logiki biznesowej.

## Funkcjonalność

- Losowanie broni wraz z kompletem akcesoriów dla każdego z pięciu slotów
- Zapisywanie wyniku rundy i historii losowań
- Ważony algorytm losowania: broń z ostatniej wygranej rundy ma znacznie obniżoną szansę na ponowne wylosowanie a z przegranej ma umiarkowanie obniżoną, przywracaną szybciej niż po wygranej
- Podgląd aktualnych wag wszystkich broni (opcjonalny checkbox)
- Historia rozgrywek
- Dane zapisywane trwale w bazie SQLite

## Technologie

**Backend:**

- ASP.NET Core Web API (.NET 8)
- Entity Framework Core + SQLite
- Relacja wiele-do-wielu z kluczem złożonym (broń ↔ akcesoria)
- DTO do bezpiecznej serializacji JSON (bez cykli w relacjach nawigacyjnych)

**Frontend:**

- Vue.js 3 (Composition API, `<script setup>`)
- Komunikacja z API przez fetch
- Reaktywny stan gry (ref) sterujący widokiem (losowanie → decyzja → zapis)

## Jak uruchomić

### Wymagania

- .NET 8 SDK
- Node.js + npm

### Backend

```
cd BackendRandomizer/BackendRandomizer
dotnet ef database update
dotnet run --launch-profile https
```
Backend wystartuje na 'http://localhost:7102'

### Frontend

```
cd FtontendRandomizer
npm.cmd install
npm.cmd run dev
```
Frontend wystartuje na 'http://localhost:5173' <-- TO WPISUJEMY W PRZEGLĄDARCE PO WYSTARTOWANIU FRONTENDU I BACKENDU.

### Albo oba naraz (Windows)
```
cd FrontendRandomizer
npm.cmd install
```
```
cd BackendRandomizer/BackendRandomizer
dotnet ef database update
```

Uruchom `start.bat` w folderze głównym - odpali oba serwery w osobnych oknach terminala.

## Struktura projektu

```
ABIWeaponRandomizer/
├── BackendRandomizer/ # ASP.NET Core Web API
├── FrontendRandomizer/ # Vue.js
└── start.bat # skrypt uruchamiający oba serwery naraz
```

## Czego się nauczyłem

- Projektowanie własnego algorytmu ważonej losowości na podstawie historii danych
- Relacje wiele-do-wielu z kluczem złożonym w EFC
- Migracje EF Core przy rozwijaniu modelu danych w trakcie pracy z projektem
- Konkretniej odnośnie reaktywności w Vue (ref) i komunikacji z API przez fetch
