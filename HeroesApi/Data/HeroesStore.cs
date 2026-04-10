using HeroesApi.Models;

namespace HeroesApi.Data;

public static class HeroesStore {
  public static List<Hero> Heroes { get; } = new List<Hero> {
    new Hero {
      Id = 1,
      Name = "Человек-паук",
      RealName = "Питер Паркер",
      Universe = Universe.Marvel,
      PowerLevel = 85,
      Powers = new List<string> { "Сверхчеловеческая сила", "Ловкость", "Прилипание к поверхностям", "Паучье чутье" },
      Weapon = new Weapon { Name = "ВебШутеры", IsRanged = true },
      InternalNotes = "Один из самых популярных героев Marvel."
    },
    new Hero {
      Id = 2,
      Name = "Бэтмен",
      RealName = "Брюс Уэйн",
      Universe = Universe.Dc,
      PowerLevel = 80,
      Powers = new List<string> { "Гениальный интеллект", "Мастер боевых искусств", "Высокая физическая подготовка" },
      Weapon = new Weapon { Name = "Разнообразные гаджеты", IsRanged = true },
      InternalNotes = "Темный рыцарь Готэма."
    },
    new Hero {
      Id = 3,
      Name = "Железный человек",
      RealName = "Тони Старк",
      Universe = Universe.Marvel,
      PowerLevel = 90,
      Powers = new List<string> { "Гениальный инженер", "Высокая физическая подготовка", "Полет" },
      Weapon = new Weapon { Name = "Теневая броня", IsRanged = false },
      InternalNotes = "Гений-изобретатель и миллиардер."
    },
      new Hero {
        Id = 4,
        Name = "Супермен",
        RealName = "Кларк Кент",
        Universe = Universe.Dc,
        PowerLevel = 100,
        Powers = new List<string> { "Сверхчеловеческая сила", "Полет", "Непробиваемость", "Тепловое зрение" },
        Weapon = new Weapon { Name = "Сила и способности", IsRanged = false },
        InternalNotes = "Самый мощный герой DC."
      },
    new Hero {
      Id = 5,
      Name = "Чудо-женщина",
      RealName = "Диана Принс",
      Universe = Universe.Dc,
      PowerLevel = 95,
      Powers = new List<string> { "Сверхчеловеческая сила", "Полет", "Бессмертие", "Боевые навыки" },
      Weapon = new Weapon { Name = "Лассо Истины", IsRanged = true },
      InternalNotes = "Амазонская принцесса и воительница."
    },
    new Hero {
      Id = 6,
      Name = "Тор",
      RealName = "Тор Одинсон",
      Universe = Universe.Marvel,
      PowerLevel = 95,
      Powers = new List<string> { "Сверхчеловеческая сила", "Полет", "Управление молниями", "Бессмертие" },
      Weapon = new Weapon { Name = "Мьёльнир", IsRanged = true },
      InternalNotes = "Бог грома и один из самых мощных героев Marvel."
    },
    new Hero {
      Id = 7,
      Name = "Халк",
      RealName = "Брюс Бэннер",
      Universe = Universe.Marvel,
      PowerLevel = 90,
      Powers = new List<string> { "Сверхчеловеческая сила", "Непробиваемость", "Регенерация" },
      Weapon = new Weapon { Name = "Сила и ярость", IsRanged = false },
      InternalNotes = "Гениальный ученый, превращающийся в монстра при гневе."
    }
  };
}