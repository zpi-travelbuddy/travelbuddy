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


<!--EndFragment-->

