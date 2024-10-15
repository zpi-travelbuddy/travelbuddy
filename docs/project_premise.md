# **Fiszka Projektowa (Project Premise)**

## 1. Tytuł Projektu
Aplikacja mobilna do planowania spersonalizowanego zwiedzania zabytków, atrakcji turystycznych i miejsc kulturalnych z uwzględnieniem preferencji, ograniczeń czasowych i budżetowych.

## 2. Akronim
TravelBuddy

## 3. Lista Członków Zespołu
- Igor Banaszak  
- Adrian Broniecki  
- Bartosz Gableta  
- Mateusz Gazda  

## 4. Opiekun Zespołu
dr inż. Marcin Kawalerowicz

## 5. Syntetyczny Opis Projektu
Główne funkcjonalności aplikacji obejmują:
- **Umożliwienie spersonalizowanego zwiedzania:**
    - Dostosowanie rekomendacji atrakcji turystycznych do indywidualnych preferencji użytkowników, takich jak rodzaj zabytków, preferencje żywieniowe, zainteresowania kulturalne i tematyczne.
    - Ustawianie preferencji i wymaganych udogodnień dotyczących:
        - niepełnosprawności,
        - posiadania zwierząt,
        - diet (wegetarianizm, weganizm itp.).


- **Łatwe zarządzanie i zapisywanie planów swoich podróży:**
    - Umożliwienie użytkownikom efektywnego planowania wycieczek, uwzględniając ich dostępny czas i budżet
    - Tworzenie i zarządzanie wielodniowymi wycieczkami, w których każdy dzień może zawierać dowolną liczbę punktów wycieczki.
    - Tworzenie i dodawanie punktów wycieczki, wypełniając formularz, wyszukując atrakcje lub wybierając je spośród rekomendacji.
    - Każde wydarzenie może mieć parametry (obliczone na podstawie danych zebranych od użytkowników), takie jak:
        - średni koszt na osobę,
        - średni czas trwania,
        - średnia ocena.
    - Możliwość wprowadzenia przewidywanego kosztu do wydania w konkretnym punkcie wycieczki.
    - Przy tworzeniu planu wycieczki, opcja dodania obiektu typu *Transfer*,  który zawiera informację o szacowanym czasie przejazdu lub automatycznie oblicza tę wartość na podstawie wybranych lokalizacji.


- **Zwiększenie dostępności informacji:**
    - Zapewnienie użytkownikom dostępu do aktualnych informacji na temat atrakcji turystycznych, w tym godzin otwarcia, ich lokalizacji.
    - Umożliwienie użytkownikom dostępu do swoich statystyk dotyczących:
        - liczby wycieczek w roku/miesiącu,
        - liczby odwiedzonych punktów oraz atrakcji turystycznych,
        - najpopularniejszych typów punktów wycieczki,
        - punktów wycieczek i atrakcji z najwyższymi ocenami,
        - całkowitych wydatków i czasu spędzonego na wycieczkach.
    - Możliwość synchronizacji punktów wycieczki z kalendarzem na urządzeniu użytkownika.
    - Możliwość ustawienia powiadomień dla wybranych przez użytkownika punktów wycieczki.


- **Dostosowanie aplikacji do potrzeb osób z niepełnosprawnościami.**
    - Opisy alternatywne dla obrazów i innych elementów graficznych.
    - Opcja zmiany rozmiaru czcionki, aby osoby z wadami wzroku mogły dostosować tekst do swoich potrzeb.
    - Możliwość włączenia trybu wysokiego kontrastu, który ułatwia czytanie dla osób z osłabionym wzrokiem.

- **Możliwość spersonalizowania aplikacji:**
    - Tryb nocny z ciemnym tłem i jasnym tekstem


## 6. Technologie
### Języki programowania:
- **Backend**: C#
- **Frontend**: TypeScript

### Narzędzia:
- Slack
- Jira
- Dysk Google
- GitHub
- Google Docs
- Miro,
- Figma
- Android Studio
- Visual Studio Code

### Technologie:
- **Backend**: .NET 8, ASP.NET Core, Entity Framework Core
- **Frontend**: React Native, HTML5, CSS, Expo Go
- **Baza danych**: Azure SQL Database
- **DevOps**: Docker, Azure

## 7. Roadmapa Projektu

### Etap 1
Pierwszym krokiem w procesie tworzenia naszej aplikacji jest dokładne przygotowanie wszystkich niezbędnych materiałów, które stanowią fundament do rozpoczęcia prac programistycznych. Na tym etapie kluczowe jest, aby opracować dokumentację, określającą wizję, cele oraz zakres planowanej funkcjonalności oraz makiety naszej aplikacji.

**Kamień milowy:**
- Fiszka
- Vision And Scope
- Udokumentowana koncepcja projektu (cele, wizja, funkcjonalności, mockupy UI/UX, diagram architektury systemu, rodzaj wybranych i wykorzystywanych danych z API)

### Etap 2
W tym etapie kluczowym zadaniem jest stworzenie pierwszej, działającej wersji aplikacji, która zawiera minimalny zestaw funkcji potrzebnych do spełnienia podstawowych wymagań użytkowników. Kluczowe jest stworzenie i integracja kluczowych komponentów aplikacji, takich jak interfejs użytkownika, logika backendu oraz połączenia z zewnętrznymi API, które zostały wcześniej zidentyfikowane, oraz zapewnienie, że aplikacja poprawnie korzysta z tych danych.

**Kamień milowy:**  
- Aplikacja gotowa w wersji MVP

### Etap 3
W tym etapie kluczowe jest dopracowanie wszystkich funkcjonalności oraz rozpoczęcie przeprowadzenia testów aplikacji przed jej wdrożeniem. Trzeba zaimplementować i dopracować wszystkie zaplanowane funkcje, integrację z API oraz elementów UI/UX. Należy również dokonać optymalizacji działania aplikacji, poprawy wydajności oraz usunąć drobne błędy. Ważną częścią tego etapu jest także przeprowadzenie testów funkcjonalnych, wydajnościowych oraz testów na różnych urządzeniach. Trzeba zweryfikować poprawność działania aplikacji w realistycznych warunkach użytkowania i upewnić się, że aplikacja jest stabilna i wolna od krytycznych błędów.

**Kamień milowy:**  
- Zaimplementowane i przetestowane co najmniej 70% założonych funkcjonalności
- Zaplanowany i zaimplementowany proces testowania aplikacji


### Etap 4
W tym etapie celem jest dokończenie procesu testowania aplikacji, przygotowanie jej do udostępnienia użytkownikom oraz sporządzenie kompletnej dokumentacji technicznej i użytkowej. Przygotowana dokumentacja zawiera szczegółowe informacje dotyczące architektury aplikacji, baz danych, API, oraz wszelkich niezbędnych konfiguracji systemowych. Również należy zapewnić, że wszystkie serwisy, bazy danych oraz połączenia API są poprawnie skonfigurowane i działają bez zakłóceń.

**Kamień milowy:**  
- Zaimplementowane i przetestowane 100% założonych funkcjonalności
- Wdrożenie aplikacji do sklepu Google Play (aplikacja została wdrożona na środowisku produkcyjnym i jest dostępna co najmniej dla zamkniętej grupy użytkowników)
- Kompletna dokumentacja (pełna dokumentacja techniczna i użytkowa)


## Dodatkowe elementy

### 1. Kluczowe Ryzyka
- **Niedoszacowanie czasu potrzebnego na realizację poszczególnych etapów**  
    - **Opis ryzyka**: Opóźnienia w realizacji, które mogą wystąpić, jeśli zespół nie przewidzi odpowiedniej ilości czasu na kluczowe zadania, takie jak integracja danych czy testowanie aplikacji.
    - **Planowane rozwiązanie**: Tworzenie realistycznych harmonogramów z buforami czasowymi, korzystanie z metodyk zwinnych (Agile) umożliwiających elastyczne dostosowywanie harmonogramu oraz bieżący monitoring postępów projektu.

- **Problemy techniczne z integracją z API:**  
    - **Opis ryzyka**: Integracja z zewnętrznymi systemami może być problematyczna, np. z powodu nieaktualnych lub niekompletnych danych, ograniczeń w liczbie zapytań, czy nagłych zmian w API.
    - **Planowane rozwiązanie**: Wybór sprawdzonych dostawców API, wczesne rozpoczęcie testów integracyjnych oraz stworzenie mechanizmu obsługi błędów i alternatywnych źródeł danych w razie problemów z głównym dostawcą.

- **Problemy z zarządzaniem limitami planów w ramach projektu:**  
    - **Opis ryzyka**: Przekroczenie limitów darmowych planów dostępnych dla studentów może skutkować naliczeniem dodatkowych opłat, co spowoduje konieczność pokrycia nieprzewidzianych kosztów. Ryzyko to może wynikać z niewłaściwego oszacowania zasobów potrzebnych do realizacji projektu lub nadmiernego wykorzystania funkcji, które są płatne po przekroczeniu darmowych progów.
    - **Planowane rozwiązanie**:  Stałe monitorowanie wykorzystania zasobów w ramach darmowych planów, unikanie nadmiernego obciążania aplikacji oraz optymalizacja procesów, aby nie przekraczać dostępnych limitów.

- **Pojawienie się nieprzewidzianych zmian w wymaganiach:**
    - **Opis ryzyka**: Zmiany w wymaganiach mogą wystąpić w trakcie trwania projektu z różnych przyczyn, takich jak zmiany w strategii biznesowej, nowe pomysły dotyczące funkcjonalności
    - **Planowane rozwiązanie**: Wprowadzenie podejścia Agile, które umożliwia elastyczne dostosowywanie się do zmieniających się wymagań (m.in. regularne spotkania zespołu i stosowanie iteracyjnego podejścia opartego o sprinty).


### 2. Założenia i Ograniczenia
#### Założenia:
- **Dostępność danych turystycznych i kulturalnych**
    - Aplikacja będzie korzystać z publicznie dostępnych źródeł danych (np. API z mapami, atrakcjami turystycznymi).
    - Zakładamy, że dane dotyczące atrakcji turystycznych będą dostępne w sposób ciągły i aktualny oraz że nie ulegną nagłym zmianom w trakcie trwania projektu.
    - Nie zakładamy konieczności manualnej aktualizacji tych danych przez zespół.


- **Wsparcie dla urządzeń z systemem Android**
    - Zakładamy, że użytkownicy korzystają głównie ze smartfonów i tabletów, a aplikacja będzie responsywna na różnych rozdzielczościach ekranów.

- **Personalizacja trasy na podstawie preferencji użytkownika**
    - System będzie potrafił sugerować atrakcje turystyczne i kulturalne w oparciu o preferencje użytkownika (np. preferowane typy atrakcji, dostępny czas, budżet).
    - Zakładamy, że algorytm personalizacji opiera się na danych wprowadzonych przez użytkownika oraz zewnętrznych źródłach informacji.

- **Czas realizacji projektu**
    - Zakładamy, że projekt musi zostać zrealizowany w okresie 9 tygodni, co obejmuje wszystkie etapy: analizę, projektowanie, implementację, testowanie i wdrożenie.

- **Feedback od użytkowników**
    - Użytkownicy będą zachęcani do aktywnego wprowadzania i aktualizowania informacji o odwiedzanych miejscach, co pozwoli na budowanie bazy danych opartych na doświadczeniach rzeczywistych.


#### Ograniczenia:
- **Technologiczne:**
    - Aplikacja musi działać płynnie na szerokim zakresie urządzeń, co oznacza konieczność optymalizacji pod kątem starszych modeli smartfonów o niższej wydajności; Android >= 6.0 (SDK >= 23).
    - Aplikacja będzie działała tylko w przypadku dostępności internetu. Brak połączenia z siecią uniemożliwi korzystanie z funkcji wymagających zdalnego dostępu do danych.

- **Finansowe:**
    - Budżet projektu jest ograniczony, co wymusza priorytetyzację kluczowych funkcji i rezygnację z niektórych mniej istotnych lub bardziej kosztownych opcji (np. bardzo zaawansowane funkcje AI czy API).

- **Czasowe:**
    - Harmonogram projektu nie może przekroczyć założonych 9 tygodni, co ogranicza liczbę iteracji i potencjalnych zmian w późnych fazach projektu.
    - Każdy etap projektu musi być ściśle monitorowany, aby uniknąć opóźnień, co może wymusić ograniczenie liczby dodatkowych funkcji na późnym etapie projektu.

- **Zależność od zewnętrznych dostawców danych i usług:**
    - Aplikacja będzie zależna od jakości i dostępności zewnętrznych API (np. Google API). Ograniczona dostępność danych (np. niedokładne godziny otwarcia, brak wszystkich danych o atrakcjach) może negatywnie wpłynąć na jakość rekomendacji.
    - Aplikacja może być narażona na zmiany w regulaminach korzystania z API dostarczanych przez zewnętrzne firmy, co może ograniczyć dostęp do niektórych danych lub zwiększyć koszty.



#### MVP - spis funkcjonalności:
- Aplikacja możliwa do zainstalowania za pomocą pliku .apk
- Autentykacja i autoryzacja
- Możliwość resetowania hasła
- Tworzenie wycieczek
- Dzielenie wycieczek na dni
- Usuwanie wycieczek
- Dodawanie różnych wydarzeń do wycieczki (ręcznie oraz poprzez wyszukiwanie)
- Usuwanie wydarzeń z wycieczki
- Obliczanie potrzebnego czasu przemieszczania się pomiędzy wydarzeniami
- Tworzenie tras między dwoma wydarzeniami (odnośnik do Google Maps)



