Салон оптики
Описание предметной области 
            Цель салона оптики состоит в оказании качественных услуг в области офтальмологии и забота о здоровье населения. На сегодняшний день порядка 40 млн. жителей России страдают заболеваниями органами зрения и нуждаются в средствах коррекции. В ассортимент салона оптики будут входить готовые средства бесконтактной коррекции (очки), средства контактной коррекции (контактны линзы), а также солнцезащитные очки, средства по уходу, аксессуары.    
   Салоны оптики справедливо считаются одними из «вечных» отраслей бизнеса. Глаза являются самым нежным органом, поэтому экономия на очках или линзах либо полный отказ от их применения практически невозможен. На отечественном рынке наблюдаются тенденции по повышению качества потребления. Все больше россиян начинают отдавать предпочтение покупке средств коррекции зрения в специализированных салонах, нежели покупке в так называемых «нецивилизованных» местах торговли, то есть на рынках и лотках. Уровень плотности сильно зависит от конкретного месторасположения торговой точки.
     Основными услугами будут являться услуги по квалифицированной проверке зрения и подбору средств коррекции, а также продажа готовых очков, оправ, очковых линз, контактных линз и аксессуаров.
   Следовательно, целью качественной работы салонов оптики является разработка автоматизированной системы управления принятия клиентов на обслуживание. Комплексная автоматизация управления предприятия на сегодняшний день - один из самых эффективных и функциональных инструментов систематизации работы ключевых бизнес-процессов. Зачастую управление бизнес-процессами становится трудоемким, а анализ большого потока первичных данных отнимает много сил, времени. В условиях современной жизни требуется ускорение процессов обработки информации. Этот процесс подлежит автоматизации, так как обработка информации очень долгий, кропотливый и требующий больших ресурсов процесс. 
    Обслуживание клиентов, которые хотят оформить заказ, должно проходить быстро, тем самым и регистрация клиента должна оформляться быстро. Следовательно, есть необходимость в ускорении данного процесса.

 Описание бизнеса, продукта или услуги
             В настоящее время салоны оптики пользуются большой популярностью у населения. Множество людей хотят получить полный сервис: прийти, провести диагностику зрения, подобрать и приобрести очки.
         Основными видами деятельности салонов оптики является продажа очков и линз, ремонт сломанных очков, а также продажа сопутствующих товаров.
                В магазине оптики  к продаже будут предлагаться следующий ассортимент:
    • Очки для коррекции зрения
    • Очки солнцезащитные
    • Линзы
    • Средства по уходу за очками и линзами
    • Очки для вождения
                  По мере развития бизнеса данный ассортимент можно расширять и дополнять.
Факторы риска
                  К ключевым рискам при открытии магазина можно отнести:
    • Риск бракованной или контрафактной продукции
        Данный риск связан с тем, что поставщики могут поставлять контрафактую продукцию. Для снижения данного риска необходимо проверять все документы на продукцию, а также контрагентов, с которыми вы работаете.
  Разработка логической модели данных
Описание основных сущностей ПО
            На основании проведенного анализа предметной области можно выделить следующие сущности:
    • Клиент — человек готовый пользоваться товарами и услугами , которые ему предлагают.
    • Сотрудники —перечень людей оказывающих услуги.
    • Должность — это служебное положение работника, обусловленное кругом его обязанностей, должностными правами и характере.
    • Услуги — перечень услуг, которые оказываются сотрудниками клиенту.
    • Товары — перечень товаров, которые клиент может приобрести.
    • Клиентская база  — вся информация о товарах и услугах, которые клиент может просмотреть и выбрать необходимое.
 Для  каждой сущности  есть атрибуты :
    • Для сущности Клиент атрибутами будут является  ФИО_клиента и контактный номер.
    • Для  сущности Сотрудники - это Индентификатор_сотрудника, ФИО_сотрудника, Индентификатор_должности.
    • Для сущности Должность — Индентификатор_должности и Название_должности.
    • Для сущности Усуги — Индентификатор_услуги, Название_услуги, дата приема, цена.
    • Для Товары — Название товара, Индентификатор_товара, Цена
    • Для Клиентской базы — Индентификатор_клиента, Обработка запроса  об оказании услуг специалистом , Обработка запроса об покупке товаров.
      
![2](https://user-images.githubusercontent.com/113527860/198085705-43447f6c-8c80-4658-99b5-dc1872793f13.png)

Рисунок 1 — Логическая модель хранимых данных
Проблематика 
             Информационная система подходит для  постоянных пользователей. Она в первую очередь должна давать возможность клиентам покупать и заказывать необходимые товары , а так же записываться на необходимые услуги и хранить о них все информацию. В последние годы все больше людей стало пользоваться онлайн сервисами. Но есть определенные проблемы вот некоторые из них. Во-первых,  приложения/сайты  не всегда  бывают понятны для пользователя . То есть пользователи заходя на сайт не может сам разобраться как оформить заказ или куда кликнуть, чтобы узнать условия доставки. Во-вторых, распространенная проблема сложность при оформлении заказа. В третьих, самое банальное это устаревший дизайн. Порой нет даже обычной темной темы и т. д. Существует несколько решений данных проблем. Во-первых, написание инструкции для пользователя. Во-вторых, сведение к минимуму количества анкетных вопросов. В третьих, предоставление пользователю  возможности графических настроек.
   

    
