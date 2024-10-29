using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using TravelBuddyAPI.Models;

public static class ModelBuilderExtension
{
    public static void Seed(this ModelBuilder modelBuilder)
    {

        //CATEGORIES
        var placeCategories = new Dictionary<String, PlaceCategory>
        {
            {"activity", new PlaceCategory { Id = Guid.NewGuid(), Name = "activity" }},
            {"commercial", new PlaceCategory { Id = Guid.NewGuid(), Name = "commercial" }},
                {"gift_and_souvenir", new PlaceCategory { Id = Guid.NewGuid(), Name = "gift_and_souvenir"}},
                {"art", new PlaceCategory { Id = Guid.NewGuid(), Name = "art" }},
            {"entertainment", new PlaceCategory { Id = Guid.NewGuid(), Name = "entertainment" }},
                {"culture", new PlaceCategory { Id = Guid.NewGuid(), Name = "culture" }},
                    {"theatre", new PlaceCategory { Id = Guid.NewGuid(), Name = "theatre" }},
                    {"arts_centre", new PlaceCategory { Id = Guid.NewGuid(), Name = "arts_centre" }},
                    {"gallery", new PlaceCategory { Id = Guid.NewGuid(), Name = "gallery" }},
                {"zoo", new PlaceCategory { Id = Guid.NewGuid(), Name = "zoo" }},
                {"aquarium", new PlaceCategory { Id = Guid.NewGuid(), Name = "aquarium" }},
                {"planetarium", new PlaceCategory { Id = Guid.NewGuid(), Name = "planetarium" }},
                {"museum", new PlaceCategory { Id = Guid.NewGuid(), Name = "museum" }},
            {"heritage", new PlaceCategory { Id = Guid.NewGuid(), Name = "heritage" }},
                {"unesco", new PlaceCategory { Id = Guid.NewGuid(), Name = "unesco" }},
            {"leisure", new PlaceCategory { Id = Guid.NewGuid(), Name = "leisure" }},
                {"park", new PlaceCategory { Id = Guid.NewGuid(), Name = "park" }},
                    {"garden", new PlaceCategory { Id = Guid.NewGuid(), Name = "garden" }},
                    {"nature_reserve", new PlaceCategory { Id = Guid.NewGuid(), Name = "nature_reserve" }},
            {"natural", new PlaceCategory { Id = Guid.NewGuid(), Name = "natural" }},
                {"forest", new PlaceCategory { Id = Guid.NewGuid(), Name = "forest" }},
                {"water", new PlaceCategory { Id = Guid.NewGuid(), Name = "water" }},
                    {"spring", new PlaceCategory { Id = Guid.NewGuid(), Name = "spring" }},
                    {"reef", new PlaceCategory { Id = Guid.NewGuid(), Name = "reef" }},
                    {"hot_spring", new PlaceCategory { Id = Guid.NewGuid(), Name = "hot_spring" }},
                    {"geyser", new PlaceCategory { Id = Guid.NewGuid(), Name = "geyser" }},
                    {"sea", new PlaceCategory { Id = Guid.NewGuid(), Name = "sea" }},
                {"mountain", new PlaceCategory { Id = Guid.NewGuid(), Name = "mountain" }},
                    {"peak", new PlaceCategory { Id = Guid.NewGuid(), Name = "peak" }},
                    {"glacier", new PlaceCategory { Id = Guid.NewGuid(), Name = "glacier" }},
                    {"cliff", new PlaceCategory { Id = Guid.NewGuid(), Name = "cliff" }},
                    {"rock", new PlaceCategory { Id = Guid.NewGuid(), Name = "rock" }},
                    {"cave_entrance", new PlaceCategory { Id = Guid.NewGuid(), Name = "cave_entrance" }},
                {"sand", new PlaceCategory { Id = Guid.NewGuid(), Name = "sand" }},
                    {"dune", new PlaceCategory { Id = Guid.NewGuid(), Name = "dune" }},
            {"national park", new PlaceCategory { Id = Guid.NewGuid(), Name = "national park" }},
            {"tourism", new PlaceCategory { Id = Guid.NewGuid(), Name = "tourism" }},
                {"attraction", new PlaceCategory { Id = Guid.NewGuid(), Name = "attraction" }},
                    {"artwork", new PlaceCategory { Id = Guid.NewGuid(), Name = "artwork" }},
                    {"viewpoint", new PlaceCategory { Id = Guid.NewGuid(), Name = "viewpoint" }},
                    {"fountain", new PlaceCategory { Id = Guid.NewGuid(), Name = "fountain" }},
                    {"clock", new PlaceCategory { Id = Guid.NewGuid(), Name = "clock" }},
                {"sights", new PlaceCategory { Id = Guid.NewGuid(), Name = "sights" }},
                    {"place_of_worship", new PlaceCategory { Id = Guid.NewGuid(), Name = "place_of_worship" }},
                        {"church", new PlaceCategory { Id = Guid.NewGuid(), Name = "church" }},
                        {"chapel", new PlaceCategory { Id = Guid.NewGuid(), Name = "chapel" }},
                        {"cathedral", new PlaceCategory { Id = Guid.NewGuid(), Name = "cathedral" }},
                        {"synagogue", new PlaceCategory { Id = Guid.NewGuid(), Name = "synagogue" }},
                        {"temple", new PlaceCategory { Id = Guid.NewGuid(), Name = "temple" }},
                        {"mosque", new PlaceCategory { Id = Guid.NewGuid(), Name = "mosque" }},
                        {"shrine", new PlaceCategory { Id = Guid.NewGuid(), Name = "shrine" }},
                    {"monastery", new PlaceCategory { Id = Guid.NewGuid(), Name = "monastery" }},
                    {"city_hall", new PlaceCategory { Id = Guid.NewGuid(), Name = "city_hall" }},
                    {"lighthouse", new PlaceCategory { Id = Guid.NewGuid(), Name = "lighthouse" }},
                    {"windmill", new PlaceCategory { Id = Guid.NewGuid(), Name = "windmill" }},
                    {"tower", new PlaceCategory { Id = Guid.NewGuid(), Name = "tower" }},
                    {"battlefield", new PlaceCategory { Id = Guid.NewGuid(), Name = "battlefield" }},
                    {"fort", new PlaceCategory { Id = Guid.NewGuid(), Name = "fort" }},
                    {"castle", new PlaceCategory { Id = Guid.NewGuid(), Name = "castle" }},
                    {"ruines", new PlaceCategory { Id = Guid.NewGuid(), Name = "ruines" }},
                    {"archaeological_site", new PlaceCategory { Id = Guid.NewGuid(), Name = "archaeological_site" }},
                    {"city_gate", new PlaceCategory { Id = Guid.NewGuid(), Name = "city_gate" }},
                    {"bridge", new PlaceCategory { Id = Guid.NewGuid(), Name = "bridge" }},
                    {"memorial", new PlaceCategory { Id = Guid.NewGuid(), Name = "memorial" }},
                        {"aircraft", new PlaceCategory { Id = Guid.NewGuid(), Name = "aircraft" }},
                        {"locomotive", new PlaceCategory { Id = Guid.NewGuid(), Name = "locomotive" }},
                        {"railway_car", new PlaceCategory { Id = Guid.NewGuid(), Name = "railway_car" }},
                        {"ship", new PlaceCategory { Id = Guid.NewGuid(), Name = "ship" }},
                        {"tank", new PlaceCategory { Id = Guid.NewGuid(), Name = "tank" }},
                        {"tomb", new PlaceCategory { Id = Guid.NewGuid(), Name = "tomb" }},
                        {"monument", new PlaceCategory { Id = Guid.NewGuid(), Name = "monument" }},
                        {"wayside_cross", new PlaceCategory { Id = Guid.NewGuid(), Name = "wayside_cross" }},
                        {"boundary_stone", new PlaceCategory { Id = Guid.NewGuid(), Name = "boundary_stone" }},
                        {"pillory", new PlaceCategory { Id = Guid.NewGuid(), Name = "pillory" }},
                        {"milestone", new PlaceCategory { Id = Guid.NewGuid(), Name = "milestone" }},
            {"religion", new PlaceCategory { Id = Guid.NewGuid(), Name = "religion" }},
                {"place_of_worship_religion", new PlaceCategory { Id = Guid.NewGuid(), Name = "place_of_worship" }},
                    {"buddhism", new PlaceCategory { Id = Guid.NewGuid(), Name = "buddhism" }},
                    {"christianity", new PlaceCategory { Id = Guid.NewGuid(), Name = "christianity" }},
                    {"hinduism", new PlaceCategory { Id = Guid.NewGuid(), Name = "hinduism" }},
                    {"islam", new PlaceCategory { Id = Guid.NewGuid(), Name = "islam" }},
                    {"judaism", new PlaceCategory { Id = Guid.NewGuid(), Name = "judaism" }},
                    {"shinto", new PlaceCategory { Id = Guid.NewGuid(), Name = "shinto" }},
                    {"sikhism", new PlaceCategory { Id = Guid.NewGuid(), Name = "sikhism" }},
                    {"multifaith", new PlaceCategory { Id = Guid.NewGuid(), Name = "multifaith" }},
            {"sport", new PlaceCategory { Id = Guid.NewGuid(), Name = "sport" }},
                {"stadium", new PlaceCategory { Id = Guid.NewGuid(), Name = "stadium" }},
            {"catering", new PlaceCategory { Id = Guid.NewGuid(), Name = "catering" }},
                {"restaurant", new PlaceCategory { Id = Guid.NewGuid(), Name = "restaurant" }},
                    {"pizza", new PlaceCategory { Id = Guid.NewGuid(), Name = "pizza" }},
                    {"burger", new PlaceCategory { Id = Guid.NewGuid(), Name = "burger" }},
                    {"regional", new PlaceCategory { Id = Guid.NewGuid(), Name = "regional" }},
                    {"italian", new PlaceCategory { Id = Guid.NewGuid(), Name = "italian" }},
                    {"chinese", new PlaceCategory { Id = Guid.NewGuid(), Name = "chinese" }},
                    {"sandwich", new PlaceCategory { Id = Guid.NewGuid(), Name = "sandwich" }},
                    {"chicken", new PlaceCategory { Id = Guid.NewGuid(), Name = "chicken" }},
                    {"mexican", new PlaceCategory { Id = Guid.NewGuid(), Name = "mexican" }},
                    {"japanese", new PlaceCategory { Id = Guid.NewGuid(), Name = "japanese" }},
                    {"american", new PlaceCategory { Id = Guid.NewGuid(), Name = "american" }},
                    {"kebab", new PlaceCategory { Id = Guid.NewGuid(), Name = "kebab" }},
                    {"indian", new PlaceCategory { Id = Guid.NewGuid(), Name = "indian" }},
                    {"asian", new PlaceCategory { Id = Guid.NewGuid(), Name = "asian" }},
                    {"sushi", new PlaceCategory { Id = Guid.NewGuid(), Name = "sushi" }},
                    {"french", new PlaceCategory { Id = Guid.NewGuid(), Name = "french" }},
                    {"german", new PlaceCategory { Id = Guid.NewGuid(), Name = "german" }},
                    {"thai", new PlaceCategory { Id = Guid.NewGuid(), Name = "thai" }},
                    {"greek", new PlaceCategory { Id = Guid.NewGuid(), Name = "greek" }},
                    {"seafood", new PlaceCategory { Id = Guid.NewGuid(), Name = "seafood" }},
                    {"fish_and_chips", new PlaceCategory { Id = Guid.NewGuid(), Name = "fish_and_chips" }},
                    {"steak_house", new PlaceCategory { Id = Guid.NewGuid(), Name = "steak_house" }},
                    {"international", new PlaceCategory { Id = Guid.NewGuid(), Name = "international" }},
                    {"tex-mex", new PlaceCategory { Id = Guid.NewGuid(), Name = "tex-mex" }},
                    {"vietnamese", new PlaceCategory { Id = Guid.NewGuid(), Name = "vietnamese" }},
                    {"turkish", new PlaceCategory { Id = Guid.NewGuid(), Name = "turkish" }},
                    {"korean", new PlaceCategory { Id = Guid.NewGuid(), Name = "korean" }},
                    {"noodle", new PlaceCategory { Id = Guid.NewGuid(), Name = "noodle" }},
                    {"barbecue", new PlaceCategory { Id = Guid.NewGuid(), Name = "barbecue" }},
                    {"spanish", new PlaceCategory { Id = Guid.NewGuid(), Name = "spanish" }},
                    {"fish", new PlaceCategory { Id = Guid.NewGuid(), Name = "fish" }},
                    {"ramen", new PlaceCategory { Id = Guid.NewGuid(), Name = "ramen" }},
                    {"mediterranean", new PlaceCategory { Id = Guid.NewGuid(), Name = "mediterranean" }},
                    {"friture", new PlaceCategory { Id = Guid.NewGuid(), Name = "friture" }},
                    {"beef_bowl", new PlaceCategory { Id = Guid.NewGuid(), Name = "beef_bowl" }},
                    {"lebanese", new PlaceCategory { Id = Guid.NewGuid(), Name = "lebanese" }},
                    {"wings", new PlaceCategory { Id = Guid.NewGuid(), Name = "wings" }},
                    {"georgian", new PlaceCategory { Id = Guid.NewGuid(), Name = "georgian" }},
                    {"tapas", new PlaceCategory { Id = Guid.NewGuid(), Name = "tapas" }},
                    {"indonesian", new PlaceCategory { Id = Guid.NewGuid(), Name = "indonesian" }},
                    {"arab", new PlaceCategory { Id = Guid.NewGuid(), Name = "arab" }},
                    {"portuguese", new PlaceCategory { Id = Guid.NewGuid(), Name = "portuguese" }},
                    {"russian", new PlaceCategory { Id = Guid.NewGuid(), Name = "russian" }},
                    {"filipino", new PlaceCategory { Id = Guid.NewGuid(), Name = "filipino" }},
                    {"african", new PlaceCategory { Id = Guid.NewGuid(), Name = "african" }},
                    {"malaysian", new PlaceCategory { Id = Guid.NewGuid(), Name = "malaysian" }},
                    {"caribbean", new PlaceCategory { Id = Guid.NewGuid(), Name = "caribbean" }},
                    {"peruvian", new PlaceCategory { Id = Guid.NewGuid(), Name = "peruvian" }},
                    {"bavarian", new PlaceCategory { Id = Guid.NewGuid(), Name = "bavarian" }},
                    {"brazilian", new PlaceCategory { Id = Guid.NewGuid(), Name = "brazilian" }},
                    {"curry", new PlaceCategory { Id = Guid.NewGuid(), Name = "curry" }},
                    {"dumpling", new PlaceCategory { Id = Guid.NewGuid(), Name = "dumpling" }},
                    {"persian", new PlaceCategory { Id = Guid.NewGuid(), Name = "persian" }},
                    {"argentinian", new PlaceCategory { Id = Guid.NewGuid(), Name = "argentinian" }},
                    {"oriental", new PlaceCategory { Id = Guid.NewGuid(), Name = "oriental" }},
                    {"balkan", new PlaceCategory { Id = Guid.NewGuid(), Name = "balkan" }},
                    {"moroccan", new PlaceCategory { Id = Guid.NewGuid(), Name = "moroccan" }},
                    {"pita", new PlaceCategory { Id = Guid.NewGuid(), Name = "pita" }},
                    {"ethiopian", new PlaceCategory { Id = Guid.NewGuid(), Name = "ethiopian" }},
                    {"taiwanese", new PlaceCategory { Id = Guid.NewGuid(), Name = "taiwanese" }},
                    {"latin_american", new PlaceCategory { Id = Guid.NewGuid(), Name = "latin_american" }},
                    {"hawaiian", new PlaceCategory { Id = Guid.NewGuid(), Name = "hawaiian" }},
                    {"irish", new PlaceCategory { Id = Guid.NewGuid(), Name = "irish" }},
                    {"austrian", new PlaceCategory { Id = Guid.NewGuid(), Name = "austrian" }},
                    {"croatian", new PlaceCategory { Id = Guid.NewGuid(), Name = "croatian" }},
                    {"danish", new PlaceCategory { Id = Guid.NewGuid(), Name = "danish" }},
                    {"tacos", new PlaceCategory { Id = Guid.NewGuid(), Name = "tacos" }},
                    {"bolivian", new PlaceCategory { Id = Guid.NewGuid(), Name = "bolivian" }},
                    {"hungarian", new PlaceCategory { Id = Guid.NewGuid(), Name = "hungarian" }},
                    {"western", new PlaceCategory { Id = Guid.NewGuid(), Name = "western" }},
                    {"european", new PlaceCategory { Id = Guid.NewGuid(), Name = "european" }},
                    {"jamaican", new PlaceCategory { Id = Guid.NewGuid(), Name = "jamaican" }},
                    {"cuban", new PlaceCategory { Id = Guid.NewGuid(), Name = "cuban" }},
                    {"soup", new PlaceCategory { Id = Guid.NewGuid(), Name = "soup" }},
                    {"uzbek", new PlaceCategory { Id = Guid.NewGuid(), Name = "uzbek" }},
                    {"nepalese", new PlaceCategory { Id = Guid.NewGuid(), Name = "nepalese" }},
                    {"czech", new PlaceCategory { Id = Guid.NewGuid(), Name = "czech" }},
                    {"syrian", new PlaceCategory { Id = Guid.NewGuid(), Name = "syrian" }},
                    {"afghan", new PlaceCategory { Id = Guid.NewGuid(), Name = "afghan" }},
                    {"malay", new PlaceCategory { Id = Guid.NewGuid(), Name = "malay" }},
                    {"chili", new PlaceCategory { Id = Guid.NewGuid(), Name = "chili" }},
                    {"belgian", new PlaceCategory { Id = Guid.NewGuid(), Name = "belgian" }},
                    {"ukrainian", new PlaceCategory { Id = Guid.NewGuid(), Name = "ukrainian" }},
                    {"swedish", new PlaceCategory { Id = Guid.NewGuid(), Name = "swedish" }},
                    {"pakistani", new PlaceCategory { Id = Guid.NewGuid(), Name = "pakistani" }},
                {"fast_food", new PlaceCategory { Id = Guid.NewGuid(), Name = "fast_food" }},
                    {"pizza_fast_food", new PlaceCategory { Id = Guid.NewGuid(), Name = "pizza" }},
                    {"burger_fast_food", new PlaceCategory { Id = Guid.NewGuid(), Name = "burger" }},
                    {"sandwich_fast_food", new PlaceCategory { Id = Guid.NewGuid(), Name = "sandwich" }},
                    {"kebab_fast_food", new PlaceCategory { Id = Guid.NewGuid(), Name = "kebab" }},
                    {"fish_and_chips_fast_food", new PlaceCategory { Id = Guid.NewGuid(), Name = "fish_and_chips" }},
                    {"noodle_fast_food", new PlaceCategory { Id = Guid.NewGuid(), Name = "noodle" }},
                    {"ramen_fast_food", new PlaceCategory { Id = Guid.NewGuid(), Name = "ramen" }},
                    {"wings_fast_food", new PlaceCategory { Id = Guid.NewGuid(), Name = "wings" }},
                    {"tapas_fast_food", new PlaceCategory { Id = Guid.NewGuid(), Name = "tapas" }},
                    {"pita_fast_food", new PlaceCategory { Id = Guid.NewGuid(), Name = "pita" }},
                    {"tacos_fast_food", new PlaceCategory { Id = Guid.NewGuid(), Name = "tacos" }},
                    {"soup_fast_food", new PlaceCategory { Id = Guid.NewGuid(), Name = "soup" }},
                    {"salad_fast_food", new PlaceCategory { Id = Guid.NewGuid(), Name = "salad" }},
                    {"hot_dog_fast_food", new PlaceCategory { Id = Guid.NewGuid(), Name = "hot_dog" }},
                {"cafe", new PlaceCategory { Id = Guid.NewGuid(), Name = "cafe" }},
                    {"waffle", new PlaceCategory { Id = Guid.NewGuid(), Name = "waffle" }},
                    {"ice_cream_cafe", new PlaceCategory { Id = Guid.NewGuid(), Name = "ice_cream" }},
                    {"coffee_shop", new PlaceCategory { Id = Guid.NewGuid(), Name = "coffee_shop" }},
                    {"donut", new PlaceCategory { Id = Guid.NewGuid(), Name = "donut" }},
                    {"crepe", new PlaceCategory { Id = Guid.NewGuid(), Name = "crepe" }},
                    {"bubble_tea", new PlaceCategory { Id = Guid.NewGuid(), Name = "bubble_tea" }},
                    {"cake", new PlaceCategory { Id = Guid.NewGuid(), Name = "cake" }},
                    {"frozen_yogurt", new PlaceCategory { Id = Guid.NewGuid(), Name = "frozen_yogurt" }},
                    {"dessert", new PlaceCategory { Id = Guid.NewGuid(), Name = "dessert" }},
                    {"coffee", new PlaceCategory { Id = Guid.NewGuid(), Name = "coffee" }},
                    {"tea", new PlaceCategory { Id = Guid.NewGuid(), Name = "tea" }},
                {"food_court", new PlaceCategory { Id = Guid.NewGuid(), Name = "food_court" }},
                {"bar", new PlaceCategory { Id = Guid.NewGuid(), Name = "bar" }},
                {"pub", new PlaceCategory { Id = Guid.NewGuid(), Name = "pub" }},
                {"ice_cream", new PlaceCategory { Id = Guid.NewGuid(), Name = "ice_cream" }},
                {"biergarten", new PlaceCategory { Id = Guid.NewGuid(), Name = "biergarten" }},
                {"taproom", new PlaceCategory { Id = Guid.NewGuid(), Name = "taproom" }}
        };

        placeCategories["gift_and_souvenir"].SuperCategoryId = placeCategories["commercial"].Id;
        placeCategories["art"].SuperCategoryId = placeCategories["commercial"].Id;
        placeCategories["culture"].SuperCategoryId = placeCategories["entertainment"].Id;
            placeCategories["theatre"].SuperCategoryId = placeCategories["culture"].Id;
            placeCategories["arts_centre"].SuperCategoryId = placeCategories["culture"].Id;
            placeCategories["gallery"].SuperCategoryId = placeCategories["culture"].Id;
        placeCategories["zoo"].SuperCategoryId = placeCategories["entertainment"].Id;
        placeCategories["aquarium"].SuperCategoryId = placeCategories["entertainment"].Id;
        placeCategories["planetarium"].SuperCategoryId = placeCategories["entertainment"].Id;
        placeCategories["museum"].SuperCategoryId = placeCategories["entertainment"].Id;
        placeCategories["unesco"].SuperCategoryId = placeCategories["heritage"].Id;
        placeCategories["park"].SuperCategoryId = placeCategories["leisure"].Id;
            placeCategories["garden"].SuperCategoryId = placeCategories["park"].Id;
            placeCategories["nature_reserve"].SuperCategoryId = placeCategories["park"].Id;
        placeCategories["forest"].SuperCategoryId = placeCategories["natural"].Id;
        placeCategories["water"].SuperCategoryId = placeCategories["natural"].Id;
            placeCategories["spring"].SuperCategoryId = placeCategories["water"].Id;
            placeCategories["reef"].SuperCategoryId = placeCategories["water"].Id;
            placeCategories["hot_spring"].SuperCategoryId = placeCategories["water"].Id;
            placeCategories["geyser"].SuperCategoryId = placeCategories["water"].Id;
            placeCategories["sea"].SuperCategoryId = placeCategories["water"].Id;
        placeCategories["mountain"].SuperCategoryId = placeCategories["natural"].Id;
            placeCategories["peak"].SuperCategoryId = placeCategories["mountain"].Id;
            placeCategories["glacier"].SuperCategoryId = placeCategories["mountain"].Id;
            placeCategories["cliff"].SuperCategoryId = placeCategories["mountain"].Id;
            placeCategories["rock"].SuperCategoryId = placeCategories["mountain"].Id;
            placeCategories["cave_entrance"].SuperCategoryId = placeCategories["mountain"].Id;
        placeCategories["sand"].SuperCategoryId = placeCategories["natural"].Id;
            placeCategories["dune"].SuperCategoryId = placeCategories["sand"].Id;
        placeCategories["attraction"].SuperCategoryId = placeCategories["tourism"].Id;
            placeCategories["artwork"].SuperCategoryId = placeCategories["attraction"].Id;
            placeCategories["viewpoint"].SuperCategoryId = placeCategories["attraction"].Id;
            placeCategories["fountain"].SuperCategoryId = placeCategories["attraction"].Id;
            placeCategories["clock"].SuperCategoryId = placeCategories["attraction"].Id;
        placeCategories["sights"].SuperCategoryId = placeCategories["tourism"].Id;
            placeCategories["place_of_worship"].SuperCategoryId = placeCategories["sights"].Id;
                placeCategories["church"].SuperCategoryId = placeCategories["place_of_worship"].Id;
                placeCategories["chapel"].SuperCategoryId = placeCategories["place_of_worship"].Id;
                placeCategories["cathedral"].SuperCategoryId = placeCategories["place_of_worship"].Id;
                placeCategories["synagogue"].SuperCategoryId = placeCategories["place_of_worship"].Id;
                placeCategories["shrine"].SuperCategoryId = placeCategories["place_of_worship"].Id;
                placeCategories["mosque"].SuperCategoryId = placeCategories["place_of_worship"].Id;
                placeCategories["temple"].SuperCategoryId = placeCategories["place_of_worship"].Id;
            placeCategories["monastery"].SuperCategoryId = placeCategories["sights"].Id;
            placeCategories["city_hall"].SuperCategoryId = placeCategories["sights"].Id;
            placeCategories["lighthouse"].SuperCategoryId = placeCategories["sights"].Id;
            placeCategories["windmill"].SuperCategoryId = placeCategories["sights"].Id;
            placeCategories["tower"].SuperCategoryId = placeCategories["sights"].Id;
            placeCategories["battlefield"].SuperCategoryId = placeCategories["sights"].Id;
            placeCategories["fort"].SuperCategoryId = placeCategories["sights"].Id;
            placeCategories["castle"].SuperCategoryId = placeCategories["sights"].Id;
            placeCategories["ruines"].SuperCategoryId = placeCategories["sights"].Id;
            placeCategories["archaeological_site"].SuperCategoryId = placeCategories["sights"].Id;
            placeCategories["city_gate"].SuperCategoryId = placeCategories["sights"].Id;
            placeCategories["bridge"].SuperCategoryId = placeCategories["sights"].Id;
            placeCategories["memorial"].SuperCategoryId = placeCategories["sights"].Id;
                placeCategories["aircraft"].SuperCategoryId = placeCategories["memorial"].Id;
                placeCategories["locomotive"].SuperCategoryId = placeCategories["memorial"].Id;
                placeCategories["railway_car"].SuperCategoryId = placeCategories["memorial"].Id;
                placeCategories["ship"].SuperCategoryId = placeCategories["memorial"].Id;
                placeCategories["tank"].SuperCategoryId = placeCategories["memorial"].Id;
                placeCategories["tomb"].SuperCategoryId = placeCategories["memorial"].Id;
                placeCategories["monument"].SuperCategoryId = placeCategories["memorial"].Id;
                placeCategories["wayside_cross"].SuperCategoryId = placeCategories["memorial"].Id;
                placeCategories["boundary_stone"].SuperCategoryId = placeCategories["memorial"].Id;
                placeCategories["pillory"].SuperCategoryId = placeCategories["memorial"].Id;
                placeCategories["milestone"].SuperCategoryId = placeCategories["memorial"].Id;
        placeCategories["place_of_worship_religion"].SuperCategoryId = placeCategories["religion"].Id;
            placeCategories["buddhism"].SuperCategoryId = placeCategories["place_of_worship_religion"].Id;
            placeCategories["christianity"].SuperCategoryId = placeCategories["place_of_worship_religion"].Id;
            placeCategories["hinduism"].SuperCategoryId = placeCategories["place_of_worship_religion"].Id;
            placeCategories["islam"].SuperCategoryId = placeCategories["place_of_worship_religion"].Id;
            placeCategories["judaism"].SuperCategoryId = placeCategories["place_of_worship_religion"].Id;
            placeCategories["shinto"].SuperCategoryId = placeCategories["place_of_worship_religion"].Id;
            placeCategories["sikhism"].SuperCategoryId = placeCategories["place_of_worship_religion"].Id;
            placeCategories["multifaith"].SuperCategoryId = placeCategories["place_of_worship_religion"].Id;
        placeCategories["stadium"].SuperCategoryId = placeCategories["sport"].Id;
        placeCategories["restaurant"].SuperCategoryId = placeCategories["catering"].Id;
            placeCategories["pizza"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["burger"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["regional"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["italian"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["chinese"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["sandwich"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["chicken"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["mexican"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["japanese"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["american"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["kebab"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["indian"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["asian"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["sushi"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["french"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["german"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["thai"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["greek"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["seafood"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["fish_and_chips"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["steak_house"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["international"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["tex-mex"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["vietnamese"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["turkish"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["korean"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["noodle"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["barbecue"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["spanish"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["fish"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["ramen"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["mediterranean"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["friture"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["beef_bowl"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["lebanese"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["wings"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["georgian"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["tapas"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["indonesian"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["arab"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["portuguese"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["russian"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["filipino"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["african"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["malaysian"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["caribbean"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["peruvian"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["bavarian"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["brazilian"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["curry"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["dumpling"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["persian"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["argentinian"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["oriental"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["balkan"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["moroccan"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["pita"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["ethiopian"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["taiwanese"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["latin_american"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["hawaiian"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["irish"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["austrian"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["croatian"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["danish"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["tacos"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["bolivian"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["hungarian"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["western"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["european"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["jamaican"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["cuban"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["soup"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["uzbek"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["nepalese"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["czech"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["syrian"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["afghan"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["malay"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["chili"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["belgian"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["ukrainian"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["swedish"].SuperCategoryId = placeCategories["restaurant"].Id;
            placeCategories["pakistani"].SuperCategoryId = placeCategories["restaurant"].Id;
        placeCategories["fast_food"].SuperCategoryId = placeCategories["catering"].Id;
            placeCategories["pizza_fast_food"].SuperCategoryId = placeCategories["fast_food"].Id;
            placeCategories["burger_fast_food"].SuperCategoryId = placeCategories["fast_food"].Id;
            placeCategories["sandwich_fast_food"].SuperCategoryId = placeCategories["fast_food"].Id;
            placeCategories["kebab_fast_food"].SuperCategoryId = placeCategories["fast_food"].Id;
            placeCategories["fish_and_chips_fast_food"].SuperCategoryId = placeCategories["fast_food"].Id;
            placeCategories["noodle_fast_food"].SuperCategoryId = placeCategories["fast_food"].Id;
            placeCategories["ramen_fast_food"].SuperCategoryId = placeCategories["fast_food"].Id;
            placeCategories["wings_fast_food"].SuperCategoryId = placeCategories["fast_food"].Id;
            placeCategories["tapas_fast_food"].SuperCategoryId = placeCategories["fast_food"].Id;
            placeCategories["pita_fast_food"].SuperCategoryId = placeCategories["fast_food"].Id;
            placeCategories["tacos_fast_food"].SuperCategoryId = placeCategories["fast_food"].Id;
            placeCategories["soup_fast_food"].SuperCategoryId = placeCategories["fast_food"].Id;
            placeCategories["salad_fast_food"].SuperCategoryId = placeCategories["fast_food"].Id;
            placeCategories["hot_dog_fast_food"].SuperCategoryId = placeCategories["fast_food"].Id;
        placeCategories["cafe"].SuperCategoryId = placeCategories["catering"].Id;
            placeCategories["waffle"].SuperCategoryId = placeCategories["cafe"].Id;
            placeCategories["ice_cream_cafe"].SuperCategoryId = placeCategories["cafe"].Id;
            placeCategories["coffee_shop"].SuperCategoryId = placeCategories["cafe"].Id;
            placeCategories["donut"].SuperCategoryId = placeCategories["cafe"].Id;
            placeCategories["crepe"].SuperCategoryId = placeCategories["cafe"].Id;
            placeCategories["bubble_tea"].SuperCategoryId = placeCategories["cafe"].Id;
            placeCategories["cake"].SuperCategoryId = placeCategories["cafe"].Id;
            placeCategories["frozen_yogurt"].SuperCategoryId = placeCategories["cafe"].Id;
            placeCategories["dessert"].SuperCategoryId = placeCategories["cafe"].Id;
            placeCategories["coffee"].SuperCategoryId = placeCategories["cafe"].Id;
            placeCategories["tea"].SuperCategoryId = placeCategories["cafe"].Id;
        placeCategories["food_court"].SuperCategoryId = placeCategories["catering"].Id;
        placeCategories["bar"].SuperCategoryId = placeCategories["catering"].Id;
        placeCategories["pub"].SuperCategoryId = placeCategories["catering"].Id;
        placeCategories["ice_cream"].SuperCategoryId = placeCategories["catering"].Id;
        placeCategories["biergarten"].SuperCategoryId = placeCategories["catering"].Id;
        placeCategories["taproom"].SuperCategoryId = placeCategories["catering"].Id;
        

        modelBuilder.Entity<PlaceCategory>().HasData(placeCategories.Values.ToList<PlaceCategory>());


        //CONDITIONS
        var placeConditions = new Dictionary<String, PlaceCondition>
        {

            {"internet_access", new PlaceCondition { Id = Guid.NewGuid(), Name = "internet_access" }},
                {"free", new PlaceCondition { Id = Guid.NewGuid(), Name = "free" }},
                {"for_customers", new PlaceCondition { Id = Guid.NewGuid(), Name = "for_customers" }},
            {"wheelchair", new PlaceCondition { Id = Guid.NewGuid(), Name = "wheelchair" }},
                {"yes_wheelchair", new PlaceCondition { Id = Guid.NewGuid(), Name = "yes" }},
                {"limited_wheelchair", new PlaceCondition { Id = Guid.NewGuid(), Name = "limited" }},
            {"dogs", new PlaceCondition { Id = Guid.NewGuid(), Name = "dogs" }},
                {"yes_dogs", new PlaceCondition { Id = Guid.NewGuid(), Name = "yes" }},
                {"leashed_dogs", new PlaceCondition { Id = Guid.NewGuid(), Name = "leashed" }},
            {"no-dogs", new PlaceCondition { Id = Guid.NewGuid(), Name = "no-dogs" }},
            {"access", new PlaceCondition { Id = Guid.NewGuid(), Name = "access" }},
                {"yes_access", new PlaceCondition { Id = Guid.NewGuid(), Name = "yes" ,Description="Places that are available for public"}},
                {"not_specified_access", new PlaceCondition { Id = Guid.NewGuid(), Name = "not_specified" }},
            {"access_limited", new PlaceCondition { Id = Guid.NewGuid(), Name = "access_limited" }},
                {"customers", new PlaceCondition { Id = Guid.NewGuid(), Name = "customers" }},
            {"fee", new PlaceCondition { Id = Guid.NewGuid(), Name = "fee" }},
            {"no_fee", new PlaceCondition { Id = Guid.NewGuid(), Name = "no_fee" ,Description="There is no fee or it's not specified"}},
                {"no", new PlaceCondition { Id = Guid.NewGuid(), Name = "no" }},
                {"not_specified_no_fee", new PlaceCondition { Id = Guid.NewGuid(), Name = "not_specified" }},
            {"named", new PlaceCondition { Id = Guid.NewGuid(), Name = "named" ,Description="Name property defined for the place"}},
            {"vegetarian", new PlaceCondition { Id = Guid.NewGuid(), Name = "vegetarian" ,Description="Places where you can buy or eat vegetarian food"}},
                {"only_vegetarian", new PlaceCondition { Id = Guid.NewGuid(), Name = "only" }},
            {"vegan", new PlaceCondition { Id = Guid.NewGuid(), Name = "vegan" ,Description="Places where you can buy or eat vegan food"}},
                {"only_vegan", new PlaceCondition { Id = Guid.NewGuid(), Name = "only" }},
            {"halal", new PlaceCondition { Id = Guid.NewGuid(), Name = "halal" ,Description="Places where you can buy or eat halal food"}},
                {"only_halal", new PlaceCondition { Id = Guid.NewGuid(), Name = "only" }},
            {"kosher", new PlaceCondition { Id = Guid.NewGuid(), Name = "kosher" ,Description="Places where you can buy or eat kosher food"}},
                {"only_kosher", new PlaceCondition { Id = Guid.NewGuid(), Name = "only" }},
            {"organic", new PlaceCondition { Id = Guid.NewGuid(), Name = "organic" ,Description="Places where you can buy or eat organic food"}},
                {"only_organic", new PlaceCondition { Id = Guid.NewGuid(), Name = "only" }},
            {"gluten_free", new PlaceCondition { Id = Guid.NewGuid(), Name = "gluten_free" ,Description="Places where you can buy or eat gluten free food"}},
            {"sugar_free", new PlaceCondition { Id = Guid.NewGuid(), Name = "sugar_free" ,Description="Places where you can buy or eat sugar free food"}},
            {"egg_free", new PlaceCondition { Id = Guid.NewGuid(), Name = "egg_free" ,Description="Places where you can buy or eat egg free food"}},
            {"soy_free", new PlaceCondition { Id = Guid.NewGuid(), Name = "soy_free" ,Description="Places where you can buy or eat soy free food"}}
        };

            placeConditions["free"].SuperConditionId = placeConditions["internet_access"].Id;
            placeConditions["for_customers"].SuperConditionId = placeConditions["internet_access"].Id;
            placeConditions["yes_wheelchair"].SuperConditionId = placeConditions["wheelchair"].Id;
            placeConditions["limited_wheelchair"].SuperConditionId = placeConditions["wheelchair"].Id;
            placeConditions["yes_dogs"].SuperConditionId = placeConditions["dogs"].Id;
            placeConditions["leashed_dogs"].SuperConditionId = placeConditions["dogs"].Id;
            placeConditions["yes_access"].SuperConditionId = placeConditions["access"].Id;
            placeConditions["not_specified_access"].SuperConditionId = placeConditions["access"].Id;
            placeConditions["customers"].SuperConditionId = placeConditions["access_limited"].Id;
            placeConditions["no"].SuperConditionId = placeConditions["no_fee"].Id;
            placeConditions["not_specified_no_fee"].SuperConditionId = placeConditions["no_fee"].Id;
            placeConditions["only_vegetarian"].SuperConditionId = placeConditions["vegetarian"].Id;
            placeConditions["only_vegan"].SuperConditionId = placeConditions["vegan"].Id;
            placeConditions["only_halal"].SuperConditionId = placeConditions["halal"].Id;
            placeConditions["only_kosher"].SuperConditionId = placeConditions["kosher"].Id;
            placeConditions["only_organic"].SuperConditionId = placeConditions["organic"].Id;



        modelBuilder.Entity<PlaceCondition>().HasData(placeConditions.Values.ToList<PlaceCondition>());
    }
}