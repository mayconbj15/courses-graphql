CREATE TABLE courses (
    id serial primary key,
    name varchar NOT NULL,
    description varchar NOT NULL,
    review integer,
    dateadded timestamptz default now(),
    dateupdated timestamptz default now() NULL
);

INSERT INTO courses 
    (id, name, description, review)
VALUES 
    (0, 'English', 'English course', 10)
