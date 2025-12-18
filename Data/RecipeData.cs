using ChristmasRecipes.Models;
using System;

namespace ChristmasMVC.Data
{
    public static class RecipeData
    {
        public static List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category { Id = 1, Name = "Cookies", Icon = "🍪" },
                new Category { Id = 2, Name = "Desserts", Icon = "🍰" },
                new Category { Id = 3, Name = "Drinks", Icon = "☕" },
                new Category { Id = 4, Name = "Main Dishes", Icon = "🍗" }
            };
        }

        public static List<Recipes> GetRecipes()
        {
            return new List<Recipes>
            {
                // COOKIES
                new Recipes
                {
                    Id = 1,
                    Name = "Classic Gingerbread Cookies",
                    Description = "Traditional Christmas cookies with warming spices and molasses. Perfect for decorating!",
                    PrepTime = 30,
                    CookTime = 15,
                    Servings = 24,
                    Difficulty = "Easy",
                    ImageUrl = "/images/gingerbread-cookies.jpg",
                    CategoryId = 1,
                    CreatedDate = DateTime.Now.AddDays(-10),
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "All-purpose flour", Amount = "3 cups" },
                        new Ingredient { Name = "Baking powder", Amount = "1½ tsp" },
                        new Ingredient { Name = "Baking soda", Amount = "¾ tsp" },
                        new Ingredient { Name = "Salt", Amount = "¼ tsp" },
                        new Ingredient { Name = "Ground ginger", Amount = "1 tbsp" },
                        new Ingredient { Name = "Ground cinnamon", Amount = "1¾ tsp" },
                        new Ingredient { Name = "Ground cloves", Amount = "¼ tsp" },
                        new Ingredient { Name = "Butter, softened", Amount = "6 tbsp" },
                        new Ingredient { Name = "Dark brown sugar", Amount = "¾ cup" },
                        new Ingredient { Name = "Large egg", Amount = "1" },
                        new Ingredient { Name = "Molasses", Amount = "½ cup" },
                        new Ingredient { Name = "Vanilla extract", Amount = "2 tsp" }
                    },
                    Instructions = new List<string>
                    {
                        "In a medium bowl, whisk together flour, baking powder, baking soda, salt, ginger, cinnamon, and cloves. Set aside.",
                        "In a large bowl, beat butter and brown sugar with an electric mixer until light and fluffy, about 3 minutes.",
                        "Add egg, molasses, and vanilla extract. Beat until well combined.",
                        "Gradually add the dry ingredients to the wet ingredients, mixing on low speed until just combined.",
                        "Divide dough in half, shape into disks, wrap in plastic wrap, and refrigerate for at least 2 hours or overnight.",
                        "Preheat oven to 350°F (175°C). Line baking sheets with parchment paper.",
                        "On a lightly floured surface, roll out dough to ¼-inch thickness. Cut into desired shapes using cookie cutters.",
                        "Place cookies on prepared baking sheets, spacing them 1 inch apart.",
                        "Bake for 8-10 minutes, until edges are set but centers are still soft.",
                        "Cool on baking sheet for 5 minutes, then transfer to a wire rack to cool completely.",
                        "Decorate with royal icing, candies, and sprinkles once completely cooled."
                    },
                    Tips = new List<string>
                    {
                        "Chill the dough thoroughly for easier rolling and cutting",
                        "Don't overbake - cookies will firm up as they cool",
                        "Use parchment paper to prevent sticking",
                        "Store in an airtight container for up to 2 weeks"
                    }
                },
                new Recipes
                {
                    Id = 2,
                    Name = "Sugar Cookie Snowflakes",
                    Description = "Delicate, buttery sugar cookies perfect for decorating with royal icing.",
                    PrepTime = 25,
                    CookTime = 10,
                    Servings = 36,
                    Difficulty = "Easy",
                    ImageUrl = "/images/sugar-cookies.jpg",
                    CategoryId = 1,
                    CreatedDate = DateTime.Now.AddDays(-8),
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "All-purpose flour", Amount = "2¾ cups" },
                        new Ingredient { Name = "Baking soda", Amount = "1 tsp" },
                        new Ingredient { Name = "Salt", Amount = "½ tsp" },
                        new Ingredient { Name = "Butter, softened", Amount = "1 cup" },
                        new Ingredient { Name = "White sugar", Amount = "1½ cups" },
                        new Ingredient { Name = "Large egg", Amount = "1" },
                        new Ingredient { Name = "Vanilla extract", Amount = "1 tsp" },
                        new Ingredient { Name = "Royal icing", Amount = "for decoration" }
                    },
                    Instructions = new List<string>
                    {
                        "Preheat oven to 375°F (190°C).",
                        "In a bowl, combine flour, baking soda, and salt. Set aside.",
                        "In a large bowl, cream together butter and sugar until light and fluffy.",
                        "Beat in egg and vanilla extract until well combined.",
                        "Gradually blend in the dry ingredients until mixture forms a dough.",
                        "Roll out dough on a floured surface to about ¼ inch thickness.",
                        "Cut into snowflake shapes using cookie cutters.",
                        "Place on ungreased cookie sheets, spacing 2 inches apart.",
                        "Bake 8 to 10 minutes or until edges are lightly golden.",
                        "Cool on baking sheet for 2 minutes, then transfer to wire rack.",
                        "Decorate with white and blue royal icing to create beautiful snowflake patterns."
                    },
                    Tips = new List<string>
                    {
                        "Keep dough chilled while working for cleaner cuts",
                        "Use gel food coloring for vibrant icing colors",
                        "Let icing dry completely before stacking cookies"
                    }
                },
                new Recipes
                {
                    Id = 3,
                    Name = "Chocolate Crinkle Cookies",
                    Description = "Fudgy chocolate cookies with a beautiful crackled powdered sugar coating.",
                    PrepTime = 20,
                    CookTime = 12,
                    Servings = 24,
                    Difficulty = "Easy",
                    ImageUrl = "/images/chocolate-crinkle.jpg",
                    CategoryId = 1,
                    CreatedDate = DateTime.Now.AddDays(-5),
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Unsweetened cocoa powder", Amount = "1 cup" },
                        new Ingredient { Name = "White sugar", Amount = "2 cups" },
                        new Ingredient { Name = "Vegetable oil", Amount = "½ cup" },
                        new Ingredient { Name = "Large eggs", Amount = "4" },
                        new Ingredient { Name = "Vanilla extract", Amount = "2 tsp" },
                        new Ingredient { Name = "All-purpose flour", Amount = "2 cups" },
                        new Ingredient { Name = "Baking powder", Amount = "2 tsp" },
                        new Ingredient { Name = "Salt", Amount = "½ tsp" },
                        new Ingredient { Name = "Powdered sugar", Amount = "½ cup" }
                    },
                    Instructions = new List<string>
                    {
                        "In a large bowl, mix together cocoa powder, white sugar, and vegetable oil.",
                        "Beat in eggs one at a time, then stir in vanilla extract.",
                        "In a separate bowl, combine flour, baking powder, and salt.",
                        "Gradually stir dry ingredients into the cocoa mixture until well blended.",
                        "Cover dough and refrigerate for at least 4 hours or overnight.",
                        "Preheat oven to 350°F (175°C). Line baking sheets with parchment paper.",
                        "Place powdered sugar in a shallow bowl.",
                        "Roll chilled dough into 1-inch balls, then roll generously in powdered sugar to coat.",
                        "Place cookies 2 inches apart on prepared baking sheets.",
                        "Bake for 10-12 minutes. Cookies will spread and crack.",
                        "Let cool on baking sheet for 5 minutes before transferring to wire rack.",
                        "The cookies should be soft with beautiful white cracks throughout."
                    },
                    Tips = new List<string>
                    {
                        "Don't skip the chilling step - it's crucial for texture",
                        "Roll in powdered sugar twice for better coverage",
                        "Don't overbake - they should be soft in the center"
                    }
                },
                new Recipes
                {
                    Id = 4,
                    Name = "Scottish Shortbread",
                    Description = "Buttery, crumbly traditional shortbread - simple but heavenly.",
                    PrepTime = 15,
                    CookTime = 25,
                    Servings = 16,
                    Difficulty = "Easy",
                    ImageUrl = "/images/shortbread.jpg",
                    CategoryId = 1,
                    CreatedDate = DateTime.Now.AddDays(-4),
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Butter, softened", Amount = "1 cup" },
                        new Ingredient { Name = "Powdered sugar", Amount = "½ cup" },
                        new Ingredient { Name = "All-purpose flour", Amount = "2 cups" },
                        new Ingredient { Name = "Cornstarch", Amount = "¼ cup" },
                        new Ingredient { Name = "Salt", Amount = "¼ tsp" },
                        new Ingredient { Name = "Vanilla extract", Amount = "1 tsp" }
                    },
                    Instructions = new List<string>
                    {
                        "Preheat oven to 325°F (165°C).",
                        "In a large bowl, cream butter and powdered sugar until light and fluffy.",
                        "Add vanilla extract and mix well.",
                        "In a separate bowl, whisk together flour, cornstarch, and salt.",
                        "Gradually add dry ingredients to butter mixture, mixing until just combined.",
                        "Press dough evenly into an ungreased 9x9 inch square pan.",
                        "Use a fork to prick dough all over in a decorative pattern.",
                        "Use a knife to score dough into 16 squares (don't cut all the way through).",
                        "Bake for 25-30 minutes until edges are lightly golden.",
                        "Remove from oven and immediately cut along scored lines while still hot.",
                        "Let cool completely in pan before removing pieces.",
                        "Dust with additional powdered sugar if desired."
                    },
                    Tips = new List<string>
                    {
                        "Use high-quality butter for best flavor",
                        "Don't overbake - shortbread should be pale",
                        "Store in airtight container for up to 2 weeks"
                    }
                },
                
                // DESSERTS
                new Recipes
                {
                    Id = 5,
                    Name = "Peppermint Bark",
                    Description = "Layers of dark and white chocolate topped with crushed candy canes.",
                    PrepTime = 15,
                    CookTime = 5,
                    Servings = 16,
                    Difficulty = "Easy",
                    ImageUrl = "/images/peppermint-bark.jpg",
                    CategoryId = 2,
                    CreatedDate = DateTime.Now.AddDays(-6),
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Dark chocolate chips", Amount = "12 oz" },
                        new Ingredient { Name = "White chocolate chips", Amount = "12 oz" },
                        new Ingredient { Name = "Peppermint extract", Amount = "½ tsp" },
                        new Ingredient { Name = "Crushed candy canes", Amount = "½ cup" }
                    },
                    Instructions = new List<string>
                    {
                        "Line a 9x13 inch baking sheet with parchment paper, letting it hang over the edges.",
                        "Melt dark chocolate in microwave in 30-second intervals, stirring between each, until smooth.",
                        "Pour melted dark chocolate onto prepared pan and spread evenly with a spatula.",
                        "Refrigerate for 15-20 minutes until completely set.",
                        "Melt white chocolate using the same method as dark chocolate.",
                        "Stir peppermint extract into melted white chocolate.",
                        "Pour white chocolate over the set dark chocolate layer and spread evenly.",
                        "Immediately sprinkle crushed candy canes over the top while white chocolate is still wet.",
                        "Refrigerate for 30 minutes until completely set.",
                        "Remove from pan using parchment overhang and break into pieces."
                    },
                    Tips = new List<string>
                    {
                        "Use high-quality chocolate for best results",
                        "Don't overheat chocolate or it will seize",
                        "Store in refrigerator in airtight container for up to 2 weeks"
                    }
                },
                new Recipes
                {
                    Id = 6,
                    Name = "Traditional Christmas Pudding",
                    Description = "Rich, moist fruit pudding steeped in brandy - a British holiday classic.",
                    PrepTime = 45,
                    CookTime = 240,
                    Servings = 10,
                    Difficulty = "Hard",
                    ImageUrl = "/images/christmas-pudding.jpg",
                    CategoryId = 2,
                    CreatedDate = DateTime.Now.AddDays(-15),
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Raisins", Amount = "1 cup" },
                        new Ingredient { Name = "Currants", Amount = "1 cup" },
                        new Ingredient { Name = "Chopped dates", Amount = "½ cup" },
                        new Ingredient { Name = "Candied peel", Amount = "½ cup" },
                        new Ingredient { Name = "Fresh breadcrumbs", Amount = "1 cup" },
                        new Ingredient { Name = "Brown sugar", Amount = "1 cup" },
                        new Ingredient { Name = "Shredded suet", Amount = "1 cup" },
                        new Ingredient { Name = "Large eggs", Amount = "3" },
                        new Ingredient { Name = "Brandy", Amount = "½ cup" },
                        new Ingredient { Name = "Mixed spice", Amount = "1 tsp" },
                        new Ingredient { Name = "Ground cinnamon", Amount = "1 tsp" },
                        new Ingredient { Name = "Grated nutmeg", Amount = "½ tsp" }
                    },
                    Instructions = new List<string>
                    {
                        "Place all dried fruits and candied peel in a large bowl. Pour brandy over and mix well. Cover and let soak overnight.",
                        "The next day, add breadcrumbs, brown sugar, suet, and spices to the fruit mixture. Mix thoroughly.",
                        "Beat eggs in a separate bowl, then add to the mixture and stir until everything is well combined.",
                        "Grease a 1.5-liter pudding basin with butter.",
                        "Spoon the mixture into the prepared basin, pressing down firmly to eliminate air pockets.",
                        "Cover with a double layer of pleated parchment paper, then a layer of pleated foil. Secure tightly with string.",
                        "Place pudding in a large pot with enough boiling water to come halfway up the sides of the basin.",
                        "Cover pot and steam for 4 hours, checking water level periodically and topping up with boiling water as needed.",
                        "Remove from pot and let cool completely.",
                        "Store in a cool, dark place for up to 3 months, or serve immediately.",
                        "To serve, steam for 1 hour to reheat, then turn out onto a serving plate.",
                        "Optionally, warm additional brandy, pour over pudding, and carefully ignite for a dramatic presentation.",
                        "Serve with brandy butter, custard, or whipped cream."
                    },
                    Tips = new List<string>
                    {
                        "Make pudding weeks in advance - flavor improves with age",
                        "Feed with brandy weekly for richer taste",
                        "Save a coin to hide inside for good luck (warn guests!)",
                        "Never let the pot boil dry while steaming"
                    }
                },
                new Recipes
                {
                    Id = 7,
                    Name = "Eggnog Cheesecake",
                    Description = "Creamy cheesecake infused with festive eggnog and warm spices.",
                    PrepTime = 30,
                    CookTime = 70,
                    Servings = 12,
                    Difficulty = "Medium",
                    ImageUrl = "/images/eggnog-cheesecake.jpg",
                    CategoryId = 2,
                    CreatedDate = DateTime.Now.AddDays(-7),
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Graham cracker crumbs", Amount = "2 cups" },
                        new Ingredient { Name = "Melted butter", Amount = "⅓ cup" },
                        new Ingredient { Name = "Cream cheese, softened", Amount = "32 oz (4 packages)" },
                        new Ingredient { Name = "Sugar", Amount = "1 cup" },
                        new Ingredient { Name = "Eggnog", Amount = "1 cup" },
                        new Ingredient { Name = "Large eggs", Amount = "4" },
                        new Ingredient { Name = "Vanilla extract", Amount = "1 tsp" },
                        new Ingredient { Name = "Ground nutmeg", Amount = "1 tsp" },
                        new Ingredient { Name = "Ground cinnamon", Amount = "¼ tsp" },
                        new Ingredient { Name = "Whipped cream", Amount = "for topping" }
                    },
                    Instructions = new List<string>
                    {
                        "Preheat oven to 325°F (165°C).",
                        "Mix graham cracker crumbs with melted butter until evenly moistened.",
                        "Press mixture firmly into the bottom of a 9-inch springform pan.",
                        "Bake crust for 10 minutes, then remove and let cool.",
                        "In a large bowl, beat cream cheese and sugar with electric mixer until smooth and fluffy, about 3 minutes.",
                        "Add eggnog, vanilla extract, nutmeg, and cinnamon. Beat until well combined.",
                        "Add eggs one at a time, beating on low speed just until incorporated after each addition.",
                        "Pour batter over prepared crust.",
                        "Place springform pan on a baking sheet to catch any drips.",
                        "Bake for 60-70 minutes until edges are set but center still jiggles slightly.",
                        "Turn off oven and crack door open. Let cheesecake cool in oven for 1 hour.",
                        "Remove from oven and run a knife around the edge to loosen.",
                        "Refrigerate for at least 4 hours or overnight.",
                        "Before serving, remove sides of springform pan.",
                        "Top with whipped cream and a sprinkle of cinnamon or nutmeg."
                    },
                    Tips = new List<string>
                    {
                        "All ingredients should be at room temperature",
                        "Don't overmix once eggs are added to prevent cracks",
                        "Use a water bath for extra creamy texture",
                        "Cheesecake tastes best the next day after flavors meld"
                    }
                },
                new Recipes
                {
                    Id = 8,
                    Name = "Traditional Fruitcake",
                    Description = "Dense, moist cake packed with dried fruits and nuts, soaked in rum.",
                    PrepTime = 60,
                    CookTime = 180,
                    Servings = 16,
                    Difficulty = "Hard",
                    ImageUrl = "/images/fruitcake.jpg",
                    CategoryId = 2,
                    CreatedDate = DateTime.Now.AddDays(-20),
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Mixed dried fruits", Amount = "4 cups" },
                        new Ingredient { Name = "Chopped walnuts", Amount = "1 cup" },
                        new Ingredient { Name = "Dark rum", Amount = "1 cup" },
                        new Ingredient { Name = "Butter, softened", Amount = "1 cup" },
                        new Ingredient { Name = "Brown sugar", Amount = "1 cup" },
                        new Ingredient { Name = "Large eggs", Amount = "4" },
                        new Ingredient { Name = "All-purpose flour", Amount = "2 cups" },
                        new Ingredient { Name = "Baking powder", Amount = "1 tsp" },
                        new Ingredient { Name = "Mixed spice", Amount = "2 tsp" },
                        new Ingredient { Name = "Molasses", Amount = "2 tbsp" }
                    },
                    Instructions = new List<string>
                    {
                        "Place dried fruits and nuts in a large bowl. Pour ½ cup rum over them. Cover and soak overnight.",
                        "Preheat oven to 275°F (135°C). Grease and line a 9-inch round cake pan with parchment.",
                        "Cream butter and sugar until light and fluffy.",
                        "Beat in eggs one at a time, then add molasses.",
                        "Sift together flour, baking powder, and spices.",
                        "Fold dry ingredients into butter mixture.",
                        "Fold in soaked fruits and nuts along with any remaining liquid.",
                        "Pour batter into prepared pan and smooth the top.",
                        "Bake for 3 hours, or until a skewer inserted comes out clean.",
                        "While cake is still hot, poke holes all over with a skewer and brush with remaining rum.",
                        "Let cool in pan, then wrap tightly in cheesecloth soaked in rum.",
                        "Store in airtight container, brushing with rum weekly for 4-6 weeks before serving."
                    },
                    Tips = new List<string>
                    {
                        "Make 4-6 weeks before Christmas for best flavor",
                        "Feed with rum weekly during storage",
                        "Wrap well to prevent drying out",
                        "Can be frozen for up to 6 months"
                    }
                },
                
                // DRINKS
                new Recipes
                {
                    Id = 9,
                    Name = "Classic Hot Chocolate",
                    Description = "Rich, creamy homemade hot chocolate topped with marshmallows.",
                    PrepTime = 5,
                    CookTime = 10,
                    Servings = 4,
                    Difficulty = "Easy",
                    ImageUrl = "/images/hot-chocolate.jpg",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now.AddDays(-3),
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Whole milk", Amount = "4 cups" },
                        new Ingredient { Name = "White chocolate chips", Amount = "1 cup" },
                        new Ingredient { Name = "Peppermint extract", Amount = "1 tsp" },
                        new Ingredient { Name = "Vanilla extract", Amount = "½ tsp" },
                        new Ingredient { Name = "Sugar", Amount = "2 tbsp" },
                        new Ingredient { Name = "Whipped cream", Amount = "for topping" },
                        new Ingredient { Name = "Crushed candy canes", Amount = "for garnish" },
                        new Ingredient { Name = "Mini candy canes", Amount = "4" }
                    },
                    Instructions = new List<string>
                    {
                        "Heat milk in a saucepan over medium heat until steaming.",
                        "Reduce heat to low and add white chocolate chips.",
                        "Stir constantly until chocolate is completely melted and smooth.",
                        "Add sugar, peppermint extract, and vanilla extract. Stir well.",
                        "Taste and adjust peppermint to your preference.",
                        "Pour into mugs and top generously with whipped cream.",
                        "Sprinkle crushed candy canes over whipped cream.",
                        "Garnish with a mini candy cane as a stirrer.",
                        "Serve immediately while hot."
                    },
                    Tips = new List<string>
                    {
                        "Start with less peppermint - you can always add more",
                        "Use crushed candy canes for rim decoration",
                        "Make whipped cream with peppermint extract for extra flavor",
                        "Perfect for kids (just skip the peppermint extract)"
                    }
                },
                new Recipes
                {
                    Id = 10,
                    Name = "Spiced Mulled Wine",
                    Description = "Warm, aromatic red wine infused with festive spices and citrus.",
                    PrepTime = 5,
                    CookTime = 20,
                    Servings = 8,
                    Difficulty = "Easy",
                    ImageUrl = "/images/mulled-wine.jpg",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now.AddDays(-4),
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Red wine (full-bodied)", Amount = "2 bottles (750ml each)" },
                        new Ingredient { Name = "Brandy", Amount = "½ cup" },
                        new Ingredient { Name = "Orange, sliced", Amount = "2" },
                        new Ingredient { Name = "Lemon, sliced", Amount = "1" },
                        new Ingredient { Name = "Honey", Amount = "¼ cup" },
                        new Ingredient { Name = "Cinnamon sticks", Amount = "4" },
                        new Ingredient { Name = "Whole cloves", Amount = "8" },
                        new Ingredient { Name = "Star anise", Amount = "3" },
                        new Ingredient { Name = "Fresh ginger, sliced", Amount = "1 inch piece" },
                        new Ingredient { Name = "Cardamom pods", Amount = "6" }
                    },
                    Instructions = new List<string>
                    {
                        "Pour wine into a large pot or slow cooker.",
                        "Add brandy, honey, and stir until honey dissolves.",
                        "Add orange slices, lemon slices, and all spices.",
                        "Heat over medium-low heat until wine is steaming (don't let it boil).",
                        "Reduce heat to low and simmer gently for 15-20 minutes.",
                        "Taste and adjust sweetness with more honey if needed.",
                        "Strain out spices and fruit, or leave in for presentation.",
                        "Serve warm in heat-resistant mugs or glasses.",
                        "Garnish with fresh orange slices and cinnamon sticks."
                    },
                    Tips = new List<string>
                    {
                        "Use a good quality wine - you'll taste the difference",
                        "Never let it boil or alcohol will evaporate",
                        "Can be kept warm in slow cooker for parties",
                        "Make ahead and reheat gently before serving"
                    }
                },
                new Recipes
                {
                    Id = 11,
                    Name = "Homemade Eggnog",
                    Description = "Creamy, rich traditional eggnog with warm spices and optional rum.",
                    PrepTime = 15,
                    CookTime = 10,
                    Servings = 8,
                    Difficulty = "Medium",
                    ImageUrl = "/images/eggnog.jpg",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now.AddDays(-6),
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Large eggs", Amount = "6" },
                        new Ingredient { Name = "Sugar", Amount = "¾ cup" },
                        new Ingredient { Name = "Whole milk", Amount = "2 cups" },
                        new Ingredient { Name = "Heavy cream", Amount = "1 cup" },
                        new Ingredient { Name = "Vanilla extract", Amount = "2 tsp" },
                        new Ingredient { Name = "Ground nutmeg", Amount = "1 tsp" },
                        new Ingredient { Name = "Ground cinnamon", Amount = "½ tsp" },
                        new Ingredient { Name = "Dark rum (optional)", Amount = "½ cup" },
                        new Ingredient { Name = "Whipped cream", Amount = "for topping" }
                    },
                    Instructions = new List<string>
                    {
                        "Separate egg yolks from whites. Place yolks in a large bowl.",
                        "Whisk egg yolks with sugar until light and creamy.",
                        "In a saucepan, heat milk, cream, nutmeg, and cinnamon over medium heat until steaming.",
                        "Slowly pour hot milk mixture into egg yolks, whisking constantly to temper.",
                        "Return mixture to saucepan and cook over low heat, stirring constantly, until it thickens slightly (170°F).",
                        "Remove from heat and stir in vanilla extract.",
                        "If using rum, stir it in now.",
                        "Strain through fine mesh sieve into a pitcher.",
                        "Cover and refrigerate for at least 4 hours or overnight.",
                        "Before serving, in a clean bowl, beat egg whites until soft peaks form.",
                        "Gently fold whipped egg whites into chilled eggnog.",
                        "Serve in cups topped with whipped cream and a sprinkle of nutmeg."
                    },
                    Tips = new List<string>
                    {
                        "Use fresh eggs from a trusted source",
                        "Don't let mixture boil or eggs will scramble",
                        "Age eggnog in fridge for 1-2 days for better flavor",
                        "Can be made non-alcoholic by omitting rum"
                    }
                },
                new Recipes
                {
                    Id = 12,
                    Name = "Peppermint Hot Cocoa",
                    Description = "Festive hot chocolate with refreshing peppermint and candy cane.",
                    PrepTime = 5,
                    CookTime = 10,
                    Servings = 4,
                    Difficulty = "Easy",
                    ImageUrl = "/images/peppermint-cocoa.jpg",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now.AddDays(-2),
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Whole milk", Amount = "4 cups" },
                        new Ingredient { Name = "Dark chocolate, chopped", Amount = "8 oz" },
                        new Ingredient { Name = "Cocoa powder", Amount = "¼ cup" },
                        new Ingredient { Name = "Sugar", Amount = "¼ cup" },
                        new Ingredient { Name = "Peppermint extract", Amount = "½ tsp" },
                        new Ingredient { Name = "Vanilla extract", Amount = "1 tsp" },
                        new Ingredient { Name = "Salt", Amount = "Pinch" },
                        new Ingredient { Name = "Whipped cream", Amount = "for topping" },
                        new Ingredient { Name = "Mini marshmallows", Amount = "for topping" },
                        new Ingredient { Name = "Crushed candy canes", Amount = "for garnish" }
                    },
                    Instructions = new List<string>
                    {
                        "Heat milk in a saucepan over medium heat until steaming, but not boiling.",
                        "Whisk in cocoa powder, sugar, and salt until fully dissolved.",
                        "Add chopped chocolate and stir constantly until melted and smooth.",
                        "Remove from heat and stir in vanilla and peppermint extract.",
                        "Pour into mugs.",
                        "Top with whipped cream or marshmallows.",
                        "Garnish with crushed candy canes.",
                        "Serve immediately while hot."
                    },
                    Tips = new List<string>
                    {
                        "Start with less peppermint extract and adjust to taste",
                        "Use high-quality chocolate for richer flavor",
                        "Great with a candy cane stirrer",
                        "Can be made dairy-free with plant milk"
                    }
                },
                
                // MAIN DISHES
                new Recipes
                {
                    Id = 13,
                    Name = "Roasted Christmas Turkey",
                    Description = "Perfectly golden, juicy roasted turkey with herb butter.",
                    PrepTime = 30,
                    CookTime = 240,
                    Servings = 12,
                    Difficulty = "Hard",
                    ImageUrl = "/images/roasted-turkey.jpg",
                    CategoryId = 4,
                    CreatedDate = DateTime.Now.AddDays(-12),
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Whole turkey", Amount = "12-14 lbs" },
                        new Ingredient { Name = "Butter, softened", Amount = "½ cup" },
                        new Ingredient { Name = "Fresh rosemary, chopped", Amount = "2 tbsp" },
                        new Ingredient { Name = "Fresh thyme, chopped", Amount = "2 tbsp" },
                        new Ingredient { Name = "Fresh sage, chopped", Amount = "1 tbsp" },
                        new Ingredient { Name = "Garlic, minced", Amount = "4 cloves" },
                        new Ingredient { Name = "Lemon", Amount = "2" },
                        new Ingredient { Name = "Onion, quartered", Amount = "1 large" },
                        new Ingredient { Name = "Chicken broth", Amount = "2 cups" },
                        new Ingredient { Name = "Salt", Amount = "2 tbsp" },
                        new Ingredient { Name = "Black pepper", Amount = "1 tbsp" },
                        new Ingredient { Name = "Olive oil", Amount = "¼ cup" }
                    },
                    Instructions = new List<string>
                    {
                        "Remove turkey from fridge 1 hour before cooking. Pat completely dry with paper towels.",
                        "Preheat oven to 325°F (165°C).",
                        "Mix softened butter with herbs, garlic, salt, and pepper to make herb butter.",
                        "Carefully separate turkey skin from breast meat and rub herb butter underneath.",
                        "Rub remaining herb butter all over outside of turkey.",
                        "Stuff cavity with lemon halves and quartered onion.",
                        "Tie legs together with kitchen twine and tuck wing tips under.",
                        "Place turkey breast-side up on roasting rack in large roasting pan.",
                        "Pour chicken broth into bottom of pan.",
                        "Tent loosely with foil and roast for 2 hours.",
                        "Remove foil, baste with pan juices, and continue roasting for 1½-2 hours more.",
                        "Turkey is done when internal temperature reaches 165°F in thickest part of thigh.",
                        "Let rest 30 minutes before carving. Use pan drippings for gravy."
                    },
                    Tips = new List<string>
                    {
                        "Use meat thermometer for perfect doneness",
                        "Basting every 30 minutes keeps it moist",
                        "Let turkey rest - juices redistribute",
                        "Save bones and scraps for turkey stock"
                    }
                },
                new Recipes
                {
                    Id = 14,
                    Name = "Honey Glazed Ham",
                    Description = "Sweet and savory glazed ham with cloves and brown sugar.",
                    PrepTime = 15,
                    CookTime = 150,
                    Servings = 10,
                    Difficulty = "Medium",
                    ImageUrl = "/images/honey-ham.jpg",
                    CategoryId = 4,
                    CreatedDate = DateTime.Now.AddDays(-9),
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Fully cooked bone-in ham", Amount = "8-10 lbs" },
                        new Ingredient { Name = "Honey", Amount = "1 cup" },
                        new Ingredient { Name = "Brown sugar", Amount = "1 cup" },
                        new Ingredient { Name = "Dijon mustard", Amount = "¼ cup" },
                        new Ingredient { Name = "Apple cider vinegar", Amount = "¼ cup" },
                        new Ingredient { Name = "Whole cloves", Amount = "20-25" },
                        new Ingredient { Name = "Orange juice", Amount = "½ cup" },
                        new Ingredient { Name = "Ground cinnamon", Amount = "1 tsp" }
                    },
                    Instructions = new List<string>
                    {
                        "Preheat oven to 325°F (165°C).",
                        "Score ham in a diamond pattern, cutting about ¼ inch deep.",
                        "Insert whole cloves at intersection points of diamond pattern.",
                        "Place ham in large roasting pan and add 1 cup water to bottom.",
                        "Cover tightly with foil and bake for 1½ hours.",
                        "Meanwhile, make glaze: combine honey, brown sugar, mustard, vinegar, orange juice, and cinnamon in saucepan.",
                        "Simmer glaze over medium heat for 5 minutes, stirring until sugar dissolves.",
                        "Remove ham from oven, uncover, and brush generously with glaze.",
                        "Return to oven uncovered and bake 45-60 minutes more, basting every 15 minutes.",
                        "Ham should be caramelized and golden brown.",
                        "Let rest 15 minutes before slicing.",
                        "Serve with remaining glaze on the side."
                    },
                    Tips = new List<string>
                    {
                        "Buy spiral-cut ham for easier serving",
                        "Don't overbake - ham is already cooked",
                        "Reserve glaze for serving on the side",
                        "Leftovers great for sandwiches and soup"
                    }
                },
                new Recipes
                {
                    Id = 15,
                    Name = "Prime Rib Roast",
                    Description = "Tender, perfectly seasoned standing rib roast with garlic and herbs.",
                    PrepTime = 20,
                    CookTime = 180,
                    Servings = 8,
                    Difficulty = "Hard",
                    ImageUrl = "/images/prime-rib.jpg",
                    CategoryId = 4,
                    CreatedDate = DateTime.Now.AddDays(-11),
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Prime rib roast (bone-in)", Amount = "6-7 lbs" },
                        new Ingredient { Name = "Garlic cloves, minced", Amount = "6" },
                        new Ingredient { Name = "Fresh rosemary, chopped", Amount = "3 tbsp" },
                        new Ingredient { Name = "Fresh thyme, chopped", Amount = "2 tbsp" },
                        new Ingredient { Name = "Olive oil", Amount = "¼ cup" },
                        new Ingredient { Name = "Kosher salt", Amount = "3 tbsp" },
                        new Ingredient { Name = "Black pepper, coarsely ground", Amount = "2 tbsp" },
                        new Ingredient { Name = "Dijon mustard", Amount = "2 tbsp" },
                        new Ingredient { Name = "Beef broth", Amount = "2 cups" }
                    },
                    Instructions = new List<string>
                    {
                        "Remove roast from refrigerator 2 hours before cooking to bring to room temperature.",
                        "Preheat oven to 450°F (230°C).",
                        "Pat roast completely dry with paper towels.",
                        "Mix garlic, rosemary, thyme, olive oil, salt, pepper, and mustard into a paste.",
                        "Rub paste all over roast, covering completely.",
                        "Place roast bone-side down in roasting pan.",
                        "Roast at 450°F for 20 minutes to create a crust.",
                        "Reduce oven temperature to 325°F (165°C).",
                        "Continue roasting for 2-2½ hours for medium-rare (internal temp 135°F).",
                        "Use meat thermometer to check temperature in thickest part.",
                        "Remove from oven and tent loosely with foil.",
                        "Let rest 20-30 minutes before carving (temperature will rise 5-10°F).",
                        "Slice between bones and serve with au jus made from pan drippings."
                    },
                    Tips = new List<string>
                    {
                        "Room temperature meat cooks more evenly",
                        "Invest in good meat thermometer",
                        "Resting is crucial - don't skip it",
                        "Save bones for beef stock"
                    }
                },
                new Recipes
                {
                    Id = 16,
                    Name = "Beef Wellington",
                    Description = "Elegant beef tenderloin wrapped in mushroom duxelles and puff pastry.",
                    PrepTime = 60,
                    CookTime = 40,
                    Servings = 6,
                    Difficulty = "Hard",
                    ImageUrl = "/images/beef-wellington.jpg",
                    CategoryId = 4,
                    CreatedDate = DateTime.Now.AddDays(-14),
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Beef tenderloin (center cut)", Amount = "2 lbs" },
                        new Ingredient { Name = "Mushrooms, finely chopped", Amount = "1 lb" },
                        new Ingredient { Name = "Shallots, minced", Amount = "2" },
                        new Ingredient { Name = "Garlic, minced", Amount = "3 cloves" },
                        new Ingredient { Name = "Fresh thyme", Amount = "2 tsp" },
                        new Ingredient { Name = "Puff pastry sheets", Amount = "1 lb" },
                        new Ingredient { Name = "Prosciutto slices", Amount = "8-10" },
                        new Ingredient { Name = "Dijon mustard", Amount = "3 tbsp" },
                        new Ingredient { Name = "Egg, beaten", Amount = "1" },
                        new Ingredient { Name = "Butter", Amount = "2 tbsp" },
                        new Ingredient { Name = "Olive oil", Amount = "2 tbsp" },
                        new Ingredient { Name = "Salt and pepper", Amount = "to taste" }
                    },
                    Instructions = new List<string>
                    {
                        "Season beef generously with salt and pepper.",
                        "Heat oil in pan over high heat. Sear beef on all sides until browned (2 minutes per side).",
                        "Brush beef with mustard and let cool completely.",
                        "Make duxelles: Sauté shallots and garlic in butter. Add mushrooms and thyme.",
                        "Cook mushroom mixture until all liquid evaporates (15-20 minutes). Cool completely.",
                        "Lay plastic wrap on work surface. Arrange prosciutto slices overlapping.",
                        "Spread mushroom mixture over prosciutto.",
                        "Place beef in center and roll tightly using plastic wrap. Refrigerate 30 minutes.",
                        "Roll out puff pastry into rectangle large enough to wrap beef.",
                        "Unwrap beef from plastic and place on pastry. Wrap pastry around beef, sealing edges.",
                        "Place seam-side down on baking sheet. Brush with beaten egg.",
                        "Score pastry in decorative pattern and refrigerate 30 minutes.",
                        "Preheat oven to 425°F (220°C).",
                        "Bake 25-30 minutes until pastry is golden and internal temp reaches 125°F for medium-rare.",
                        "Let rest 10 minutes before slicing into thick portions."
                    },
                    Tips = new List<string>
                    {
                        "Make duxelles day before to save time",
                        "Don't skip chilling steps - prevents soggy pastry",
                        "Use meat thermometer for perfect doneness",
                        "Serve immediately while pastry is crisp"
                    }
                }
            };
        }
    }
}