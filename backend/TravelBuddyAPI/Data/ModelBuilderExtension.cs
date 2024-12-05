using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic;
using TravelBuddyAPI.Enums;
using TravelBuddyAPI.Models;

public static class ModelBuilderExtension
{
    public static void Seed(this ModelBuilder modelBuilder)
    {

        //CATEGORIES
        var placeCategories = new Dictionary<String, PlaceCategory>
        {
            {"other", new PlaceCategory { Id = Guid.NewGuid(), Name = "other" }},
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


        // PROVIDER PLACE
        var providerPlaces = new List<Place>
        {
            new ProviderPlace { Id = Guid.NewGuid(), Name = "Moszczanka", City = "Moszczanka", Country = "Poland", Latitude = 51.73196580m, Longitude = 17.76554860m, ProviderId = "51a37f38fefac33140592e652a0eb1dd4940f00103f9010828e50100000000c0020792030936332d3434302b706c", State = "Greater Poland Voivodeship"},
            new ProviderPlace { Id = Guid.NewGuid(), Name = "Kaplica loretańska", ProviderId = "51429f46469ebd314059b810faa9f1dd4940f00102f901f7527713000000009203134b61706c696361206c6f72657461c584736b61"},
            new ProviderPlace { Id = Guid.NewGuid(), Name = "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", City = "Raszków", Country = "Poland", Latitude = 51.71827680m, Longitude = 17.72748940m, ProviderId = "51c92fcdbe3cba31405921e7807ef0db4940f00103f901e5860fed0100000092033e426f68617465726f6d204920776f6a6e7920c59b776961746f77656a206920506f6c6567c582796d207a6120576f6c6e6fc59bc487204f6a637a797a6e79", State = "Greater Poland Voivodeship", Street = "Rynek", HouseNumber = "32"},
            new ProviderPlace { Id = Guid.NewGuid(), Name = "Jana Pawła II", City = "Raszków", Country = "Poland", Latitude = 51.7165523m, Longitude = 17.7274935m, ProviderId = "51768d96033dba314059315a59fcb7db4940f00103f901262f10ed0100000092030e4a616e6120506177c58261204949", State = "Greater Poland Voivodeship", Street = "Kościelna"},
            
            new ProviderPlace { Id = Guid.NewGuid(), Name = "Samolot MIG", City = "Ostrów Wielkopolski", Country = "Poland", Latitude = 51.6550975m, Longitude = 17.8059913m, ProviderId = "514b5c227255ce314059cd461f3cdad34940f00103f901c95100f70000000092030b53616d6f6c6f74204d4947", State = "Greater Poland Voivodeship", Street = "Raszkowska"},
            new ProviderPlace { Id = Guid.NewGuid(), Name = "Pomnik 60 Pułku Piechoty", City = "Ostrów Wielkopolski", Country = "Poland", Latitude = 51.652452m, Longitude = 17.8150573m, ProviderId = "51b6dd5f98a7d031405953490f8c83d34940f00103f901c3b040f600000000920319506f6d6e696b203630205075c5826b752050696563686f7479"},
            new ProviderPlace { Id = Guid.NewGuid(), Name = "Bistro Bravo", City = "Ostrów Wielkopolski", Country = "Poland", Latitude = 51.6494557m, Longitude = 17.8174638m, ProviderId = "51f4a9be4e45d13140596108465d21d34940f00103f901d44b66110100000092030c42697374726f20427261766f", State = "Greater Poland Voivodeship", Street = "Rynek", HouseNumber = "15", OpeningHours = "Mo-Th 12:00-24:00; Fr-Su 12:00-24:00+"},
            
            new ProviderPlace { Id = Guid.NewGuid(), Name = "Wrocław", City = "Wrocław", Country = "Poland", Latitude = 51.10897760m, Longitude = 17.03266890m, ProviderId = "51dfc081e697fa30405906310a6025904940f00101f901bce3060000000000c0020992030857726f63c5826177", State = "Lower Silesian Voivodeship"},
            new ProviderPlace { Id = Guid.NewGuid(), Name = "ZOO Wrocław", City = "Wrocław", Country = "Poland", Latitude = 51.10425535m, Longitude = 17.07484842m, ProviderId = "513a952f4429133140591ab1413d588d4940f00102f901012324020000000092030c5a4f4f2057726f63c5826177", State = "Lower Silesian Voivodeship", Street = "Zygmunta Wróblewskiego", HouseNumber = "1-5", OpeningHours = "Mar: Mo-Su 09:00-16:00; Apr-Sep: Mo-Fr 09:00-17:00; Apr-Sep: Sa,Su,PH 09:00-18:00; Oct: Mo-Su 09:00-16:00; Nov-Feb: Mo-Su 09:00-15:00"},
            new ProviderPlace { Id = Guid.NewGuid(), Name = "Wrocławska Fontanna", City = "Wrocław", Country = "Poland", Latitude = 51.10864425m, Longitude = 17.07875630m, ProviderId = "51299d5f5f291431405946ac040ee88d4940f00102f901e25aa7020000000092031457726f63c5826177736b6120466f6e74616e6e61", State = "Lower Silesian Voivodeship", OpeningHours = "May-Oct: 00:00-24:00; Nov-Apr: Off"},
            new ProviderPlace { Id = Guid.NewGuid(), Name = "Hala Stulecia", City = "Wrocław", Country = "Poland", Latitude = 51.10688750m, Longitude = 17.07731849m, ProviderId = "5159f5f324cb1331405964c6547dae8d4940f00102f90136e6691c0000000092030d48616c61205374756c65636961", State = "Lower Silesian Voivodeship", Street = "Wystawowa", HouseNumber = "1", OpeningHours = "Su-Th 09:00-18:00; Fr-Sa 09:00-19:00"},
            new ProviderPlace { Id = Guid.NewGuid(), Name = "Muzeum Archeologiczne", City = "Wrocław", Country = "Poland", Latitude = 51.11288660m, Longitude = 17.02688220m, ProviderId = "5133d879c0e106314059f2ec6d11738e4940f00103f901710a264c000000009203154d757a65756d2041726368656f6c6f6769637a6e65", State = "Lower Silesian Voivodeship", Street = "Antoniego Cieszyńskiego", HouseNumber = "9", OpeningHours = "We-Sa 11:00-17:00; Su 10:00-18:00"},
            new ProviderPlace { Id = Guid.NewGuid(), Name = "Kościół Najświętszej Maryi Panny Matki Pocieszenia", City = "Wrocław", Country = "Poland", Latitude = 51.10248345m, Longitude = 17.08599881m, ProviderId = "51324592040416314059a36a7b2d1e8d4940f00102f9010d300706000000009203374b6fc59b6369c3b3c582204e616ac59b7769c49974737a656a204d617279692050616e6e79204d61746b6920506f636965737a656e6961", State = "Lower Silesian Voivodeship", Street = "Edwarda Wittiga"},
            new ProviderPlace { Id = Guid.NewGuid(), Name = "Bolesław Chrobry", City = "Wrocław", Country = "Poland", Latitude = 51.10432090m, Longitude = 17.03133350m, ProviderId = "51eac4e5780508314059b43e21635a8d4940f00103f901ace8111000000000920311426f6c6573c5826177204368726f627279", State = "Lower Silesian Voivodeship", OpeningHours = "24/7"},
            new ProviderPlace { Id = Guid.NewGuid(), Name = "Ratusz", City = "Wrocław", Country = "Poland", Latitude = 51.10957585m, Longitude = 17.03206577m, ProviderId = "51b849627635083140596870d894068e4940f00102f90138ce3f330000000092030652617475737a", State = "Lower Silesian Voivodeship", Street = "Rynek Ratusz", OpeningHours = "We-Sa 10:00-17:00; Su 10:00-18:00"},
            new ProviderPlace { Id = Guid.NewGuid(), Name = "Ogród Japoński", City = "Wrocław", Country = "Poland", Latitude = 51.10994465m, Longitude = 17.07986499m, ProviderId = "51d8ce250872143140598b6890aa128e4940f00102f9014c34de0f000000009203104f6772c3b364204a61706fc584736b69", State = "Lower Silesian Voivodeship", Street = "aleja Dąbska", OpeningHours = "Apr-Oct: Mo-Su,PH 09:00-19:00"},
            new ProviderPlace { Id = Guid.NewGuid(), Name = "Muzeum Historyczne i Muzeum Sztuki Medalierskiej", City = "Wrocław", Country = "Poland", Latitude = 51.10744710m, Longitude = 17.02887780m, ProviderId = "51979416896407314059ca9f98d3c08d4940f00103f9010992932b020000009203304d757a65756d20486973746f7279637a6e652069204d757a65756d20537a74756b69204d6564616c696572736b69656a", State = "Lower Silesian Voivodeship", Street = "Kazimierza Wielkiego", HouseNumber = "35", OpeningHours = "We-Sa 11:00-17:00; Su 10:00-18:00"}
        };

        modelBuilder.Entity<ProviderPlace>().HasData(providerPlaces);

        // CUSTOM PLACE
        var CustomPlaces = new List<Place>
        {
            new CustomPlace { Id = Guid.NewGuid(), Name = "Zalew", City = "Raszków", Country = "Poland", Latitude = 51.711806m, Longitude = 17.721194m},
            new CustomPlace { Id = Guid.NewGuid(), Name = "Kościół w parku", City = "Przybysławice", Country = "Poland", Latitude = 51.707396m, Longitude = 17.720968m},
            new CustomPlace { Id = Guid.NewGuid(), Name = "Parowóz TKi3-120", City = "Ostrów Wielkopolski", Country = "Poland", Latitude = 51.6514858m, Longitude = 17.810879178559084m},
        

            new CustomPlace { Id = Guid.NewGuid(), Name = "Zalew", City = "Raszków", Country = "Poland", Latitude = 51.711806m, Longitude = 17.721194m},
            new CustomPlace { Id = Guid.NewGuid(), Name = "Kościół w parku", City = "Przybysławice", Country = "Poland", Latitude = 51.707396m, Longitude = 17.720968m},
            new CustomPlace { Id = Guid.NewGuid(), Name = "Parowóz TKi3-120", City = "Ostrów Wielkopolski", Country = "Poland", Latitude = 51.6514858m, Longitude = 17.810879178559084m},
        };

        modelBuilder.Entity<CustomPlace>().HasData(CustomPlaces);

        //PROVIDER PLACE - PLACE CATEGORY

       modelBuilder.Entity("ProviderPlacePlaceCategory").HasData(
            new { ProviderPlaceId = providerPlaces[1].Id, PlaceCategoryId = placeCategories["sights"].Id },
            new { ProviderPlaceId = providerPlaces[1].Id, PlaceCategoryId = placeCategories["attraction"].Id },
            new { ProviderPlaceId = providerPlaces[1].Id, PlaceCategoryId = placeCategories["tourism"].Id },
            new { ProviderPlaceId = providerPlaces[1].Id, PlaceCategoryId = placeCategories["ruines"].Id },

            new { ProviderPlaceId = providerPlaces[2].Id, PlaceCategoryId = placeCategories["sights"].Id },
            new { ProviderPlaceId = providerPlaces[2].Id, PlaceCategoryId = placeCategories["memorial"].Id },
            new { ProviderPlaceId = providerPlaces[2].Id, PlaceCategoryId = placeCategories["tourism"].Id },

            new { ProviderPlaceId = providerPlaces[3].Id, PlaceCategoryId = placeCategories["sights"].Id },
            new { ProviderPlaceId = providerPlaces[3].Id, PlaceCategoryId = placeCategories["memorial"].Id },
            new { ProviderPlaceId = providerPlaces[3].Id, PlaceCategoryId = placeCategories["tourism"].Id },

            new { ProviderPlaceId = providerPlaces[4].Id, PlaceCategoryId = placeCategories["sights"].Id },
            new { ProviderPlaceId = providerPlaces[4].Id, PlaceCategoryId = placeCategories["memorial"].Id },
            new { ProviderPlaceId = providerPlaces[4].Id, PlaceCategoryId = placeCategories["tourism"].Id },

            new { ProviderPlaceId = providerPlaces[5].Id, PlaceCategoryId = placeCategories["sights"].Id },
            new { ProviderPlaceId = providerPlaces[5].Id, PlaceCategoryId = placeCategories["memorial"].Id },
            new { ProviderPlaceId = providerPlaces[5].Id, PlaceCategoryId = placeCategories["tourism"].Id },

            new { ProviderPlaceId = providerPlaces[6].Id, PlaceCategoryId = placeCategories["restaurant"].Id },
            new { ProviderPlaceId = providerPlaces[6].Id, PlaceCategoryId = placeCategories["catering"].Id },

            new { ProviderPlaceId = providerPlaces[8].Id, PlaceCategoryId = placeCategories["zoo"].Id },
            new { ProviderPlaceId = providerPlaces[8].Id, PlaceCategoryId = placeCategories["entertainment"].Id },

            new { ProviderPlaceId = providerPlaces[9].Id, PlaceCategoryId = placeCategories["fountain"].Id },
            new { ProviderPlaceId = providerPlaces[9].Id, PlaceCategoryId = placeCategories["tourism"].Id },
            new { ProviderPlaceId = providerPlaces[9].Id, PlaceCategoryId = placeCategories["natural"].Id },
            new { ProviderPlaceId = providerPlaces[9].Id, PlaceCategoryId = placeCategories["water"].Id },
            new { ProviderPlaceId = providerPlaces[9].Id, PlaceCategoryId = placeCategories["attraction"].Id },

            new { ProviderPlaceId = providerPlaces[10].Id, PlaceCategoryId = placeCategories["heritage"].Id },
            new { ProviderPlaceId = providerPlaces[10].Id, PlaceCategoryId = placeCategories["unesco"].Id },
            new { ProviderPlaceId = providerPlaces[10].Id, PlaceCategoryId = placeCategories["tourism"].Id },
            new { ProviderPlaceId = providerPlaces[10].Id, PlaceCategoryId = placeCategories["attraction"].Id },
            new { ProviderPlaceId = providerPlaces[10].Id, PlaceCategoryId = placeCategories["sights"].Id },

            new { ProviderPlaceId = providerPlaces[11].Id, PlaceCategoryId = placeCategories["museum"].Id },
            new { ProviderPlaceId = providerPlaces[11].Id, PlaceCategoryId = placeCategories["entertainment"].Id },

            new { ProviderPlaceId = providerPlaces[12].Id, PlaceCategoryId = placeCategories["place_of_worship"].Id },
            new { ProviderPlaceId = providerPlaces[12].Id, PlaceCategoryId = placeCategories["heritage"].Id },
            new { ProviderPlaceId = providerPlaces[12].Id, PlaceCategoryId = placeCategories["religion"].Id },
            new { ProviderPlaceId = providerPlaces[12].Id, PlaceCategoryId = placeCategories["tourism"].Id },
            new { ProviderPlaceId = providerPlaces[12].Id, PlaceCategoryId = placeCategories["place_of_worship_religion"].Id },
            new { ProviderPlaceId = providerPlaces[12].Id, PlaceCategoryId = placeCategories["sights"].Id },
            new { ProviderPlaceId = providerPlaces[12].Id, PlaceCategoryId = placeCategories["christianity"].Id },
            new { ProviderPlaceId = providerPlaces[12].Id, PlaceCategoryId = placeCategories["church"].Id },

            new { ProviderPlaceId = providerPlaces[13].Id, PlaceCategoryId = placeCategories["memorial"].Id },
            new { ProviderPlaceId = providerPlaces[13].Id, PlaceCategoryId = placeCategories["tourism"].Id },
            new { ProviderPlaceId = providerPlaces[13].Id, PlaceCategoryId = placeCategories["sights"].Id },

            new { ProviderPlaceId = providerPlaces[14].Id, PlaceCategoryId = placeCategories["heritage"].Id },
            new { ProviderPlaceId = providerPlaces[14].Id, PlaceCategoryId = placeCategories["tourism"].Id },
            new { ProviderPlaceId = providerPlaces[14].Id, PlaceCategoryId = placeCategories["sights"].Id },

            new { ProviderPlaceId = providerPlaces[15].Id, PlaceCategoryId = placeCategories["garden"].Id },
            new { ProviderPlaceId = providerPlaces[15].Id, PlaceCategoryId = placeCategories["leisure"].Id },
            new { ProviderPlaceId = providerPlaces[15].Id, PlaceCategoryId = placeCategories["park"].Id },
            new { ProviderPlaceId = providerPlaces[15].Id, PlaceCategoryId = placeCategories["tourism"].Id },
            new { ProviderPlaceId = providerPlaces[15].Id, PlaceCategoryId = placeCategories["attraction"].Id },

            new { ProviderPlaceId = providerPlaces[16].Id, PlaceCategoryId = placeCategories["museum"].Id },
            new { ProviderPlaceId = providerPlaces[16].Id, PlaceCategoryId = placeCategories["entertainment"].Id }
        );

        //PROVIDER PLACE - PLACE CONDITION

        modelBuilder.Entity("ProviderPlacePlaceCondition").HasData(

            new { ProviderPlaceId = providerPlaces[8].Id, PlaceConditionId = placeConditions["wheelchair"].Id },
            new { ProviderPlaceId = providerPlaces[8].Id, PlaceConditionId = placeConditions["limited_wheelchair"].Id },

            new { ProviderPlaceId = providerPlaces[9].Id, PlaceConditionId = placeConditions["yes_access"].Id },
            new { ProviderPlaceId = providerPlaces[9].Id, PlaceConditionId = placeConditions["yes_wheelchair"].Id },
            new { ProviderPlaceId = providerPlaces[9].Id, PlaceConditionId = placeConditions["yes_dogs"].Id },
            new { ProviderPlaceId = providerPlaces[9].Id, PlaceConditionId = placeConditions["wheelchair"].Id },

            new { ProviderPlaceId = providerPlaces[10].Id, PlaceConditionId = placeConditions["yes_access"].Id },
            new { ProviderPlaceId = providerPlaces[10].Id, PlaceConditionId = placeConditions["yes_wheelchair"].Id },
            new { ProviderPlaceId = providerPlaces[10].Id, PlaceConditionId = placeConditions["yes_dogs"].Id },
            new { ProviderPlaceId = providerPlaces[10].Id, PlaceConditionId = placeConditions["wheelchair"].Id },

            new { ProviderPlaceId = providerPlaces[11].Id, PlaceConditionId = placeConditions["yes_access"].Id },
            new { ProviderPlaceId = providerPlaces[11].Id, PlaceConditionId = placeConditions["yes_wheelchair"].Id },
            new { ProviderPlaceId = providerPlaces[11].Id, PlaceConditionId = placeConditions["yes_dogs"].Id },
            new { ProviderPlaceId = providerPlaces[11].Id, PlaceConditionId = placeConditions["fee"].Id },
            new { ProviderPlaceId = providerPlaces[11].Id, PlaceConditionId = placeConditions["wheelchair"].Id },

            new { ProviderPlaceId = providerPlaces[12].Id, PlaceConditionId = placeConditions["wheelchair"].Id },
            new { ProviderPlaceId = providerPlaces[12].Id, PlaceConditionId = placeConditions["limited_wheelchair"].Id },

            new { ProviderPlaceId = providerPlaces[13].Id, PlaceConditionId = placeConditions["yes_access"].Id },
            new { ProviderPlaceId = providerPlaces[13].Id, PlaceConditionId = placeConditions["yes_wheelchair"].Id },
            new { ProviderPlaceId = providerPlaces[13].Id, PlaceConditionId = placeConditions["yes_dogs"].Id },
            new { ProviderPlaceId = providerPlaces[13].Id, PlaceConditionId = placeConditions["wheelchair"].Id },

            new { ProviderPlaceId = providerPlaces[14].Id, PlaceConditionId = placeConditions["yes_access"].Id },
            new { ProviderPlaceId = providerPlaces[14].Id, PlaceConditionId = placeConditions["yes_wheelchair"].Id },
            new { ProviderPlaceId = providerPlaces[14].Id, PlaceConditionId = placeConditions["yes_dogs"].Id },
            new { ProviderPlaceId = providerPlaces[14].Id, PlaceConditionId = placeConditions["wheelchair"].Id },

            new { ProviderPlaceId = providerPlaces[15].Id, PlaceConditionId = placeConditions["fee"].Id },
            new { ProviderPlaceId = providerPlaces[15].Id, PlaceConditionId = placeConditions["wheelchair"].Id },
            new { ProviderPlaceId = providerPlaces[15].Id, PlaceConditionId = placeConditions["limited_wheelchair"].Id },

            new { ProviderPlaceId = providerPlaces[16].Id, PlaceConditionId = placeConditions["yes_access"].Id },
            new { ProviderPlaceId = providerPlaces[16].Id, PlaceConditionId = placeConditions["yes_wheelchair"].Id },
            new { ProviderPlaceId = providerPlaces[16].Id, PlaceConditionId = placeConditions["yes_dogs"].Id },
            new { ProviderPlaceId = providerPlaces[16].Id, PlaceConditionId = placeConditions["fee"].Id },
            new { ProviderPlaceId = providerPlaces[16].Id, PlaceConditionId = placeConditions["wheelchair"].Id }
        );

        //CATEGORY PROFILE
        
        var categoryProfile = new CategoryProfile
        {
            Id = Guid.NewGuid(),
            UserId = "c324c822-30c1-7029-7c4f-00799aadf54a",
            Name = "Podstawowy",
        };

        modelBuilder.Entity<CategoryProfile>().HasData(categoryProfile);

        modelBuilder.Entity("CategoryProfilePlaceCategory").HasData(
            new { CategoryProfileId = categoryProfile.Id, PlaceCategoryId = placeCategories["entertainment"].Id },
            new { CategoryProfileId = categoryProfile.Id, PlaceCategoryId = placeCategories["tourism"].Id },
            new { CategoryProfileId = categoryProfile.Id, PlaceCategoryId = placeCategories["natural"].Id }

        );

        //CONDITION PROFILE

        var conditionProfile = new ConditionProfile
        {
            Id = Guid.NewGuid(),
            UserId = "c324c822-30c1-7029-7c4f-00799aadf54a",
            Name = "Podstawowy",
        };

        modelBuilder.Entity<ConditionProfile>().HasData(conditionProfile);

        modelBuilder.Entity("ConditionProfilePlaceCondition").HasData(
            new { ConditionProfileId = conditionProfile.Id, PlaceConditionId = placeConditions["wheelchair"].Id }

        );

        //TRIPS
        var trips = new List<Trip>
        {
            new Trip { Id = Guid.NewGuid(), UserId = "c324c822-30c1-7029-7c4f-00799aadf54a", Name = "Wycieczka do Moszczanki", NumberOfTravelers = 1, StartDate = DateOnly.FromDateTime(new DateTime(2024, 12, 20)), EndDate = DateOnly.FromDateTime(new DateTime(2024, 12, 21)), DestinationId = providerPlaces[0].Id, Budget = 100, CurrencyCode = "PLN", ExchangeRate = 1},
            new Trip { Id = Guid.NewGuid(), UserId = "c324c822-30c1-7029-7c4f-00799aadf54a", Name = "Wycieczka do Moszczanki", NumberOfTravelers = 1, StartDate = DateOnly.FromDateTime(new DateTime(2024, 11, 20)), EndDate = DateOnly.FromDateTime(new DateTime(2024, 11, 21)), DestinationId = providerPlaces[0].Id, Budget = 100, CurrencyCode = "PLN", ExchangeRate = 1},
            new Trip { Id = Guid.NewGuid(), UserId = "c324c822-30c1-7029-7c4f-00799aadf54a", Name = "Wycieczka do Wrocławia", NumberOfTravelers = 1, StartDate = DateOnly.FromDateTime(new DateTime(2025, 12, 06)), EndDate = DateOnly.FromDateTime(new DateTime(2025, 12, 06)), DestinationId = providerPlaces[7].Id, Budget = 200, CurrencyCode = "PLN", ExchangeRate = 1, CategoryProfileId = categoryProfile.Id, ConditionProfileId = conditionProfile.Id},
        };

        modelBuilder.Entity<Trip>().HasData(trips);

        //TRIP DAYS
        var tripDays = new List<TripDay>
        {
            new TripDay { Id = Guid.NewGuid(), TripId = trips[0].Id, Date = DateOnly.FromDateTime(new DateTime(2024, 12, 20))},
            new TripDay { Id = Guid.NewGuid(), TripId = trips[0].Id, Date = DateOnly.FromDateTime(new DateTime(2024, 12, 21))},
            new TripDay { Id = Guid.NewGuid(), TripId = trips[1].Id, Date = DateOnly.FromDateTime(new DateTime(2024, 11, 20))},
            new TripDay { Id = Guid.NewGuid(), TripId = trips[1].Id, Date = DateOnly.FromDateTime(new DateTime(2024, 11, 21))},
            new TripDay { Id = Guid.NewGuid(), TripId = trips[2].Id, Date = DateOnly.FromDateTime(new DateTime(2025, 12, 06))},
        };

        modelBuilder.Entity<TripDay>().HasData(tripDays);

        //TRIP POINTS
        var tripPoints = new List<TripPoint>
        {
            new TripPoint { Id = Guid.NewGuid(), Name = "Kaplica loretanska", TripDayId = tripDays[0].Id, PredictedCost = 0, StartTime = new TimeOnly(10,0,0), EndTime = new TimeOnly(10,20,0), Status = 0, PlaceId = providerPlaces[1].Id, ExchangeRate = 1},
            new TripPoint { Id = Guid.NewGuid(), Name = "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", TripDayId = tripDays[0].Id, PredictedCost = 0, StartTime = new TimeOnly(11,0,0), EndTime = new TimeOnly(11,20,0), Status = 0, PlaceId = providerPlaces[2].Id, ExchangeRate = 1},
            new TripPoint { Id = Guid.NewGuid(), Name = "Jana Pawła II", TripDayId = tripDays[0].Id, PredictedCost = 0, StartTime = new TimeOnly(11,50,0), EndTime = new TimeOnly(12,00,0), Status = 0, PlaceId = providerPlaces[3].Id, ExchangeRate = 1},
            new TripPoint { Id = Guid.NewGuid(), Name = "Zalew", TripDayId = tripDays[0].Id, PredictedCost = 0, StartTime = new TimeOnly(12,30,0), EndTime = new TimeOnly(13,00,0), Status = 0, PlaceId = CustomPlaces[0].Id, ExchangeRate = 1},
            new TripPoint { Id = Guid.NewGuid(), Name = "Kościół w parku", TripDayId = tripDays[0].Id, PredictedCost = 0, StartTime = new TimeOnly(13,30,0), EndTime = new TimeOnly(14,00,0), Status = 0, PlaceId = CustomPlaces[1].Id, ExchangeRate = 1},

            new TripPoint { Id = Guid.NewGuid(), Name = "Samolot MIG", Comment = "Czy to lata?", TripDayId = tripDays[1].Id, PredictedCost = 0, StartTime = new TimeOnly(12,30,0), EndTime = new TimeOnly(12,40,0), Status = 0, PlaceId = providerPlaces[4].Id, ExchangeRate = 1},
            new TripPoint { Id = Guid.NewGuid(), Name = "Pomnik 60 Pułku Piechoty", TripDayId = tripDays[1].Id, PredictedCost = 0, StartTime = new TimeOnly(13,0,0), EndTime = new TimeOnly(13,10,0), Status = 0, PlaceId = providerPlaces[5].Id, ExchangeRate = 1},
            new TripPoint { Id = Guid.NewGuid(), Name = "Bistro Bravo", Comment = "Czas na jedzonko", TripDayId = tripDays[1].Id, PredictedCost = 30, StartTime = new TimeOnly(14,0,0), EndTime = new TimeOnly(15,30,0), Status = 0, PlaceId = providerPlaces[6].Id, ExchangeRate = 1, OpeningTime = new TimeOnly(12,0,0), ClosingTime = new TimeOnly(0,0,0)},
            new TripPoint { Id = Guid.NewGuid(), Name = "Parowóz TKi3-120", TripDayId = tripDays[1].Id, PredictedCost = 0, StartTime = new TimeOnly(16,30,0), EndTime = new TimeOnly(17,0,0), Status = 0, PlaceId = CustomPlaces[2].Id, ExchangeRate = 1},
        


            new TripPoint { Id = Guid.NewGuid(), Name = "Kaplica loretanska", TripDayId = tripDays[2].Id, PredictedCost = 0, StartTime = new TimeOnly(10,0,0), EndTime = new TimeOnly(10,20,0), Status = TripPointStatus.reviewPending, PlaceId = providerPlaces[1].Id, ExchangeRate = 1},
            new TripPoint { Id = Guid.NewGuid(), Name = "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", TripDayId = tripDays[2].Id, PredictedCost = 0, StartTime = new TimeOnly(11,0,0), EndTime = new TimeOnly(11,20,0), Status = TripPointStatus.reviewPending, PlaceId = providerPlaces[2].Id, ExchangeRate = 1},
            new TripPoint { Id = Guid.NewGuid(), Name = "Jana Pawła II", TripDayId = tripDays[2].Id, PredictedCost = 0, StartTime = new TimeOnly(11,50,0), EndTime = new TimeOnly(12,00,0), Status = TripPointStatus.reviewPending, PlaceId = providerPlaces[3].Id, ExchangeRate = 1},
            new TripPoint { Id = Guid.NewGuid(), Name = "Zalew", TripDayId = tripDays[2].Id, PredictedCost = 0, StartTime = new TimeOnly(12,30,0), EndTime = new TimeOnly(13,00,0), Status = TripPointStatus.reviewPending, PlaceId = CustomPlaces[3].Id, ExchangeRate = 1},
            new TripPoint { Id = Guid.NewGuid(), Name = "Kościół w parku", TripDayId = tripDays[2].Id, PredictedCost = 0, StartTime = new TimeOnly(13,30,0), EndTime = new TimeOnly(14,00,0), Status = TripPointStatus.reviewRejected, PlaceId = CustomPlaces[4].Id, ExchangeRate = 1},

            new TripPoint { Id = Guid.NewGuid(), Name = "Samolot MIG", Comment = "Czy to lata?", TripDayId = tripDays[3].Id, PredictedCost = 0, StartTime = new TimeOnly(12,30,0), EndTime = new TimeOnly(12,40,0), Status = TripPointStatus.reviewPending, PlaceId = providerPlaces[4].Id, ExchangeRate = 1},
            new TripPoint { Id = Guid.NewGuid(), Name = "Pomnik 60 Pułku Piechoty", TripDayId = tripDays[3].Id, PredictedCost = 0, StartTime = new TimeOnly(13,0,0), EndTime = new TimeOnly(13,10,0), Status = TripPointStatus.reviewPending, PlaceId = providerPlaces[5].Id, ExchangeRate = 1},
            new TripPoint { Id = Guid.NewGuid(), Name = "Bistro Bravo", Comment = "Czas na jedzonko", TripDayId = tripDays[3].Id, PredictedCost = 30, StartTime = new TimeOnly(14,0,0), EndTime = new TimeOnly(15,30,0), Status = TripPointStatus.reviewPending, PlaceId = providerPlaces[6].Id, ExchangeRate = 1, OpeningTime = new TimeOnly(12,0,0), ClosingTime = new TimeOnly(0,0,0)},
            new TripPoint { Id = Guid.NewGuid(), Name = "Parowóz TKi3-120", TripDayId = tripDays[3].Id, PredictedCost = 5, StartTime = new TimeOnly(16,30,0), EndTime = new TimeOnly(17,0,0), Status = TripPointStatus.reviewPending, PlaceId = CustomPlaces[5].Id, ExchangeRate = 1}
        };

        modelBuilder.Entity<TripPoint>().HasData(tripPoints);

        //TRANSFER POINTS

        var transferPoints = new List<TransferPoint>
        {
            new TransferPoint { Id = Guid.NewGuid(), TripDayId = tripDays[0].Id, TransferTime = new TimeSpan(0,4,21), FromTripPointId = tripPoints[1].Id, ToTripPointId = tripPoints[2].Id, Mode = TransferMode.drive},
            new TransferPoint { Id = Guid.NewGuid(), TripDayId = tripDays[0].Id, TransferTime = new TimeSpan(0,0,55), FromTripPointId = tripPoints[2].Id, ToTripPointId = tripPoints[3].Id, Mode = TransferMode.motorcycle},
            new TransferPoint { Id = Guid.NewGuid(), TripDayId = tripDays[0].Id, TransferTime = new TimeSpan(0,20,0), FromTripPointId = tripPoints[3].Id, ToTripPointId = tripPoints[4].Id},

            new TransferPoint { Id = Guid.NewGuid(), TripDayId = tripDays[1].Id, TransferTime = new TimeSpan(0,3,13), FromTripPointId = tripPoints[5].Id, ToTripPointId = tripPoints[6].Id, Mode = TransferMode.bicycle},
            new TransferPoint { Id = Guid.NewGuid(), TripDayId = tripDays[1].Id, TransferTime = new TimeSpan(0,8,18), FromTripPointId = tripPoints[6].Id, ToTripPointId = tripPoints[7].Id, Mode = TransferMode.walk},
            new TransferPoint { Id = Guid.NewGuid(), TripDayId = tripDays[1].Id, TransferTime = new TimeSpan(0,13,30), FromTripPointId = tripPoints[7].Id, ToTripPointId = tripPoints[8].Id, Mode = TransferMode.walk},
        
        
            new TransferPoint { Id = Guid.NewGuid(), TripDayId = tripDays[2].Id, TransferTime = new TimeSpan(0,4,21), FromTripPointId = tripPoints[10].Id, ToTripPointId = tripPoints[11].Id, Mode = TransferMode.drive},
            new TransferPoint { Id = Guid.NewGuid(), TripDayId = tripDays[2].Id, TransferTime = new TimeSpan(0,0,55), FromTripPointId = tripPoints[11].Id, ToTripPointId = tripPoints[12].Id, Mode = TransferMode.motorcycle},
            new TransferPoint { Id = Guid.NewGuid(), TripDayId = tripDays[2].Id, TransferTime = new TimeSpan(0,20,0), FromTripPointId = tripPoints[12].Id, ToTripPointId = tripPoints[13].Id},

            new TransferPoint { Id = Guid.NewGuid(), TripDayId = tripDays[3].Id, TransferTime = new TimeSpan(0,3,13), FromTripPointId = tripPoints[14].Id, ToTripPointId = tripPoints[15].Id, Mode = TransferMode.bicycle},
            new TransferPoint { Id = Guid.NewGuid(), TripDayId = tripDays[3].Id, TransferTime = new TimeSpan(0,8,18), FromTripPointId = tripPoints[15].Id, ToTripPointId = tripPoints[16].Id, Mode = TransferMode.walk},
            new TransferPoint { Id = Guid.NewGuid(), TripDayId = tripDays[3].Id, TransferTime = new TimeSpan(0,13,30), FromTripPointId = tripPoints[16].Id, ToTripPointId = tripPoints[17].Id, Mode = TransferMode.walk},

        };

        modelBuilder.Entity<TransferPoint>().HasData(transferPoints);


        //REVIEWS

        var reviews = new List<TripPointReview>
        {
            new TripPointReview {PlaceId = providerPlaces[8].Id, ActualCostPerPerson = 80, Rating = 4, ActualTimeSpent = new TimeSpan(1,30,0), Id = Guid.NewGuid(), UserId = Guid.NewGuid().ToString() , TripPointId = null, CurrencyCode = "PLN", ExchangeRate = 1},
            new TripPointReview {PlaceId = providerPlaces[8].Id, ActualCostPerPerson = 75, Rating = 5, ActualTimeSpent = new TimeSpan(2,0,0), Id = Guid.NewGuid(), UserId = Guid.NewGuid().ToString() , TripPointId = null, CurrencyCode = "PLN", ExchangeRate = 1},
            new TripPointReview {PlaceId = providerPlaces[8].Id, ActualCostPerPerson = 100, Rating = 4.5m, ActualTimeSpent = new TimeSpan(1,45,0), Id = Guid.NewGuid(), UserId = Guid.NewGuid().ToString() , TripPointId = null, CurrencyCode = "PLN", ExchangeRate = 1},
            new TripPointReview {PlaceId = providerPlaces[8].Id, ActualCostPerPerson = 85, Rating = 5, ActualTimeSpent = new TimeSpan(1,37,0), Id = Guid.NewGuid(), UserId = Guid.NewGuid().ToString() , TripPointId = null, CurrencyCode = "PLN", ExchangeRate = 1},
            new TripPointReview {PlaceId = providerPlaces[9].Id, ActualCostPerPerson = 0, Rating = 4.5m, ActualTimeSpent = new TimeSpan(0,15,0), Id = Guid.NewGuid(), UserId = Guid.NewGuid().ToString() , TripPointId = null, CurrencyCode = "PLN", ExchangeRate = 1},
            new TripPointReview {PlaceId = providerPlaces[9].Id, ActualCostPerPerson = 0, Rating = 4m, ActualTimeSpent = new TimeSpan(0,10,0), Id = Guid.NewGuid(), UserId = Guid.NewGuid().ToString() , TripPointId = null, CurrencyCode = "PLN", ExchangeRate = 1},
            new TripPointReview {PlaceId = providerPlaces[10].Id, ActualCostPerPerson = 17, Rating = 5, ActualTimeSpent = new TimeSpan(0,25,0), Id = Guid.NewGuid(), UserId = Guid.NewGuid().ToString() , TripPointId = null, CurrencyCode = "PLN", ExchangeRate = 1},
            new TripPointReview {PlaceId = providerPlaces[10].Id, ActualCostPerPerson = 0, Rating = 4.5m, ActualTimeSpent = new TimeSpan(0,15,0), Id = Guid.NewGuid(), UserId = Guid.NewGuid().ToString() , TripPointId = null, CurrencyCode = "PLN", ExchangeRate = 1},
            new TripPointReview {PlaceId = providerPlaces[10].Id, ActualCostPerPerson = 20, Rating = 5, ActualTimeSpent = new TimeSpan(0,30,0), Id = Guid.NewGuid(), UserId = Guid.NewGuid().ToString() , TripPointId = null, CurrencyCode = "PLN", ExchangeRate = 1},
            new TripPointReview {PlaceId = providerPlaces[11].Id, ActualCostPerPerson = 15, Rating = 4, ActualTimeSpent = new TimeSpan(0,35,0), Id = Guid.NewGuid(), UserId = Guid.NewGuid().ToString() , TripPointId = null, CurrencyCode = "PLN", ExchangeRate = 1},
            new TripPointReview {PlaceId = providerPlaces[11].Id, ActualCostPerPerson = 10, Rating = 3.5m, ActualTimeSpent = new TimeSpan(0,20,0), Id = Guid.NewGuid(), UserId = Guid.NewGuid().ToString() , TripPointId = null, CurrencyCode = "PLN", ExchangeRate = 1},
            new TripPointReview {PlaceId = providerPlaces[12].Id, ActualCostPerPerson = 0, Rating = 3.5m, ActualTimeSpent = new TimeSpan(0,10,0), Id = Guid.NewGuid(), UserId = Guid.NewGuid().ToString() , TripPointId = null, CurrencyCode = "PLN", ExchangeRate = 1},
            new TripPointReview {PlaceId = providerPlaces[12].Id, ActualCostPerPerson = 5, Rating = 4, ActualTimeSpent = new TimeSpan(0,8,0), Id = Guid.NewGuid(), UserId = Guid.NewGuid().ToString() , TripPointId = null, CurrencyCode = "PLN", ExchangeRate = 1},
            new TripPointReview {PlaceId = providerPlaces[13].Id, ActualCostPerPerson = 0, Rating = 5, ActualTimeSpent = new TimeSpan(0,5,0), Id = Guid.NewGuid(), UserId = Guid.NewGuid().ToString() , TripPointId = null, CurrencyCode = "PLN", ExchangeRate = 1},
            new TripPointReview {PlaceId = providerPlaces[13].Id, ActualCostPerPerson = 0, Rating = 5, ActualTimeSpent = new TimeSpan(0,7,0), Id = Guid.NewGuid(), UserId = Guid.NewGuid().ToString() , TripPointId = null, CurrencyCode = "PLN", ExchangeRate = 1},
            new TripPointReview {PlaceId = providerPlaces[14].Id, ActualCostPerPerson = 30, Rating = 3, ActualTimeSpent = new TimeSpan(0,20,0), Id = Guid.NewGuid(), UserId = Guid.NewGuid().ToString() , TripPointId = null, CurrencyCode = "PLN", ExchangeRate = 1},
            new TripPointReview {PlaceId = providerPlaces[14].Id, ActualCostPerPerson = 25, Rating = 4, ActualTimeSpent = new TimeSpan(0,15,0), Id = Guid.NewGuid(), UserId = Guid.NewGuid().ToString() , TripPointId = null, CurrencyCode = "PLN", ExchangeRate = 1},
            new TripPointReview {PlaceId = providerPlaces[15].Id, ActualCostPerPerson = 14, Rating = 5, ActualTimeSpent = new TimeSpan(1,10,0), Id = Guid.NewGuid(), UserId = Guid.NewGuid().ToString() , TripPointId = null, CurrencyCode = "PLN", ExchangeRate = 1},
            new TripPointReview {PlaceId = providerPlaces[15].Id, ActualCostPerPerson = 20, Rating = 5, ActualTimeSpent = new TimeSpan(0,50,0), Id = Guid.NewGuid(), UserId = Guid.NewGuid().ToString() , TripPointId = null, CurrencyCode = "PLN", ExchangeRate = 1},
            new TripPointReview {PlaceId = providerPlaces[15].Id, ActualCostPerPerson = 14, Rating = 5, ActualTimeSpent = new TimeSpan(1,20,0), Id = Guid.NewGuid(), UserId = Guid.NewGuid().ToString() , TripPointId = null, CurrencyCode = "PLN", ExchangeRate = 1},

            new TripPointReview {PlaceId = providerPlaces[6].Id, ActualCostPerPerson = 40, Rating = 5, ActualTimeSpent = new TimeSpan(1,0,0), Id = Guid.NewGuid(), UserId = "c324c822-30c1-7029-7c4f-00799aadf54a" , TripPointId = tripPoints[16].Id, CurrencyCode = "PLN", ExchangeRate = 1},
            new TripPointReview {PlaceId = providerPlaces[7].Id, ActualCostPerPerson = 10, Rating = 4.5m, ActualTimeSpent = new TimeSpan(0,10,0), Id = Guid.NewGuid(), UserId = "c324c822-30c1-7029-7c4f-00799aadf54a" , TripPointId = tripPoints[17].Id, CurrencyCode = "PLN", ExchangeRate = 1},
        };

        modelBuilder.Entity<TripPointReview>().HasData(reviews);
    }

}