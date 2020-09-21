# WebApiGuideService
Directory Service

Запустить данный сервис можно через Visual Studio:
Выбрать в Solution Explorer файл WebApiGuideService.csproj, ПКМ => View => View in Browser (по умолчанию)

Далее можно в браузере вводить следующие адреса:

- localhost:44386/api/guides  - страница по умолчанию, выдает все справочники, которые есть.
- localhost:44386/api/guides/constructions  -  выдает все содержимое справочника объекты строительства.
- localhost:44386/api/guides/versions  -  выдает все содержимое справочника версии данных.
- localhost:44386/api/guides/metadata/id=1  -  выдает метаданные справочника объекты строительства.
- localhost:44386/api/guides/metadata/id=2  -  выдает метаданные справочника версии данных.

Все данные выводятся в Json формате.
