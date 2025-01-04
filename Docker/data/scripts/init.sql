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
    (1, 'English', 'English course', 10)

INSERT INTO courses 
    (id, name, description, review)
VALUES 
    (1, 'Spanish', 'Spanish course', 10)

INSERT INTO courses 
    (id, name, description, review)
VALUES 
    (1, 'French', 'French course', 10)