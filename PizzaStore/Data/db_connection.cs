namespace PizzaStore.Data
{
    public class db_connection
    {
        public List<Pizza> pizzas { get; set; } = new List<Pizza>()
        {
            new Pizza("Пепперони", "Пикантная пепперони, увеличенная порция моцареллы, фирменный томатный соус", 679, "https://img.freepik.com/free-photo/thinly-sliced-pepperoni-is-a-popular-pizza-topping-in-american-style-pizzerias-isolated-on-white-background-still-life_639032-229.jpg?size=626&ext=jpg"),
            new Pizza("Грибная", "Куриная грудка, шампиньоны, томаты, сыр млоцарелла, фирменный томатный соус", 549, "https://img.freepik.com/free-photo/meat-chicken-and-mushrooms-pizza-isolated-on-white-background-top-view-photo-for-the-menu_639032-224.jpg?size=626&ext=jpg"),
            new Pizza("Домашняя", "Сырокопченая колбаса, томаты, зеленый перец, маслины, фирменный сырный соус", 599, "https://img.freepik.com/free-photo/delicious-italian-pizza-with-tomato-olives-pepperoni-and-mushrooms-top-view-isolated-on-white-background-still-life-copy-space_639032-299.jpg?size=626&ext=jpg&ga=GA1.1.1819053790.1712986019&semt=ais"),
            new Pizza("Сырная", "Моцарелла, сыры чеддер и пармезан, фирменный соус альфредо", 699, "https://img.freepik.com/free-photo/pepperoni-pizza_74190-2517.jpg?t=st=1712986635~exp=1712990235~hmac=237cfe75670391c7b5a57402596dc8f5cd13b1a9e0c28c875cfbca0563cde050&w=1380"),
            new Pizza("Веганская", "Томаты, увеличенная порция моцареллы, базелик, фирменный томатный соус", 449, "https://img.freepik.com/free-photo/pizza-smoked-salmon_1203-2452.jpg?t=st=1712987833~exp=1712991433~hmac=cf1fffe84fb483d4b69ea488e873008b04067429ff98fcbb2b1be874d02b0704&w=1380"),
            new Pizza("Морская", "Кальмары, устрицы, болгарский перец, фирменный морской соус", 729, "https://img.freepik.com/free-photo/pizza_23-2147961020.jpg?t=st=1712987331~exp=1712990931~hmac=97c91faa0441ed752f0a20cd78593a7da092d5707aa990743154d3d698de7bd8&w=1380"),
        };
    }

    public class Pizza
    {
        public string title { get; set; }
        public string compound { get; set; }
        public double price { get; set; }
        public string imgURL { get; set; }

        public Pizza(string title, string compound, double price, string imgURL)
        {
            this.title = title;
            this.compound = compound;
            this.price = price;
            this.imgURL = imgURL;
        }
    }
}
