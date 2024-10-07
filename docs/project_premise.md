# **Fiszka Projektowa (Project Premise)**

## 1. Tytuł Projektu
Aplikacja do planowania spersonalizowanego zwiedzania zabytków, atrakcji turystycznych i miejsc kulturalnych z uwzględnieniem preferencji, ograniczeń czasowych i budżetowych.

## 2. Akronim
Travel Buddy

## 3. Lista Członków Zespołu
- Igor Banaszak  
- Adrian Broniecki  
- Bartosz Gableta  
- Mateusz Gazda  

## 4. Opiekun Zespołu:
dr inż. Marcin Kawalerowicz

## 5. Syntetyczny Opis Projektu
Główne funkcjonalności aplikacji obejmują:
- **Personalizacja proponowanych atrakcji na podstawie preferencji użytkownika:**
    - Tworzenie profilu użytkownika z preferencjami dotyczącymi typów atrakcji, kuchni, zainteresowań kulturalnych i historycznych.
    - Analiza danych w celu rekomendowania najbardziej odpowiednich miejsc do odwiedzenia.
- **Planowanie wycieczki w kontekście ograniczeń czasowych i budżetowych:**
    - Opcja ustalania dostępnego czasu i budżetu.
    - Generowanie sugestii na podstawie profilu użytkownika.
- **Optymalizacja trasy zwiedzania:**
    - Możliwość wyznaczania optymalnej trasy między punktami zainteresowania.
    - Uwzględnienie czasu potrzebnego na przejście lub dojazd między miejscami.

- **Synchronizacja z kalendarzem użytkownika.**
    - Możliwość synchronizacji planów zwiedzania z kalendarzem na urządzeniu użytkownika. 

- **Dostosowanie aplikacji do potrzeb osób z niepełnosprawnościami.**
    - Opisy alternatywne (alt text) dla obrazów i innych elementów graficznych.
    - Opcja zmiany rozmiaru czcionki, aby osoby z wadami wzroku mogły dostosować tekst do swoich potrzeb.
    - Możliwość włączenia trybu wysokiego kontrastu, który ułatwia czytanie dla osób z osłabionym wzrokiem.

- **Personalizacja aplikacji:**
    - Tryb nocny z ciemnym tłem i jasnym tekstem, aby zmniejszyć zmęczenie oczu.


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
- **Cloud**: Azure

## 7. Roadmapa Projektu

### Etap 1
Pierwszym krokiem w procesie tworzenia naszej aplikacji jest dokładne przygotowanie wszystkich niezbędnych materiałów, które stanowią fundament do rozpoczęcia prac programistycznych. Na tym etapie kluczowe jest, aby opracować kompleksową dokumentację, która szczegółowo określi cele projektu, jego zasięg oraz ogólną wizję finalnego produktu.

**Kamień milowy:**
- Fiszka
- Vision And Scope
- Dokumentacja koncepcji projektu (cele, wizja, funkcjonalności, mockupy UI/UX, dane z API)

### Etap 2
W tym etapie kluczowym zadaniem jest stworzenie pierwszej, działającej wersji aplikacji, która zawiera minimalny zestaw funkcji potrzebnych do spełnienia podstawowych wymagań użytkowników. Kluczowe jest stworzenie i integracja kluczowych komponentów aplikacji, takich jak interfejs użytkownika, logika backendu oraz połączenia z zewnętrznymi API, które zostały wcześniej zidentyfikowane, oraz zapewnienie, że aplikacja poprawnie korzysta z tych danych.

**Kamień milowy:**  
- MVP: Pierwsza wersja aplikacji z minimalnym zestawem funkcji.

### Etap 3
W tym etapie kluczowe jest dopracowanie wszystkich funkcjonalności oraz przeprowadzenie pełnych testów aplikacji przed jej wdrożeniem. Trzeba zaimplementować i dopracować wszystkie zaplanowane funkcje, integrację z API, oraz elementów UI/UX. Należy również dokonać optymalizacji działania aplikacji, poprawy wydajności oraz usunąć drobne błędy. Ważną częścią tego etapu jest także przeprowadzenie testów funkcjonalnych, wydajnościowych oraz testów na różnych urządzeniach. Trzeba zweryfikować poprawność działania aplikacji w realistycznych warunkach użytkowania i upewnić się, że aplikacja jest stabilna i wolna od krytycznych błędów.

**Kamień milowy:**  
- Pełna działająca aplikacja, przeprowadzenie wszystkich testów (funkcjonalnych, wydajnościowych, na różnych urządzeniach).

### Etap 4
W tym etapie celem jest przygotowanie aplikacji do udostępnienia użytkownikom oraz sporządzenie kompletnej dokumentacji technicznej i użytkowej. Przygotowana dokumentacja zawiera szczegółowe informacje dotyczące architektury aplikacji, baz danych, API, oraz wszelkich niezbędnych konfiguracji systemowych. Również należy zapewnić,  że wszystkie serwisy, bazy danych, oraz połączenia API są poprawnie skonfigurowane i działają bez zakłóceń.

**Kamień milowy:**  
- Wdrożenie aplikacji do sklepu Google Play, kompletna dokumentacja techniczna i użytkowa.

## Dodatkowe elementy

### 1. Kluczowe Ryzyka
- **Niedoszacowanie czasu potrzebnego na realizację poszczególnych etapów**  
    - *Opis ryzyka*: Opóźnienia w realizacji, które mogą wystąpić, jeśli zespół nie przewidzi odpowiedniej ilości czasu na kluczowe zadania, takie jak integracja danych czy testowanie aplikacji.
    - *Planowane rozwiązanie*: Realistyczne harmonogramy z buforami czasowymi, Agile, monitoring postępów.

- **Problemy techniczne z integracją z API:**  
    - *Opis ryzyka*: Integracja z zewnętrznymi systemami może być problematyczna, np. z powodu nieaktualnych lub niekompletnych danych, ograniczeń w liczbie zapytań, czy nagłych zmian w API.
    - *Planowane rozwiązanie*: Wybór sprawdzonych dostawców API, wczesne rozpoczęcie testów integracyjnych oraz stworzenie mechanizmu obsługi błędów i alternatywnych źródeł danych w razie problemów z głównym dostawcą.

- **Problemy z budżetem:**  
    - *Opis ryzyka*: Przekroczenie budżetu może wynikać z niedoszacowania kosztów, dodatkowych prac związanych z poprawkami lub opóźnieniami.
    - *Planowane rozwiązanie*: Bieżąca kontrola kosztów, wprowadzenie rezerw budżetowych na nieprzewidziane wydatki oraz dokładne planowanie zasobów na wczesnym etapie projektu.

### 2. Założenia i Ograniczenia
#### Założenia:
- Dostępność danych turystycznych i kulturalnych z publicznych źródeł API.
    - Aplikacja będzie korzystać z publicznie dostępnych źródeł danych (np. API z mapami, danymi o zabytkach, wydarzeniach kulturalnych).
    - Zakładamy, że dane dotyczące atrakcji turystycznych, godzin otwarcia, cen biletów będą dostępne w sposób ciągły i aktualny.

- Wsparcie dla urządzeń z systemem Android.
    - Zakładamy, że użytkownicy korzystają głównie ze smartfonów i tabletów, a aplikacja będzie responsywna na różnych rozdzielczościach ekranów.

- Personalizacja trasy na podstawie preferencji użytkownika.
    - System będzie potrafił sugerować atrakcje turystyczne i kulturalne w oparciu o preferencje użytkownika (np. preferowane typy atrakcji, dostępny czas, budżet).
    - Zakładamy, że algorytm personalizacji opiera się na danych wprowadzonych przez użytkownika oraz zewnętrznych źródłach informacji.

- Realizacja projektu w okresie 9 tygodni.
    - Zakładamy, że projekt musi zostać zrealizowany w okresie 9 tygodni, co obejmuje wszystkie etapy: analizę, projektowanie, implementację, testowanie i wdrożenie.


#### Ograniczenia:
-  Aplikacja musi działać płynnie na szerokim zakresie urządzeń, co oznacza konieczność optymalizacji pod kątem starszych modeli smartfonów o niższej wydajności; Android >= 6.0 (SDK >= 23).
- Budżet projektu jest ograniczony, co wymusza priorytetyzację kluczowych funkcji i rezygnację z niektórych mniej istotnych lub bardziej kosztownych opcji (np. bardzo zaawansowane funkcje AI czy API).
- Harmonogram projektu nie może przekroczyć założonych 9 tygodni, co ogranicza liczbę iteracji i potencjalnych zmian w późnych fazach projektu.
- Każdy etap projektu musi być ściśle monitorowany, aby uniknąć opóźnień, co może wymusić ograniczenie liczby dodatkowych funkcji na późnym etapie projektu.
- Aplikacja będzie zależna od jakości i dostępności zewnętrznych API (np. Google API). Ograniczona dostępność danych (np. niedokładne godziny otwarcia, brak wszystkich danych o atrakcjach) może negatywnie wpłynąć na jakość rekomendacji.
- Aplikacja może być narażona na zmiany w regulaminach korzystania z API dostarczanych przez zewnętrzne firmy, co może ograniczyć dostęp do niektórych danych lub zwiększyć koszty.



