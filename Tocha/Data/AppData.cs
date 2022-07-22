namespace Tocha.Data;

public static class AppData
{
    public static Components.Burger Burger { get; set; }
    public static Components.Menu Menu { get; set; }
    public static bool Autorized { get; set; }
    public static bool BurgerActive { get; set; }
    public static bool LoginActive { get; set; }
    public static bool RegistrationActive { get; set; }

    public static List<TariffModel> Tariffs = new List<TariffModel>()
    {
        new TariffModel{ Name = "Бесплатно", Description = "Пробный период на 1 месяц", Amount = 0, Period = "первый месяц"},
        new TariffModel { Name = "Базовый", Description = "Менее 1000 посещений в сутки", Amount = 200, Period = "месяц"},
        new TariffModel { Name = "Премиум", Description = "Более 1000 посещений в сутки", Amount = 500, Period = "месяц"}
    };

    public static List<MenuLink> MenuLinks = new List<MenuLink>()
    {
        new MenuLink { Title = "Подключение", Url = "steps"},
        new MenuLink { Title = "Оплата", Url = "tariffs"},
        new MenuLink { Title = "Контакты", Url = "footer"}
    };

    public static List<FeatureModel> Features = new List<FeatureModel>()
    {
        new FeatureModel { Icon = "images/telegram_feature.svg", Title = "Ничего лишнего", Text = "Отсутствие лишних приложений для операторов. Оператору не нужно учиться работать с чатом"},
        new FeatureModel { Icon = "images/simple_feature.svg", Title = "Простота", Text = "Простая установка на сайт"},
        new FeatureModel { Icon = "images/assist_feature.svg", Title = "Несколько ассистентов", Text = "Возможность подключения нескольких ассистентов"},
        new FeatureModel { Icon = "images/custom_feature.svg", Title = "Кастомизация", Text = "Настройка интерфейса под нужды сайта"}
    };

    public static List<MessageModel> Messages = new List<MessageModel>()
    {
        new MessageModel { Text = "Здравствуйте! а расскажите о работе Tocha Online.", Time = "11:02"},
        new MessageModel { Text = "Добрый день. Tocha Online — удобный инструмент для общения с клиентами всего через одно приложение. Чат легко подключить на сайт, а оператору не нужно учиться работать с чатом.", Time = "11:03"},
        new MessageModel { Text = "А я могу подключить несколько ассистентов?", Time = "11:05"},
        new MessageModel { Text = "Конечно! Вы можете подключить неограниченное количество ассистентов.", Time = "11:05"},
        new MessageModel { Text = "Могу ли я кастомизировать чат под свои нужды?", Time = "11:06"},
        new MessageModel { Text = "Да, вы можете настроить иконки, цвет, шрифт", Time = "11:06"},
        new MessageModel { Text = "Как установить чат на сайт? ", Time = "11:09"},
        new MessageModel { Text = "Вам необходимо создать Telegram-бота, а мы подключим его на ваш сайт. Кстати, для вас подарок — бесплатный пробный период на 1 месяц! За это время вы сможете оценить простоту и удобство сервиса", Time = "11:10"},
        new MessageModel { Text = "Спасибо! Сейчас создам Telegram-бота", Time = "11:11"}
    };

    public static List<StepModel> Steps = new()
    {
        new StepModel { Title = "Telegram bot", Description = "Вы создаёте Telegram бота для вашего сайта", Number = 1, Image = "images/step1.png"},
        new StepModel { Title = "Подключение Tocha", Description = "Tocha подключает Telegram бота к вашиму сайту", Number = 2, Image = "images/step2.png"},
        new StepModel { Title = "Telegram-чат", Description = "Консультант отвечает на вопросы посетителей сайта", Number = 3, Image = "images/step3.png"}
    };

    public static List<TestimonialModel> Testimonials = new()
    {
        new TestimonialModel { Title = "Как же удобно!", Text = "В рамках спецификации современных стандартов, базовые сценарии поведения пользователей, которые представляют собой яркий пример континентально-европейского типа политической культуры, будут преданы социально-демократической анафеме.", Image = "images/ava1.png", Author = "Анна Купер", Workplace = "romashka.ru"},
        new TestimonialModel { Title = "Теперь мы идем в ногу со временем", Text = "А ещё интерактивные прототипы превращены в посмешище, хотя само их существование приносит несомненную пользу обществу. Банальные, но неопровержимые выводы, а также тщательные исследования конкурентов формируют сеть.", Image = "images/ava2.png", Author = "Андрей Васильев", Workplace = "samogon-ont.ru"},
        new TestimonialModel { Title = "Как же удобно!", Text = "В рамках спецификации современных стандартов, базовые сценарии поведения пользователей, которые представляют собой яркий пример континентально-европейского типа политической культуры, будут преданы социально-демократической анафеме.", Image = "images/ava1.png", Author = "Анна Купер", Workplace = "romashka.ru"},
        new TestimonialModel { Title = "Теперь мы идем в ногу со временем", Text = "А ещё интерактивные прототипы превращены в посмешище, хотя само их существование приносит несомненную пользу обществу. Банальные, но неопровержимые выводы, а также тщательные исследования конкурентов формируют сеть.", Image = "images/ava2.png", Author = "Андрей Васильев", Workplace = "samogon-ont.ru"},
        new TestimonialModel { Title = "Как же удобно!", Text = "В рамках спецификации современных стандартов, базовые сценарии поведения пользователей, которые представляют собой яркий пример континентально-европейского типа политической культуры, будут преданы социально-демократической анафеме.", Image = "images/ava1.png", Author = "Анна Купер", Workplace = "romashka.ru"},
        new TestimonialModel { Title = "Теперь мы идем в ногу со временем", Text = "А ещё интерактивные прототипы превращены в посмешище, хотя само их существование приносит несомненную пользу обществу. Банальные, но неопровержимые выводы, а также тщательные исследования конкурентов формируют сеть.", Image = "images/ava2.png", Author = "Андрей Васильев", Workplace = "samogon-ont.ru"}
    };

    public static List<MenuLink> FooterChatLinks = new()
    {
        new MenuLink { Title = "О нас", Url = "#"},
        new MenuLink { Title = "Партнеры", Url = "#"},
        new MenuLink { Title = "Инструкция", Url = "#"},
        new MenuLink { Title = "Цены", Url = "#"},
        new MenuLink { Title = "Контакты", Url = "#"}
    };

    public static List<MenuLink> FooterSupportLinks = new()
    {
        new MenuLink { Title = "Центр поддержки", Url = "#"},
        new MenuLink { Title = "Политика конфеденциальности", Url = "#"},
        new MenuLink { Title = "Документы оферта", Url = "#"},
        new MenuLink { Title = "Документы оферта", Url = "#"},
        new MenuLink { Title = "Статус", Url = "#"}
    };
}
