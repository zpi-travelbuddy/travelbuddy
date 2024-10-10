<!--StartFragment-->

**Google Places API**

- Nearby Search

  - opcje request:

    - Lokalizacja: Okrąg

    - Kategorie include i exclude(wiele): \[`art_gallery, museum, performing_arts_theater, aquarium, historical_landmark, marina, movie_theater, national_park, park, tourist_attraction, visitor_center, zoo, church, hindu_temple, mosque, synagogue, gift_shop, stadium]`

    - Wersje językowe: Wiele

    - Max miejsc: 20

    - Kryterium wyboru wyników: \[`POPULARITY , DISTANCE`]

- Text Search

  - opcje request:

    - textQuery

    - Lokalizacja(2 opcje, musi być w polu, może być w pobliżu ale może wyjść poza pole): okrą, prostokąt

    - Kategoria include(tylko jedna): \[`art_gallery, museum, performing_arts_theater, aquarium, historical_landmark, marina, movie_theater, national_park, park, tourist_attraction, visitor_center, zoo, church, hindu_temple, mosque, synagogue, gift_shop, stadium]`

    - Wersje językowe: Wiele

    - Max miejsc: 20 na stronę, jak jest więcej to token do następnej strony

    - Min rating: minimalna ocena (0,0.5,1,1.5,...,4.5,5)

    - Open now: czy teraz jest otwarte

    - Kryterium wyboru wyników: \[RELEVANCE , DISTANCE]

    - strictTypeFiltering: czy musi spełniać kategorie, jeżeli nie to może zwrócić coś co nie spełnia kategorii 

**Google Places API response**:

<!--StartFragment-->

**Maska Basic:**

- Accessibility options - czy dla niepełnosprawnych

- Address components

- Business status - BUSINESS\_STATUS\_UNSPECIFIED, OPERATIONAL,CLOSED\_TEMPORARILY,CLOSED\_PERMANENTLY

- Display name

- Formatted address

- Google Maps URI

- Icon mask base URI - ikona na mapach w zależności od typu np. muzeum kościół

- Location 

- Photos

- Place ID

- Plus code - googlowska lokalizacja

- Primary type - typ np. muzeum

- Primary type display name -nazwa typu w zależności od języka

**Maska Advanced:**

- Current opening hours

- International phone number

- National phone number

- Rating

- Regular opening hours

- Website URI

**Maska Preferred:**

- Restroom

- Reviews

- Good for children

- Good for groups

- Good for watching sports

- Allows dogs

**Podsumowanie Google Places API**

Google pozwala zapisywać wyłącznie place Id, a co za tym idzie za każdym razem gdy chcemy np zdjęcie trzeba zrobić zapytanie o detale, a następnie zapytanie o konkretne zdjęcie bo id zdjęcia również nie można przechowywać.

- Nearby Search:

  - Dużym ograniczeniem jest liczba zwracanych miejsc, bo wynosi tylko 20.

- Test Search:

  - Ograniczneniem jest tylko jeden include do kategorii ale resztę można ująć w query

********

**Foursquare Places API**

- **Places Search**

  - **opcje request:**

    - **query** - Ciąg znaków, który będzie dopasowywany do całej zawartości tego miejsca, w tym, ale nie wyłącznie do nazwy lokalu, kategorii, numeru telefonu, smaku i wskazówek.

    - **ll -** Szerokość/długość geograficzna, wokół której mają zostać pobrane informacje o miejscu. Musi być określona w formacie szerokość,długość geograficzna (np. ll=41.8781,-87.6298).

    - **radius -** Ustawia odległość promienia (w metrach), która jest używana do określenia obszaru, w celu ukierunkowania wyników wyszukiwania. Maksymalny dozwolony promień to 100 000 metrów. Promień może być używany tylko w połączeniu z geolokalizacją opartą na współrzędnych (ll) lub adresie IP. Korzystanie z promienia powoduje pominięcie globalnych wyników wyszukiwania. Jeśli nie zostanie podany, domyślnie stosowany promień to 22 000 metrów.

    - **categories** - Filtruje odpowiedź i zwraca miejsca FSQ, które pasują do określonych kategorii. Obsługuje wiele identyfikatorów kategorii (Category IDs), oddzielonych przecinkami. Przykładowe: `Arts and Entertainment > Exhibit`

<!---->

    Arts and Entertainment > Museum > Art Museum
    Arts and Entertainment > Museum > Erotic Museum
    Arts and Entertainment > Museum > History Museum
    Arts and Entertainment > Museum > Science Museum
    Arts and Entertainment > Night Club

Wszystkie:` `[`https://docs.foursquare.com/data-products/docs/categories`](https://docs.foursquare.com/data-products/docs/categories)

Jest ich bardzo dużo`.`

- **fields** - Wskaż, które pola mają zostać zwrócone w odpowiedzi, oddzielając je przecinkami. Jeśli żadne pola nie zostaną określone, domyślnie zwracane są wszystkie podstawowe pola (Core Fields).

- **min\_price** - Ogranicza wyniki wyłącznie do miejsc mieszczących się w określonym przedziale cenowym. Dozwolone wartości mieszczą się w zakresie od 1 (najtańsze) do 4 (najdroższe), włącznie.

- **max\_price** - Ogranicza wyniki wyłącznie do miejsc mieszczących się w określonym przedziale cenowym. Dozwolone wartości mieszczą się w zakresie od 1 (najbardziej przystępne) do 4 (najdroższe), włącznie.

- **open\_at** - Obsługuje zapytania o lokalny dzień i godzinę za pomocą tego parametru. Należy go określić w formacie DOWTHHMM (np. 1T2130), gdzie DOW to numer dnia 1-7 (poniedziałek = 1, niedziela = 7), a czas podany jest w formacie 24-godzinnym.

Miejsca, które nie mają podanych godzin otwarcia, nie zostaną zwrócone, jeśli ten parametr zostanie określony.

- **near** - Ciąg znaków określający lokalizację na świecie (np. "Chicago, IL"). Jeśli wartość nie może zostać zgeokodowana, zwracany jest błąd.

- **sort** - Określa kolejność, w jakiej wyniki są wyświetlane. Możliwe wartości to:

* relevance (domyślnie)

* rating

* distance

- **limit** - Liczba wyników do zwrócenia, maksymalnie 50. Domyślnie wynosi 10.

* **pola w odpowiedzi:**

  - **Core Data**

    - **name** - Najlepiej znana nazwa miejsca FSQ.

    - **geocodes** - Zestaw geokodów (szerokość, długość geograficzna) dla miejsca.

    - **location** - Obiekt zawierający żadne, niektóre lub wszystkie z pól. Wybrane:

- adres

- adres rozszerzony

- miejscowość pocztowa

- ulica krzyżowa

- sformatowany adres

* **categories** - Tablica, która może być pusta, zawierająca kategorie opisujące miejsce FSQ. Zawiera następujące podpol: id (identyfikator kategorii), name (etykieta kategorii) oraz icon (ikona kategorii).

* **distance** - Obliczona odległość (w metrach) od podanej lokalizacji (tj. ll + promień LUB near LUB ne + sw) w wywołaniu API. To pole będzie zwracane tylko przez punkt końcowy wyszukiwania miejsc (Place Search endpoint).

* **link** - Adres URL związany z odpowiednim wywołaniem API szczegółów miejsca (Places Detail API) dla zwróconego miejsca.

- **Rich Data**

  - **description** - Ogólny opis miejsca FSQ. Zazwyczaj dostarczany przez właściciela/ubiegającego się o miejsce FSQ i/lub aktualizowany przez superużytkowników przewodników miejskich.

  - **tel**  - Najlepiej znany numer telefonu w lokalnym formacie.

  - **website** - Oficjalna strona internetowa miejsca FSQ.

  - **social\_media** - Obiekt zawierający identyfikatory mediów społecznościowych miejsca FSQ. Zawiera następujące podpola: facebook\_id, instagram i twitter. Nie wszystkie miejsca FSQ będą miały wszystkie podpola.

  - **verified**  - Wartość logiczna (boolean), która wskazuje, czy miejsce FSQ zostało zarejestrowane (claimed), czy nie.

  - **hours** - Tablica zawierająca **regular** godziny otwarcia, informację o lokalnych świętach (is\_local\_holiday), status otwarcia (open\_now) oraz sformatowany **display** string. **regular** hours zawierają następujące podpola:  

    - \- day (1 = poniedziałek, 2 = wtorek, 7 = niedziela)  

    - \- open (godzina otwarcia w formacie 24-godzinnym)  

    - \- close (godzina zamknięcia w formacie 24-godzinnym)  

  - **hours\_popular** - Tablica zawierająca godziny w ciągu tygodnia, kiedy miejsce FSQ jest najczęściej odwiedzane. To miejsce musi mieć minimalną liczbę odpraw (check-in), aby zostać uwzględnione w obliczeniach. Podobnie jak w przypadku godzin, to pole zawiera następujące podpola:  

    - \- day (1 = poniedziałek, 2 = wtorek, 7 = niedziela)  

    - \- open (godzina otwarcia w formacie 24-godzinnym)  

    - \- close (godzina zamknięcia w formacie 24-godzinnym)  

  - **rating** - Numeryczna ocena (od 0.0 do 10.0) miejsca FSQ, oparta na głosach użytkowników, polubieniach/niepolubieniach, sentymencie wskazówek oraz danych o wizytach. Nie wszystkie miejsca FSQ będą miały przypisaną ocenę.

  - **popularity** - Miara popularności miejsca FSQ, oparta na ruchu pieszym. Ta ocena znajduje się w skali od 0 do 1 i uwzględnia 6-miesięczny okres wizyt w danym miejscu w określonym obszarze geograficznym.

  - **price** - Wartość numeryczna (od 1 do 4), która najlepiej opisuje poziom cenowy miejsca FSQ, oparta na znanych cenach pozycji w menu i innych ofertach.

Wartości obejmują:

- 1 = Tanie

- 2 = Umiarkowane

- 3 = Drogie

- 4 = Bardzo drogie.

* **date\_closed** - Zarejestrowana data, kiedy miejsce FSQ zostało oznaczone jako trwale zamknięte w bazach danych Foursquare. Nie oznacza to koniecznie, że miejsce rzeczywiście było zamknięte w tej dacie.

* **photos** - Tablica obiektów zawierająca następujące podpola:  

  - \- id 

  - \- created\_at  

  - \- classifications  

  - \- prefix 

  - \- suffix

  - \- width 

  - \- height

* **features** - Lista tagów logicznych (boolean), które pomagają opisać usługi i dodatkowe metadane oferowane przez miejsce (np. takes\_reservations: true). <https://docs.foursquare.com/places/docs/flat-file-data-schema#tags>

**Retencja danych w Foursquare Places API**

Rozumiemy, że buforowanie danych Foursquare może zwiększyć szybkość działania aplikacji. Musisz jednak przestrzegać następujących zasad dotyczących przechowywania danych z API Miejsc (Places API):

- **FSQ\_ID**: nieograniczone buforowanie (wyłącznie w celu poprawy wydajności aplikacji).

- **ID zdjęć**: nieograniczone buforowanie.

- **fsq\_addr\_id**: nieograniczone buforowanie.

**Wszystkie inne atrybuty:**

- **Klienci Enterprise**: buforowanie lokalne przez 24 godziny tylko na urządzeniu (buforowanie na serwerze jest zabronione);

- **Klienci Pay as You Go i Sandbox**: buforowanie nie jest dozwolone.

**Podsumowanie Foursquare Places API**

1000 requestów kosztuje od 5 do 6,5 dolarów, darmowy kredyt 200 dolarów miesięcznie.

API pozwala na wyszukanie POI w mieszczących się w danym okręgu lub w danym mieście. Wyszukiwać można po bogatym zbiorze kategorii. Przy zapytaniu można podać również godzinę o której dane miejsce ma być otwarte oraz poziom cenowy w skali od 1-4. API zwraca do 50 miejsc dla jednego zapytania, nie zapewnia paginacji. Zwracane dane pozwalają na umieszczenie obiektu na mapie, dostępu do zdjęcia (po requestcie), zwracane są kategorie oraz godziny otwarcia, opis, dane kontaktowe, rating (0 -10), poziom cenowy.

**Geoapify API**

- **Places**

  - **opcje requestu:**

    - **categories**: Lista kategorii miejsc oddzielona przecinkami. https\://apidocs.geoapify.com/docs/places/#categories

    - **conditions**: Oprócz kategorii istnieje możliwość filtrowania wyników według warunków. Na przykład, tylko miejsca z dostępem do Internetu. https\://apidocs.geoapify.com/docs/places/#conditions

    - **filter**: Filtrowanie miejsc według granic, okręgu, geometrii lub krajów.

    - **bias**: Preferuj wyszukiwanie w pobliżu podanej lokalizacji. Należy zauważyć, że API będzie wyszukiwać miejsca w pobliżu lokalizacji, ale nie dalej niż 50 km.

    - **limit**: Maksymalna liczba wyników na stronę.

    - offset: Przesunięcie do pierwszego indeksu wyniku. Używane do dostępu do stron, gdy liczba wyników jest większa niż podany limit.

    - **lang**: Język wyników. Obsługiwane są 2-znakowe kody językowe ISO 639-1.

    - **name**: Umożliwia filtrowanie miejsc według podanej nazwy.

  - **pola w odpowiedzi:**

    - **name**: Nazwa lokalizacji

    - **country**: Kraj jako składnik adresu

    - **state**: Stan jako składnik adresu

    - **postcode**: Kod pocztowy lub ZIP jako składnik adresu

    - **city**: Miasto jako składnik adresu

    - **street**: Ulica jako składnik adresu

    - **housenumber**: Numer domu jako składnik adresu

    - **lat, lon**: Współrzędne lokalizacji

    - **formatted**: Sformatowany adres

    - **address\_line1**: Główna część sformatowanego adresu, zawierająca ulicę i numer domu lub nazwę obiektu

    - **address\_line2**: Druga część sformatowanego adresu, zawierająca składniki adresu, które nie zostały uwzględnione w address\_line1

    - **categories**: Wszystkie kategorie, do których należy dane miejsce. Może przyjmować wartości obsługiwanych kategorii i warunków.

    - **distance**: Odległość w metrach do podanej lokalizacji.

    - **place\_id**: Unikalny identyfikator miejsca, który można wykorzystać do uzyskania dodatkowych informacji o miejscu za pomocą API szczegółów miejsca (Place Details API).

- **Places Details**

  - **pola w odpowiedzi:**

    - **website**: Strona internetowa (oficjalna)

    - **website\_other**: Inne strony internetowe (tablica)

    - **website\_international**: Obiekt mapy - Strony internetowe według kraju

    - **description**: Opis

    - **description\_international**: Opis według krajów

    - **name**: Nazwa

    - **name\_other**: Inne nazwy

      - **name\_other.alt\_name**: Alternatywna nazwa

      - **name\_other**.**old\_name**: Nieaktualna nazwa

      - **name\_other**.**official\_name**: Oficjalna nazwa

      - **name\_other**.**short\_name**: Krótka nazwa

      - **name\_other**.**loc\_name**: Lokalna nazwa

    - **name\_international**: Nazwy według kraju/języka

    - **opening\_hours**: Godziny otwarcia

    - **opening\_hours\_covid19**: Godziny otwarcia specjalne na czas sytuacji związanej z COVID-19

    - **brand**: Marka. Znaki towarowe, tożsamość produktu, usługi lub działalności

    - **brand\_details**: Szczegóły marki

      - **brand\_details**.**wikidata**: Wikidata marki

      - **brand\_details**.**wikipedia**: Wikipedia marki

      - **brand\_details**.**website**: Strona internetowa marki

    - **operator**: Operator. Firma, korporacja lub osoba odpowiedzialna za funkcjonowanie obiektu

    - **operator\_details**: Szczegóły operatora

      - **operator\_details**.**type**: Typ operatora

      - **operator\_details**.**wikidata**: Wikidata operatora

      - **operator\_details**.**wikipedia**: Wikipedia operatora

      - **operator\_details**.**website**: Strona internetowa operatora

    - **branch**: Oddział marki lub sieci

    - **network**: System tras lub zakres trasy

    - **network\_details**: Szczegóły sieci

      - **network\_details**.**type**: Typ sieci

      - **network\_details**.**guid**: GUID sieci, zazwyczaj dla transportu publicznego

      - **network\_details**.**wikidata**: Wikidata sieci

      - **network\_details**.**wikipedia**: Wikipedia sieci

      - **network\_details**.**website**: Strona internetowa sieci

    - **owner**: Właściciel miejsca

      - **owner\_details**: Szczegóły właściciela

      - **owner\_details**.**type**: Typ własności

      - **owner\_details**.**wikidata**: Wikidata właściciela

      - **owner\_details**.**wikipedia**: Wikipedia właściciela

      - **owner\_details**.**website**: Strona internetowa właściciela

    - **craft**: Miejsce produkujące lub przetwarzające towary

**Retencja danych w Geoapify**

Geoapify Places API umożliwia buforowanie, przechowywanie i rozpowszechnianie wyników bez dodatkowych ograniczeń. Wymagane jest jednak przypisanie źródła do OpenStreetMap (OSM). Użytkownicy korzystający z darmowego planu muszą również zamieścić przypisanie do Geoapify. 

**Podsumowanie Geoapify Places API**

API w darmowej wersji dostarcza 3 000 kredytów dziennie. 1 kredyt odpowiada zapytaniu o 20 POI (przykładowo zapytanie o 100 POI kosztuje 5 kredytów). API pozwala filtrować wyniki po bogatym zbiorze kategorii oraz dodatkowych ograniczeń w szczególności dotyczących przystosowania miejsca do osób niepełnosprawnych oraz w przypadku restauracji do wymogów dietetycznych. API udostępnia informacje o godzinach otwarcia danego miejsca oraz o koszcie wstępu.

<!--EndFragment-->

<!--EndFragment-->
