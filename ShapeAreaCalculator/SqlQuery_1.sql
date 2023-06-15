if not exists (select 1 from information_schema.tables where table_name = 'products')
begin
  create table dbo.products(
    product_id int not null,
    name varchar(100) not null
    constraint PK_products primary key (product_id)
  )

  insert products(product_id, name) values (1, 'Хлеб'), (2, 'Колбаса'), (3, 'Мыло'), (4, 'Телевизор'), (5, 'Радио'), (6, 'Смартфон'), (7, 'Кастрюля'), (8, 'Цветок')
end

if not exists (select 1 from information_schema.tables where table_name = 'categories')
begin
  create table dbo.categories(
    category_id int not null,
    name varchar(100) not null,
    constraint PK_categories primary key (category_id)
  )

  insert categories(category_id, name) values (1, 'Продукты питания'), (2, 'Бытовая химия'), (3, 'Предметы первой необходимости'), (4, 'Электроника')
end

if not exists (select 1 from information_schema.tables where table_name = 'products_categories')
begin
  create table dbo.products_categories(
    product_id int not null,
    category_id int not null,
    constraint PK_products_categories primary key (product_id, category_id),
    constraint FK_products_categories_products foreign key (product_id) references dbo.products(product_id),
    constraint FK_products_categories_categories foreign key (category_id) references dbo.categories(category_id)
  )

  insert products_categories(product_id, category_id) values (1, 1), (2, 1), (3, 2), (4, 4), (5, 4), (6, 4), (1, 3), (3, 3)
end

select 
  product_name = products.name,
  category_name = categories.name
from products
  left join products_categories on products.product_id = products_categories.product_id
  left join categories on products_categories.category_id = categories.category_id