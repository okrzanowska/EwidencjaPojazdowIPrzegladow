# 🚗 Ewidencja Pojazdów i Przeglądów

Projekt studencki realizowany w ramach zajęć z projektowania interfejsów użytkownika. System służy do zarządzania bazą pojazdów oraz monitorowania terminów przeglądów technicznych.

## 📋 Opis projektu

Projekt składa się z czterech etapów, demonstrujących różne technologie i podejścia do tworzenia aplikacji:
- **ETAP 1-2**: Aplikacja desktopowa (WinForms) z generowaniem raportów
- **ETAP 3-4**: Aplikacja webowa (Bootstrap) z responsywnym interfejsem

## 🎯 Etapy realizacji

### ETAP 1 – Zapoznanie z Visual Studio i WinForms
**Temat**: Projektowanie interfejsu użytkownika dla WinForms

#### Zakres:
- ✅ Utworzenie projektu `EwidencjaPojazdow`
- ✅ Formularz z polami:
  - Nr rejestracyjny
  - Marka
  - Model
  - Rok produkcji
  - Data przeglądu
  - Właściciel
- ✅ Przycisk "Dodaj pojazd"
- ✅ Tabela (DataGridView) z listą pojazdów
- ✅ Obsługa zdarzenia Click przy dodawaniu pojazdu

---

### ETAP 2 – Budowa raportu w Visual Studio
**Temat**: Tworzenie raportów w ReportViewer / RDLC

#### Zakres:
- ✅ Generowanie raportu "Lista pojazdów z przeglądem do wykonania w tym miesiącu"
- ✅ Raport zawiera:
  - Nr rejestracyjny
  - Marka
  - Właściciel
  - Data przeglądu
- ✅ Możliwość eksportu raportu do PDF

---

### ETAP 3 – Visual Studio Code i Bootstrap
**Temat**: Budowa GUI w Bootstrap

#### Zakres:
- ✅ Strona HTML z Bootstrap 5
- ✅ Tabela z listą pojazdów
- ✅ Formularz dodawania nowego pojazdu (w modalu)
- ✅ Przyciski: Dodaj, Edytuj, Usuń
- ✅ Stylizacja formularza i tabeli przy pomocy Bootstrap

---

### ETAP 4 – Zaawansowane formularze w Bootstrap
**Temat**: Formularze z walidacją i modalami

#### Zakres:
- ✅ Walidacja pól (numer rejestracyjny, rok, daty)
- ✅ Modal z potwierdzeniem usunięcia pojazdu
- ✅ Dynamiczne alerty o sukcesie / błędzie
- ✅ Responsywność (układ działa na telefonach)

## 🛠️ Technologie

### ETAP 1-2
- C# .NET Framework
- Windows Forms (WinForms)
- ReportViewer / RDLC
- DataSet & LINQ
- Visual Studio 2022

### ETAP 3-4
- HTML5
- CSS3
- Bootstrap 5
- JavaScript
- Visual Studio Code
