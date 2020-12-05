using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.Models;

namespace TeamProject.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.User.Any())
                content.User.AddRange(Users.Select(c => c.Value));

            if (!content.Responsible.Any())
                content.Responsible.AddRange(Responsibles.Select(c => c.Value));

            if (!content.Executor.Any())
                content.Executor.AddRange(Executors.Select(c => c.Value));

            if (!content.Shop.Any())
                content.Shop.AddRange(Shops.Select(c => c.Value));

            if (!content.TypeTechnic.Any())
                content.TypeTechnic.AddRange(TypesTechnic.Select(c => c.Value));

            if (!content.Place.Any())
                content.Place.AddRange(Places.Select(c => c.Value));

            content.SaveChanges();

            if (!content.Request.Any())
                content.Request.Add
                    (
                        new Request { Shop = Shops["КРС (Капитальный ремонт скважин)"], 
                                      ResponsibleId = 3, 
                                      begin = new DateTime(2020, 11, 2, 8, 0, 0), 
                                      end = new DateTime(2020, 11, 5, 20, 0, 0), 
                                      description = "Очистка забоя и ствола скважины от металлических предметов", 
                                      comment = "Более подробная информация о проводимых работах находится в прикреплённом файле",
                                      Place = Places["ЗАЯЛУ КП-19 Скв-117"]}
                    );

            content.SaveChanges();

            if (!content.Technic.Any())
                content.Technic.Add
                    (
                        new Technic
                        {
                            TypeTechnic = TypesTechnic["Самосвал Камаз"],
                            quantity = 5,
                            delay = 36,
                            duration = 12,
                            path = "Скв316_от_02_10.pdf",
                            ExecutorId = 6,
                            RequestId = 1
                        }
                     );

            content.Technic.Add
                    (
                        new Technic
                        {
                            TypeTechnic = TypesTechnic["Автокран"],
                            quantity = 2,
                            delay = 0,
                            duration = 36,
                            path = "Скв316_от_02_10.pdf",
                            ExecutorId = 1,
                            RequestId = 1
                        }
                     );


            content.SaveChanges();
        }

        private static Dictionary<string, User> user;
        private static Dictionary<int, Responsible> responsible;
        private static Dictionary<int, Executor> executor;
        private static Dictionary<string, Shop> shop;
        private static Dictionary<string, TypeTechnic> typeTechnic;
        private static Dictionary<string, Place> place;



        public static Dictionary<string, User> Users
        {
            get
            {
                if (user == null)
                {
                    var list = new User[]
                    {
                        new User {name = "Дубинин М.Р."},
                        new User {name = "Кулагин П.Б."},
                        new User {name = "Коротаев М.Я."},
                        new User {name = "Кривков Р.Г."},
                        new User {name = "Яременко О.К."},
                        new User {name = "Голубев П.Н."},
                        new User {name = "Солдатов М.О."},
                        new User {name = "Касьяненко И.А."},
                        new User {name = "Юрлов Т.С."},
                        new User {name = "Родзянко А.А."},
                        new User {name = "Красенков Г.Н."},
                        new User {name = "Арефьев Г.Н."},
                        new User {name = "Рябцев А.Д."},
                        new User {name = "Балаев Ф.П."}
                    };
                    user = new Dictionary<string, User>();
                    foreach (User el in list)
                        user.Add(el.name, el);
                }
                return user;
            }
        }

        public static Dictionary<int, Responsible> Responsibles
        {
            get
            {
                if (responsible == null)
                {
                    var list = new Responsible[]
                    {
                        new Responsible { User = Users["Кулагин П.Б."] },
                        new Responsible { User = Users["Коротаев М.Я."] },
                        new Responsible { User = Users["Кривков Р.Г."] },
                        new Responsible { User = Users["Родзянко А.А."] },
                        new Responsible { User = Users["Балаев Ф.П."] },
                        new Responsible { User = Users["Рябцев А.Д."] },
                        new Responsible { User = Users["Арефьев Г.Н."] },
                        new Responsible { User = Users["Красенков Г.Н."] },
                        new Responsible { User = Users["Дубинин М.Р."] }

                    };
                    responsible = new Dictionary<int, Responsible>();
                    int i = 0;
                    foreach (Responsible el in list)
                    {
                        responsible.Add(i, el);
                        i++;
                    }
                        
                }
                return responsible;
            }
        }


        public static Dictionary<int, Executor> Executors
        {
            get
            {
                if (executor == null)
                {
                    var list = new Executor[]
                    {
                        new Executor { User = Users["Кулагин П.Б."] },
                        new Executor { User = Users["Коротаев М.Я."] },
                        new Executor { User = Users["Кривков Р.Г."] },
                        new Executor { User = Users["Яременко О.К."] },
                        new Executor { User = Users["Голубев П.Н."] },
                        new Executor { User = Users["Солдатов М.О."] },
                        new Executor { User = Users["Касьяненко И.А."] },
                        new Executor { User = Users["Юрлов Т.С."] },
                        new Executor { User = Users["Дубинин М.Р."] }
                    };
                    executor = new Dictionary<int, Executor>();
                    int i = 0;
                    foreach (Executor el in list)
                    {
                        executor.Add(i, el);
                        i++;
                    }

                }
                return executor;
            }
        }

        public static Dictionary<string, Shop> Shops
        {
            get
            {
                if (shop == null)
                {
                    var list = new Shop[]
                    {
                        new Shop{name="КРС (Капитальный ремонт скважин)"},
                        new Shop{name="ПРС (Подземный ремонт скважин)"},
                        new Shop{name="ЦПП (Цех подготовки производства)"},
                        new Shop{name="ППД (Поддержание пластового давления)"},
                        new Shop{name="ПВС (Пароводоснабжение)"},
                        new Shop{name="ЦАП (Цех автоматизации производства)"},
                        new Shop{name="ЦКС (Цех крепления скважин)"},
                        new Shop{name="ПРЦЭО (Прокатно-ремонтный цех электрооборудования)"}
                    };
                    shop = new Dictionary<string, Shop>();
                    foreach (Shop el in list)
                        shop.Add(el.name, el);
                }
                return shop;
            }
        }


        public static Dictionary<string, TypeTechnic> TypesTechnic
        {
            get
            {
                if (typeTechnic == null)
                {
                    var list = new TypeTechnic[]
                    {
                        new TypeTechnic{name="ПАРМ Камаз", quantity=10},
                        new TypeTechnic{name="АРС Урал", quantity=10},
                        new TypeTechnic{name="АПРС Камаз", quantity=10},
                        new TypeTechnic{name="АДПМ на базе Камаз", quantity=10},
                        new TypeTechnic{name="Камаз бортовой с КМУ", quantity=10},
                        new TypeTechnic{name="Тягач Урал с КМУ", quantity=10},
                        new TypeTechnic{name="Самосвал Камаз", quantity=10},
                        new TypeTechnic{name="АИС Урал", quantity=10},
                        new TypeTechnic{name="Автогрейдер", quantity=10},
                        new TypeTechnic{name="Автокран", quantity=10}
                    };
                    typeTechnic = new Dictionary<string, TypeTechnic>();
                    foreach (TypeTechnic el in list)
                        typeTechnic.Add(el.name, el);
                }
                return typeTechnic;
            }
        }


        public static Dictionary<string, Place> Places
        {
            get
            {
                if (place == null)
                {
                    var list = new Place[]
                    {
                        new Place{name="ЗАЯЛУ КП-19 Скв-117"},
                        new Place{name="ЗАЯЛУ КП-24 Скв-201"},
                        new Place{name="ЗАЯЛУ КП-24 Скв-202"},
                        new Place{name="ЯНГКМ КП-31 Скв-214"},
                        new Place{name="ЯНГКМ КП-31 Скв-217"},
                        new Place{name="ЯНГКМ КП-43 Скв-316"},
                        new Place{name="ИНГКМ КП-1 1-Р"},
                        new Place{name="ИНГКМ КП-1 2-Р"},
                        new Place{name="ИНГКМ КП-2 Скв-41"},
                        new Place{name="ИНГКМ КП-2 Скв-42"},
                        new Place{name="ИНГКМ Кп-2 Скв-44"},


                    };
                    place = new Dictionary<string, Place>();
                    foreach (Place el in list)
                        place.Add(el.name, el);
                }
                return place;
            }
        }


    }
}
