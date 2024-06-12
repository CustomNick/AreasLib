-- Предполагаю следующую структуры таблиц:
--     table products(
--         id bigint primary key,
--         name text not null,
--         ...
--      );

--     table categories(
--         id bigint primary key,
--         name text not null,
--         ...
--      );

--     table products_categories(
--         product_id bigint references products(id),
--         category_id bigint references categories(id)
--      );

select
    products.name as product_name, categories.name as category_name
from products
left join products_categories
on products.id = products_categories.product_id
left join categories
on products_categories.category_id = categories.id;
