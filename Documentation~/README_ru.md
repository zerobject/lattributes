<div style="text-align: center;">

![logo](Assets/Logo.png)

Простой набор атрибутов для инспектора Unity.

[![License: MIT](https://img.shields.io/badge/License-MIT-indigo.svg)](https://opensource.org/licenses/MIT)
[![Releases](https://img.shields.io/github/release/zerobject/lattributes.svg)](https://github.com/zerobject/lattributes/releases)

</div>

---

> ### 📢Примечание
> Документация доступна на нескольких языках.
> #### [English](../README.md) | Русский

# 📜Содержание

- ### [🔎 Обзор](#обзор)
- ### [🚀 Возможности](#возможности)
- ### [📦 Установка](#установка)
- ### [🖥️ Быстрый старт](#быстрый-старт)
- ### [📚 Примеры](#примеры)
- ### [🪙 Поддержка](#поддержка)

# 🔎Обзор

**Laboost** — лёгкий и производительный Dependency Injection (DI) фреймворк для Unity,
вдохновлённый [Zenject](https://github.com/modesttree/Zenject)
и [Extenject](https://github.com/Mathijs-Bakker/Extenject), но с упором на:

- упрощённый API без лишней магии;
- высокую скорость работы и низкие аллокации;
- минимум зависимости от `MonoBehaviour`;
- модульную архитектуру, которую легко расширять.

Фреймворк реализует принципы IoC и автоматическое внедрение зависимостей по атрибутам или через конфигурацию, убирая
ручное связывание классов и облегчая тестирование.

# 🚀Возможности

- 📦 Простая установка через `Git URL` или `Unity Package`.
- ⚡ Высокая производительность и минимум аллокаций.
- 🎯 Атрибутное внедрение для полей, свойств и конструкторов.
- 🛠️ Поддержка `MonoBehaviour` и `ScriptableObject`.
- 🔁 Жизненные циклы: `Singleton`, `Transient`, `Scoped`.
- 🧩 Гибкая настройка контейнера.
- 🧪 Интеграция с модульными тестами.

# 📦Установка

- ### Через `Git URL` (рекомендуется)

1. Скопируйте: https://github.com/zerobject/laboost.git
2. Откройте Unity Package Manager (`Window -> Package Manager`)  `+` → Install package from Git URL...
3. Вставьте ссылку и нажмите `Add`.

- ### Ручная установка

1. Скачайте `.unitypackage` с [релизов](https://github.com/zerobject/laboost/releases).
2. В Unity: `Assets -> Import Package -> Custom Package...`
3. Выберите файл и импортируйте.

# 🖥️Быстрый старт

### 1. Определяем зависимости

```C#
public class PlayerService
{
    public void Attack() => Debug.Log("Игрок атакует!");
}

public class EnemyAI
{
    [Inject] 
    private PlayerService m_PlayerService;

    private void Update()
    {
        if (shouldAttack)
            m_PlayerService.Attack();
    }
}
```

### 2. Настраиваем контейнер

```C#
public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<PlayerService>().AsSingle();
        Container.Bind<EnemyAI>().AsTransient();
    }
}
```

# 📚Примеры

### Регистрация в контейнере

```C#
Container.Bind<TestClassA>().AsSingle();
Container.Bind<TestClassB>().AsTransient();
```

### Внедрение в MonoBehaviour

```C#
public class Player : MonoBehaviour
{
    [Inject]
    private IWeapon _weapon;

    private void Start()
    {
        _weapon.Fire();
    }

}
```

# 🪙Поддержка

Если проект оказался полезен:

- Поставьте ⭐ на GitHub
- Сообщите о баге в [Issues](https://github.com/zerobject/laboost/issues)
- Предложите улучшения в Discussions
